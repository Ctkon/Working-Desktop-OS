﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wdos.builtIn
{
    /// <summary>
    /// Startup.xaml 的交互逻辑
    /// </summary>
    public partial class StartupUI : UserControl
    {
        public StartupUI()
        {
            InitializeComponent();

            new Thread(() =>
            {
                Thread.Sleep(500);
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    BeginAnimation(OpacityProperty, new DoubleAnimation()
                    {
                        From = 0, To = 1, Duration = new TimeSpan(0, 0, 0, 0, 400),
                        EasingFunction = new CubicEase()
                        {
                            EasingMode = EasingMode.EaseOut
                        }
                    });
                }));
                Thread.Sleep(6000);
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    App.mainWin.Inject(new LogIn(2000), "PasswdBox");
                }));
            }).Start();
        }
    }
}
