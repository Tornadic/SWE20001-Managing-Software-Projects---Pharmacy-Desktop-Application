#pragma checksum "..\..\EditSalesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3164D5BEAC158E670198E2A9471182EAE99A04962FCFF707F52AE559F03E3EE9"
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
        
        
        #line 28 "..\..\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Content;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtSaleDate;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmxItemProduct;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtItemQuantity;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnItemAdd;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox txtItemList;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\EditSalesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaleRevert;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\EditSalesPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Pharmacy-Desktop-Application;component/editsalespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditSalesPage.xaml"
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
            
            #line 45 "..\..\EditSalesPage.xaml"
            this.btnItemAdd.Click += new System.Windows.RoutedEventHandler(this.BtnItemAdd);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtItemList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.btnSaleRevert = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\EditSalesPage.xaml"
            this.btnSaleRevert.Click += new System.Windows.RoutedEventHandler(this.BtnClickRevert);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSaleSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\EditSalesPage.xaml"
            this.btnSaleSubmit.Click += new System.Windows.RoutedEventHandler(this.BtnSaleSubmit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

