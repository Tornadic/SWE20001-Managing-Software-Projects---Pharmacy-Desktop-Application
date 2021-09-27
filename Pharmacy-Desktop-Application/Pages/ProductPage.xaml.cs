﻿using System;
using System.Collections.Generic;
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
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace Pharmacy_Desktop_Application
{
    /// <summary>
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void BtnClickSubmit(object sender, RoutedEventArgs e)
        {
            if (txtProdName.Text != "" && txtProdPrice.Text != "" && txtProdSKU.Text != "" && txtProdStock.Text != "")
            {
                var runSQL = SQLobj.Instance();
                runSQL.QueryDB(string.Format("INSERT INTO PHPProducts VALUES ('{0}','{1}','{2}','{3}')", txtProdSKU.Text, txtProdName.Text, txtProdStock.Text, txtProdPrice.Text));
                NavigationService.Navigate(new ProductSearchPage());
                txtProdName.Text = "";
                txtProdSKU.Text = ""; 
                txtProdStock.Text = ""; 
                txtProdPrice.Text = "";
                var message = "Sample message";
                var xml = $"<?xml version=\"1.0\"?><toast><visual><binding template=\"ToastText01\"><text id=\"1\">{message}</text></binding></visual></toast>";
                var toastXml = new XmlDocument();
                toastXml.LoadXml(xml);
                var toast = new ToastNotification(toastXml);
                ToastNotificationManager.CreateToastNotifier("Product created").Show(toast);
            }
        }
    }
}
