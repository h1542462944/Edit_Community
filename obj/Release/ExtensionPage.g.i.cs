﻿#pragma checksum "..\..\ExtensionPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C7BBA51EE000D99ED856AA6519AE69D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Edit_Community;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using User.UI;


namespace Edit_Community {
    
    
    /// <summary>
    /// ExtensionPage
    /// </summary>
    public partial class ExtensionPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\ExtensionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal User.UI.TriggerSwitch TSText;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ExtensionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblText;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ExtensionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal User.UI.TriggerSwitch TSEditMode;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ExtensionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblEditMode;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\ExtensionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal User.UI.TriggerSwitch TSWeather;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ExtensionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblWeather;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\ExtensionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal User.UI.TriggerSwitch TSAutoCheck;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Edit Community;component/extensionpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ExtensionPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\ExtensionPage.xaml"
            ((User.UI.UImageMenu)(target)).Tapped += new System.Windows.RoutedEventHandler(this.UImageMenu_Tapped);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TSText = ((User.UI.TriggerSwitch)(target));
            
            #line 22 "..\..\ExtensionPage.xaml"
            this.TSText.Tapped += new System.Windows.RoutedEventHandler(this.TSText_Tapped);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LblText = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TSEditMode = ((User.UI.TriggerSwitch)(target));
            
            #line 33 "..\..\ExtensionPage.xaml"
            this.TSEditMode.Tapped += new System.Windows.RoutedEventHandler(this.TSEditMode_Tapped);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LblEditMode = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.TSWeather = ((User.UI.TriggerSwitch)(target));
            
            #line 44 "..\..\ExtensionPage.xaml"
            this.TSWeather.Tapped += new System.Windows.RoutedEventHandler(this.TSWeather_Tapped);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LblWeather = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.TSAutoCheck = ((User.UI.TriggerSwitch)(target));
            
            #line 56 "..\..\ExtensionPage.xaml"
            this.TSAutoCheck.Tapped += new System.Windows.RoutedEventHandler(this.TSAutoCheck_Tapped);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

