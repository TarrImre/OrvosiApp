﻿#pragma checksum "..\..\..\EditPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A23D0255919ED5CC525D2E07A9F5B0070AA7D592"
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
    /// EditPage
    /// </summary>
    public partial class EditPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MovePanel;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameTextBoxEDIT;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameTextBoxEDIT;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateOfBirthDatePickerEDIT;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CityTextBoxEDIT;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StreetHouseTextBoxEDIT;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CardNumTextBoxEDIT;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProblemTextBoxEDIT;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DiagnoseTextBoxEDIT;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateButton;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateButton;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WebApi_Client;component/editpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EditPage.xaml"
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
            
            #line 41 "..\..\..\EditPage.xaml"
            this.MovePanel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MovePanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 44 "..\..\..\EditPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Close);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FirstNameTextBoxEDIT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.LastNameTextBoxEDIT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DateOfBirthDatePickerEDIT = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.CityTextBoxEDIT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.StreetHouseTextBoxEDIT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.CardNumTextBoxEDIT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ProblemTextBoxEDIT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.DiagnoseTextBoxEDIT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.CreateButton = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\EditPage.xaml"
            this.CreateButton.Click += new System.Windows.RoutedEventHandler(this.CreateButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.UpdateButton = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\EditPage.xaml"
            this.UpdateButton.Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\EditPage.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

