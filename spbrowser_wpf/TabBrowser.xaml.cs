﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using CefSharp;

namespace spbrowser_wpf
{
    /// <summary>
    /// Логика взаимодействия для TabBrowser.xaml
    /// </summary>
    public partial class TabBrowser : System.Windows.Controls.UserControl
    {
        public CefWebBrowser browser;

        public TabBrowser()
        {
            InitializeComponent();
        }
    }
}
