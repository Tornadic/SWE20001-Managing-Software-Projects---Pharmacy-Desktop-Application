﻿#pragma checksum "..\..\..\Pages\SalesMainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4341E1C6DB6E123D8DAD3617AAF34675AD5178A5AAF47B1F70CE3142C1758E35"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Pharmacy_Desktop_Application;
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


namespace Pharmacy_Desktop_Application {
    
    
    /// <summary>
    /// SalesMainPage
    /// </summary>
    public partial class SalesMainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pages\SalesMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMainSale;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\SalesMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditSale;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\SalesMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSale;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\SalesMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame SaleFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/Pharmacy-Desktop-Application;component/pages/salesmainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\SalesMainPage.xaml"
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
            this.btnMainSale = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Pages\SalesMainPage.xaml"
            this.btnMainSale.Click += new System.Windows.RoutedEventHandler(this.BtnClickMainSale);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnEditSale = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\SalesMainPage.xaml"
            this.btnEditSale.Click += new System.Windows.RoutedEventHandler(this.BtnClickEditSale);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAddSale = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\SalesMainPage.xaml"
            this.btnAddSale.Click += new System.Windows.RoutedEventHandler(this.BtnClickAddSale);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SaleFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

