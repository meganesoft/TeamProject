<<<<<<< HEAD
﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0F1A5BD1308C5A52C63A0B6D7A5FB902"
=======
﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EF4788913CA8B0F407BB46C8CB1BBFA1"
>>>>>>> c2bff2f3b9337fa422d06efaf9745410876e5130
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Livet;
using Livet.Behaviors;
using Livet.Behaviors.ControlBinding;
using Livet.Behaviors.ControlBinding.OneWay;
using Livet.Behaviors.Messaging;
using Livet.Behaviors.Messaging.IO;
using Livet.Behaviors.Messaging.Windows;
using Livet.Commands;
using Livet.Converters;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.Messaging.Windows;
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
using System.Windows.Interactivity;
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
using TeamProject;
using TeamProject.Models;
using TeamProject.ViewModels;
using TeamProject.Views;


namespace TeamProject.Views {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas mycanvas;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
<<<<<<< HEAD
        #line 44 "..\..\..\Views\MainWindow.xaml"
=======
        #line 48 "..\..\..\Views\MainWindow.xaml"
>>>>>>> c2bff2f3b9337fa422d06efaf9745410876e5130
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
<<<<<<< HEAD
        #line 59 "..\..\..\Views\MainWindow.xaml"
=======
        #line 63 "..\..\..\Views\MainWindow.xaml"
>>>>>>> c2bff2f3b9337fa422d06efaf9745410876e5130
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
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
            System.Uri resourceLocater = new System.Uri("/TeamProject;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            
            #line 13 "..\..\..\Views\MainWindow.xaml"
            ((TeamProject.Views.MainWindow)(target)).ContentRendered += new System.EventHandler(this.Window_ContentRendered);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mycanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.label = ((System.Windows.Controls.Label)(target));
            
            #line 46 "..\..\..\Views\MainWindow.xaml"
            this.label.Loaded += new System.Windows.RoutedEventHandler(this.label_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button = ((System.Windows.Controls.Button)(target));
            
<<<<<<< HEAD
            #line 44 "..\..\..\Views\MainWindow.xaml"
=======
            #line 48 "..\..\..\Views\MainWindow.xaml"
>>>>>>> c2bff2f3b9337fa422d06efaf9745410876e5130
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button1 = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

