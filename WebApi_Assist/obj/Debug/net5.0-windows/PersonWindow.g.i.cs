﻿#pragma checksum "..\..\..\PersonWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6DBCAB1AE71D3A68671D775499949C0C41845CC7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WebApi_Client;


namespace WebApi_Client {
    
    
    /// <summary>
    /// PersonWindow
    /// </summary>
    public partial class PersonWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\PersonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MovePanel;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\PersonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\PersonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\PersonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateOfBirthDatePicker;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\PersonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CityTextBox;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\PersonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StreetHouseTextBox;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\PersonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CardNumTextBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\PersonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProblemTextBox;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\PersonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DiagnoseTextBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\PersonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AddedTimeText;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\PersonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WebApi_Assist;V1.0.0.0;component/personwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PersonWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MovePanel = ((System.Windows.Controls.StackPanel)(target));
            
            #line 42 "..\..\..\PersonWindow.xaml"
            this.MovePanel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MovePanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 45 "..\..\..\PersonWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Close);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FirstNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.LastNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DateOfBirthDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.CityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.StreetHouseTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.CardNumTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ProblemTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.DiagnoseTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.AddedTimeText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.CreateButton = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\PersonWindow.xaml"
            this.CreateButton.Click += new System.Windows.RoutedEventHandler(this.CreateButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

