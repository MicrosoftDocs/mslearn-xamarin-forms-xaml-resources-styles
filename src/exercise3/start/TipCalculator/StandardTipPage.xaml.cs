using System;
using Xamarin.Forms;

namespace TipCalculator
{
    public partial class StandardTipPage : ContentPage
    {
        public StandardTipPage()
        {
            InitializeComponent();
            billInput.TextChanged += (s, e) => CalculateTip();
        }

        void CalculateTip()
        {
            double bill;

            if (Double.TryParse(billInput.Text, out bill) && bill > 0)
            {
                double tip   = Math.Round(bill*0.15, 2);
                double final = bill + tip;

                tipOutput  .Text = tip  .ToString("C");
                totalOutput.Text = final.ToString("C");
            }
        }

        void OnLight(object sender, EventArgs e)
        {
            LayoutRoot.BackgroundColor = Color.Silver;

            tipLabel   .TextColor = Color.Navy;
            billLabel  .TextColor = Color.Navy;
            totalLabel .TextColor = Color.Navy;
            tipOutput  .TextColor = Color.Navy;
            totalOutput.TextColor = Color.Navy;
        }

        void OnDark(object sender, EventArgs e)
        {
            LayoutRoot.BackgroundColor = Color.Navy;

            tipLabel   .TextColor = Color.Silver;
            billLabel  .TextColor = Color.Silver;
            totalLabel .TextColor = Color.Silver;
            tipOutput  .TextColor = Color.Silver;
            totalOutput.TextColor = Color.Silver;
        }

        void GotoCustom(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomTipPage());
        }
    }
}

