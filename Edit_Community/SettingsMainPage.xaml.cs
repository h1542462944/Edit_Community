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

namespace Edit_Community
{
    /// <summary>
    /// SettingsMainPage.xaml 的交互逻辑
    /// </summary>
    public partial class SettingsMainPage : Page
    {
        public SettingsMainPage()
        {
            InitializeComponent();
        }

        private void UImageMenu_Tapped(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(UImgTheme))
            {
                AppData.PageNavigationHelper.Add(typeof(ThemePage));
            }
            else if (sender.Equals(UImgExtension))
            {
                AppData.PageNavigationHelper.Add(typeof(ExtensionPage));
            }
            else if (sender.Equals(UImgHelp))
            {
                AppData.PageNavigationHelper.Add(typeof(HelpPage));
            }
            else if (sender.Equals(UImgDeveloper))
            {
                AppData.PageNavigationHelper.Add(typeof(DeveloperPage));
            }
        }
    }
}
