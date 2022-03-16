﻿using System;
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

#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。

namespace wdos.builtIn.controls
{
    /// <summary>
    /// wdos_icon.xaml 的交互逻辑
    /// </summary>
    public partial class wdos_icon : UserControl
    {
        public wdos_icon()
        {
            InitializeComponent();
        }

        public SolidColorBrush ThemeColor
        {
            get { return (SolidColorBrush)GetValue(ThemeColorProperty); }
            set { SetValue(ThemeColorProperty, value); }
        }

        public static readonly DependencyProperty ThemeColorProperty =
            DependencyProperty.Register("ThemeColor", typeof(SolidColorBrush), typeof(wdos_icon),
                new PropertyMetadata((SolidColorBrush)new BrushConverter().ConvertFrom("#FF506496")));

    }
}

#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。