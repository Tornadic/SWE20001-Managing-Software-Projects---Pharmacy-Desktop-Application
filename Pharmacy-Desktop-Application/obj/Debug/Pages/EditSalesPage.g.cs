﻿#pragma checksum "..\..\..\Pages\EditSalesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BF49F80F2401CAD2A09A9EDB4EEDC437830649F6A151FCA0F4F7EF5E4C07D64F"
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
    /// EditSalesPage
    /// </summary>
    public partial class EditSalesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Pages\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Content;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtSaleDate;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmxItemProduct;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtItemQuantity;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnItemAdd;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnItemEdit;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox txtItemList;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaleSubmit;
        
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
            System.Uri resourceLocater = new System.Uri("/Pharmacy-Desktop-Application;component/pages/editsalespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\EditSalesPage.xaml"
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
            this.Content = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtSaleDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.cmxItemProduct = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txtItemQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnItemAdd = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Pages\EditSalesPage.xaml"
            this.btnItemAdd.Click += new System.Windows.RoutedEventHandler(this.BtnItemAdd);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnItemEdit = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Pages\EditSalesPage.xaml"
            this.btnItemEdit.Click += new System.Windows.RoutedEventHandler(this.BtnItemAdd);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtItemList = ((System.Windows.Controls.ListBox)(target));
            
            #line 51 "..\..\..\Pages\EditSalesPage.xaml"
            this.txtItemList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TxtItemList_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSaleSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Pages\EditSalesPage.xaml"
            this.btnSaleSubmit.Click += new System.Windows.RoutedEventHandler(this.BtnSaleSubmit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

