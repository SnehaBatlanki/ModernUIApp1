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
    /// Interaction logic for BasicPage.xaml
    /// </summary>
    public partial class BasicPage : UserControl
    {
       public static int chitvalue, numberofmonths, auctionvalue, installment, commissionamount, numberofmembers, monthlysubscription, commissionpercent, divident, bidamount;

        public BasicPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConvertToInt();
            monthlysubscription = MonthlySubscription();
            Bid();
            Installment();
            Commission();
            testme.Text = "Chit value:" + chitvalue + "  No. of months:" + numberofmonths + "  Monthly Subscription:" + monthlysubscription + "  Auction amount:" + auctionvalue + "  Commission:" + divident + " Amount to pay: " + installment + " Bid Amount" + bidamount + ":)";
                   
        }

        private void ConvertToInt()
        {
            try
            {
                // chitvalue = int.Parse(ChitValue.Text);
                chitvalue = Convert.ToInt32(ChitValue.Text);
                numberofmonths = Convert.ToInt32(NumberOfMonths.Text);
                auctionvalue = Convert.ToInt32(AuctionAmount.Text);
                numberofmembers = Convert.ToInt32(NumberOfMembers.Text);
            }
            catch(Exception e)
            { }
        }

        private int MonthlySubscription()
        {  int subscription = 0;
            try
            {
                subscription = chitvalue / numberofmonths;
            }
            catch(DivideByZeroException e)
            { }
            return subscription;
        }

        private int Bid()
        {
            bidamount = (chitvalue - auctionvalue);
            return bidamount;
        }

        private int Installment()
        {
            try
            {
                commissionamount = (int)Commission();
                int remainingamount = auctionvalue - commissionamount;
                divident = remainingamount / numberofmembers;
                installment = (monthlysubscription - divident);
            }
            catch(Exception e)
            { }
                return installment;
                     
        }

        private double Commission()
        {
            double commission = 0.04 * (double)chitvalue;
            return commission;
        }
    }

}
