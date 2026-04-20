using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Lab20_Binding
{
    public partial class MainWindow : Window
    {
        private DataSource _dataSource;

        public MainWindow()
        {
            InitializeComponent();
            _dataSource = new DataSource();
            this.DataContext = _dataSource;
        }

        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            _dataSource.PanelColor = Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));
        }

        private void CreateDynamicBinding_Click(object sender, RoutedEventArgs e)
        {
            if (DynamicLabel.GetBindingExpression(TextBlock.TextProperty) != null)
                return;

            Binding dynamicBinding = new Binding("Age")
            {
                Source = _dataSource,
                Mode = BindingMode.OneWay,
                StringFormat = "Динамическая привязка: возраст = {0} лет"
            };
            DynamicLabel.SetBinding(TextBlock.TextProperty, dynamicBinding);
            DynamicButton.Content = "Привязка создана";
            DynamicButton.IsEnabled = false;
        }
    }
}