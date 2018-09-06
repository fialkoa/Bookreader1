using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace bookreader1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tv_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            //int id = Convert.ToInt32(tv.SelectedValue);
            //MessageBox.Show(id.ToString());
            var key = tv.SelectedValue;
            string path = @"..\..\pages\" + key.ToString() + ".xaml";
            fdr.Document = (FlowDocument)XamlReader.Load(File.OpenRead(path));
        }
    }
}
