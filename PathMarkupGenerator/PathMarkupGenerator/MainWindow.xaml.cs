using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using PathShapeGenerator;

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

        private string _widthOffset = "0";
        public string WidthOffset
        {
            get
            {
                return _widthOffset;
            }
            set
            {
                _widthOffset = value;
                OnPropertyChanged();
            }
        }

        private string _heightOffset = "0";
        public string HeightOffset
        {
            get
            {
                return _heightOffset;
            }
            set
            {
                _heightOffset = value;
                OnPropertyChanged();
            }
        }

        private string _widthOutputOffset = "0";
        public string WidthOutputOffset
        {
            get
            {
                return _widthOutputOffset;
            }
            set
            {
                _widthOutputOffset = value;
                OnPropertyChanged();
            }
        }

        private string _heightOutputOffset = "0";
        public string HeightOutputOffset
        {
            get
            {
                return _heightOutputOffset;
            }
            set
            {
                _heightOutputOffset = value;
                OnPropertyChanged();
            }
        }

        private string _targetWidth = "100";
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

        private string _targetHeight = "100";
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

                if (value != SelectedPreset?.PathData)
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

            if (Int32.TryParse(ReferenceWidth, out int refW) && Int32.TryParse(ReferenceHeight, out int refH) && Single.TryParse(WidthOffset, out float offW) && Single.TryParse(HeightOffset, out float offH) && Int32.TryParse(TargetWidth, out int tarW) && Int32.TryParse(TargetHeight, out int tarH) && Single.TryParse(WidthOutputOffset, out float outOffW) && Single.TryParse(HeightOutputOffset, out float outOffH))
            {
                OutputData = PathConverter.ResizePathData(refW, refH, offW, offH, tarW, tarH, outOffW, outOffH, InputData);
            }
        }

        private void Button_Click_Generate(object sender, RoutedEventArgs e)
        {
            GenerateOutput();
        }
        private void Button_Click_Preview(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(ReferenceWidth, out int refW) && Int32.TryParse(ReferenceHeight, out int refH) && Single.TryParse(WidthOffset, out float offW) && Single.TryParse(HeightOffset, out float offH) && Int32.TryParse(TargetWidth, out int tarW) && Int32.TryParse(TargetHeight, out int tarH) && Single.TryParse(WidthOffset, out float outOffW) && Single.TryParse(HeightOffset, out float outOffH))
            {
                ShowPreview();
            }
        }

        private void ShowPreview()
        {
            PreviewWindow preview = new PreviewWindow();
            preview.Owner = this;


            preview.PathPreviewBefore.Width = Int32.Parse(ReferenceWidth);
            preview.PathPreviewBefore.Height = Int32.Parse(ReferenceHeight);
            preview.PathPreviewBefore.Data = Geometry.Parse(InputData);

            preview.PathPreviewAfter.Width = Int32.Parse(TargetWidth);
            preview.PathPreviewAfter.Height = Int32.Parse(TargetHeight);
            preview.PathPreviewAfter.Data = Geometry.Parse(OutputData);

            preview.SizeToContent = SizeToContent.WidthAndHeight;
            preview.Show();
        }
    }
}
