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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LogBookWPF
{
    /// <summary>
    /// Interaction logic for LogBookTask.xaml
    /// </summary>
    public partial class LogBookTask : Window
    {
        public LogBookTask()
        {
            InitializeComponent();
        }

        private void btnDailyRegister_Click(object sender, RoutedEventArgs e)
        {
            DailyRegister daily = new DailyRegister();
            daily.Show();
        }
    }
}
