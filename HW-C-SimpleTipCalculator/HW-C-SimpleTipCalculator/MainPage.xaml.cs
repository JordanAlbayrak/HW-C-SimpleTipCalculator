using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW_C_SimpleTipCalculator
{
    public partial class MainPage : ContentPage
    {
        Label lblBill, lblTip, lblGuests, lblTotBill, lblTotTip, lblResultBill, lblResultTip;
        Image imgMaple;
        Entry entBill, entTip, entGuest;
        Button btnCalc, btnClear;
        public MainPage()
        {

            Grid grid = new Grid
            {
                Margin = new Thickness(10, 20),
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = new GridLength(1.0, GridUnitType.Star)},
                    new ColumnDefinition {Width = new GridLength(1.0, GridUnitType.Star)},
                },
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(0.5, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(0.5, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(0.5, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(0.5, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(0.5, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(0.5, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(50) },
                    
                },
            };

            lblBill = new Label { Text = "Bill:", FontSize=24, VerticalTextAlignment = TextAlignment.Center};
            lblTip = new Label { Text = "Tip:", FontSize = 24, VerticalTextAlignment = TextAlignment.Center };
            lblGuests = new Label { Text = "Guest(s):", FontSize = 24, VerticalTextAlignment = TextAlignment.Center };
            lblTotBill = new Label { Text = "Total Bill:", FontSize = 24, VerticalTextAlignment = TextAlignment.Center };
            lblTotTip = new Label { Text = "Total Tip:", FontSize = 24, VerticalTextAlignment = TextAlignment.Center };
            lblResultBill = new Label { BackgroundColor = Color.LightGray, FontSize = 24, TextColor = Color.Black };
            lblResultTip = new Label { BackgroundColor = Color.LightGray, FontSize = 24, TextColor = Color.Black };
            imgMaple = new Image { Source = "maple.jpg", HorizontalOptions = LayoutOptions.CenterAndExpand};
            entBill = new Entry { Placeholder = "Enter Bill:", Keyboard = Keyboard.Numeric, FontSize = 24, TextColor = Color.Black };
            entTip = new Entry { Placeholder = "Enter Tip:", Keyboard = Keyboard.Numeric, FontSize = 24, TextColor = Color.Black };
            entGuest = new Entry { Placeholder = "Enter Guest(s):", Keyboard = Keyboard.Numeric, FontSize = 24, TextColor = Color.Black };

            btnCalc = new Button { Text = "Calculate Bill" };
            btnCalc.Clicked += btnCalc_Clicked;
            btnClear = new Button { Text = "Clear" };
            btnClear.Clicked += btnClear_Clicked;

            grid.Children.Add(imgMaple,0,0);
            grid.Children.Add(lblBill, 0, 1);
            grid.Children.Add(lblTip, 0, 2);
            grid.Children.Add(lblGuests, 0, 3);
            grid.Children.Add(lblTotBill, 0, 4);
            grid.Children.Add(lblTotTip, 0, 5);
            grid.Children.Add(btnCalc, 0, 6);
            grid.Children.Add(entBill, 1, 1);
            grid.Children.Add(entTip, 1, 2);
            grid.Children.Add(entGuest, 1, 3);
            grid.Children.Add(lblResultBill, 1, 4);
            grid.Children.Add(lblResultTip, 1, 5);
            grid.Children.Add(btnClear, 1, 6);

            Content = grid;

            InitializeComponent();
        }

            private void btnCalc_Clicked(object sender, System.EventArgs e)
        {
            double totalBill, totalTip;

                totalTip = double.Parse(entGuest.Text) * double.Parse(entTip.Text);
                lblResultTip.Text = totalTip.ToString();

                totalBill = double.Parse(entBill.Text) + totalTip;
               lblResultBill.Text = totalBill.ToString();

            }

            private void btnClear_Clicked(object sender, System.EventArgs e)
            {
                lblResultBill.Text = "";
                lblResultTip.Text = "";
                entGuest.Text = "";
                entBill.Text = "";
                entTip.Text = "";

            }
        }
    }
