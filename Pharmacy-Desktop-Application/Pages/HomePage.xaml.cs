using System;
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
using Microsoft.Toolkit.Uwp.Notifications;

namespace Pharmacy_Desktop_Application
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private int lowStock = 0;

        public HomePage()
        {
            InitializeComponent();

            //Notification for low stock
            var runSQL = SQLobj.Instance();
            List<List<string>> products = runSQL.QueryDB("SELECT * from PHPProducts");
            foreach (List<string> product in products)
            {
                if (int.Parse(product[2]) < 100)
                    lowStock += 1;
            }

            if (lowStock > 0)
            {
                string notifs = lowStock > 1 ? string.Format("You have {0} products low on stock", lowStock) : "You have 1 product low on stock";
                new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText(notifs)
                .AddText("Click here to see products.")
                .AddAppLogoOverride(new Uri("https://picsum.photos/48?image=883"))
                .Show();
            }
        }
    }
}