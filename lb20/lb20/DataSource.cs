using System.ComponentModel;
using System.Windows.Media;

namespace Lab20_Binding
{
    public class DataSource : INotifyPropertyChanged
    {
        private string _name = "Иван Иванов";
        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        private bool _isActive = true;
        public bool IsActive
        {
            get => _isActive;
            set { _isActive = value; OnPropertyChanged(nameof(IsActive)); }
        }

        private int _age = 25;
        public int Age
        {
            get => _age;
            set { _age = value; OnPropertyChanged(nameof(Age)); }
        }

        private double _score = 85.4;
        public double Score
        {
            get => _score;
            set { _score = value; OnPropertyChanged(nameof(Score)); }
        }

        private Color _panelColor = Colors.LightGreen;
        public Color PanelColor
        {
            get => _panelColor;
            set { _panelColor = value; OnPropertyChanged(nameof(PanelColor)); }
        }

        private string _fontName = "Arial";
        public string FontName
        {
            get => _fontName;
            set { _fontName = value; OnPropertyChanged(nameof(FontName)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}