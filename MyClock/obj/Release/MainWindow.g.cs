﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7965C1F8F2BAA7DEFC3FA2BD068DB3567ACFE7675F1C954BB47628C432B9197C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MyClock;
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


namespace MyClock {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MyClock.MainWindow MainWin;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AnalogClockMenuItem;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DigitalClockMenuItem;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DateMenuItem;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ontop1;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 249 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ontop2;
        
        #line default
        #line hidden
        
        
        #line 278 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas analogClock;
        
        #line default
        #line hidden
        
        
        #line 591 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle HoursHand;
        
        #line default
        #line hidden
        
        
        #line 607 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle MinutesHand;
        
        #line default
        #line hidden
        
        
        #line 624 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle SecondsHand;
        
        #line default
        #line hidden
        
        
        #line 641 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock digitalClock;
        
        #line default
        #line hidden
        
        
        #line 650 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock date;
        
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
            System.Uri resourceLocater = new System.Uri("/Clock;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.MainWin = ((MyClock.MainWindow)(target));
            
            #line 11 "..\..\MainWindow.xaml"
            this.MainWin.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AnalogClockMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 204 "..\..\MainWindow.xaml"
            this.AnalogClockMenuItem.Click += new System.Windows.RoutedEventHandler(this.AnalogClockMenuItem_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DigitalClockMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 209 "..\..\MainWindow.xaml"
            this.DigitalClockMenuItem.Click += new System.Windows.RoutedEventHandler(this.DigitalClockMenuItem_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DateMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 214 "..\..\MainWindow.xaml"
            this.DateMenuItem.Click += new System.Windows.RoutedEventHandler(this.DateMenuItem_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ontop1 = ((System.Windows.Controls.MenuItem)(target));
            
            #line 220 "..\..\MainWindow.xaml"
            this.ontop1.Click += new System.Windows.RoutedEventHandler(this.OnTopButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 222 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MinimizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 227 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.ontop2 = ((System.Windows.Controls.MenuItem)(target));
            
            #line 250 "..\..\MainWindow.xaml"
            this.ontop2.Click += new System.Windows.RoutedEventHandler(this.OnTopButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 252 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MinimizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 257 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 270 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MinimizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 273 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.analogClock = ((System.Windows.Controls.Canvas)(target));
            return;
            case 15:
            this.HoursHand = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 16:
            this.MinutesHand = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 17:
            this.SecondsHand = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 18:
            this.digitalClock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 19:
            this.date = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

