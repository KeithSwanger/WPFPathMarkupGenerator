using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Diagnostics;

namespace PathMarkupGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ShapePreset> Presets { get; set; } = new ObservableCollection<ShapePreset>(ShapePresets.AllPresets);

        private ShapePreset _selectedPreset = null;
        public ShapePreset SelectedPreset
        {
            get
            {
                return _selectedPreset;
            }
            set
            {
                _selectedPreset = value;

                if (_selectedPreset != null)
                {
                    ReferenceWidth = _selectedPreset.ReferenceWidth.ToString();
                    ReferenceHeight = _selectedPreset.ReferenceHeight.ToString();
                    InputData = _selectedPreset.PathData;
                }

                OnPropertyChanged();
            }
        }

        private string _referenceWidth;
        public string ReferenceWidth
        {
            get
            {
                return _referenceWidth;
            }
            set
            {
                _referenceWidth = value;
                OnPropertyChanged();

                if (value != SelectedPreset?.ReferenceWidth.ToString())
                {
                    SelectedPreset = null;
                }
            }
        }

        private string _referenceHeight;
        public string ReferenceHeight
        {
            get
            {
                return _referenceHeight;
            }
            set
            {
                _referenceHeight = value;
                OnPropertyChanged();

                if (value != SelectedPreset?.ReferenceHeight.ToString())
                {
                    SelectedPreset = null;
                }
            }
        }

        private string _targetWidth;
        public string TargetWidth
        {
            get
            {
                return _targetWidth;
            }
            set
            {
                _targetWidth = value;
                OnPropertyChanged();
            }
        }

        private string _targetHeight;
        public string TargetHeight
        {
            get
            {
                return _targetHeight;
            }
            set
            {
                _targetHeight = value;
                OnPropertyChanged();
            }
        }

        private string _inputData;
        public string InputData
        {
            get
            {
                return _inputData;
            }
            set
            {
                _inputData = value;
                OnPropertyChanged();

                if(value != SelectedPreset?.PathData)
                {
                    SelectedPreset = null;
                }
            }
        }

        private string _outputData;
        public string OutputData
        {
            get
            {
                return _outputData;
            }
            set
            {
                _outputData = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }


        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void GenerateOutput()
        {

            if (Int32.TryParse(ReferenceWidth, out int refW) && Int32.TryParse(ReferenceHeight, out int refH) && Int32.TryParse(TargetWidth, out int tarW) && Int32.TryParse(TargetHeight, out int tarH))
            {
                OutputData = PathConverter.ResizePathData(refW, refH, tarW, tarH, InputData);
            }
        }

        private void Button_Click_Generate(object sender, RoutedEventArgs e)
        {
            GenerateOutput();
        }
    }
}
