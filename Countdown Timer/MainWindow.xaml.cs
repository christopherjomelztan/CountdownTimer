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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Countdown_Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int time = 3700;
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (time > 10)
            {
                time--;
                TBCountDown.Text = string.Format("{0}:{1}:{2}", time / 3600, time / 60, time % 60);
            }
            else
            {
                timer.Stop();
                MessageBox.Show(messageBoxText: "Timer Up!", icon: MessageBoxImage.Exclamation, caption:"Countdown Timer", button:MessageBoxButton.OK);
            }
        }
    }
}
