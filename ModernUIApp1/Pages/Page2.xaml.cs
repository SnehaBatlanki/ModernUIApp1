using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModernUIApp1.Pages
{
    /// <summary>
    /// Interaction logic for BasicPage1.xaml
    /// </summary>
    public partial class BasicPage1 : UserControl
    {
          public BasicPage1()
        {
            InitializeComponent();            
          }
          void OnLoad(object sender, RoutedEventArgs e)
          {
              BasicPage1 obj = new BasicPage1();
              Chitvalue.Text = BasicPage.chitvalue.ToString();
              Months.Text = BasicPage.numberofmonths.ToString();
              Subscription.Text = BasicPage.monthlysubscription.ToString();
              Auction.Text = BasicPage.auctionvalue.ToString();
              Bid.Text = BasicPage.bidamount.ToString();
              Commission.Text = BasicPage.divident.ToString();
              Amount.Text = BasicPage.installment.ToString();
         }

          private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
          {

          }
     
    
    }
}
