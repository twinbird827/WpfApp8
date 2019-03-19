using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

namespace WpfApp8
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(IsChecked.ToString());
        }

        public bool IsChecked
        {
            get { return _IsChecked; }
            set {
                _IsChecked = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(IsChecked)));
                Console.WriteLine($"Test.IsFocused: {Test.IsFocused}/Test.IsKeyboardFocused:{Test.IsKeyboardFocused}/Test.IsKeyboardFocusWithin:{Test.IsKeyboardFocusWithin}");
                Console.WriteLine($"Test2.IsFocused: {Test2.IsFocused}/Test2.IsKeyboardFocused:{Test2.IsKeyboardFocused}/Test2.IsKeyboardFocusWithin:{Test2.IsKeyboardFocusWithin}");
            }
        }
        private bool _IsChecked;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
