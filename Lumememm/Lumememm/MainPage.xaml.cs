using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lumememm
{
    public partial class MainPage : ContentPage
    {
        BoxView[,] boxs = new BoxView [5,5 ];
        int i, j;
        public MainPage()
        {


            //Grid grid = new Grid
            //{
            //    RowDefinitions =
            //{
            //    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
            //    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
            //    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
            //},
            //    ColumnDefinitions =
            //{
            //    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
            //    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
            //    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
            //}
            //};
            //grid.Children.Add(new BoxView { Color = Color.Red }, 0, 0);
            //grid.Children.Add(new BoxView { Color = Color.Blue }, 0, 1);
            //grid.Children.Add(new BoxView { Color = Color.Fuchsia }, 0, 2);

            //grid.Children.Add(new BoxView { Color = Color.Teal }, 1, 0);
            //grid.Children.Add(new BoxView { Color = Color.Green }, 1, 1);
            //grid.Children.Add(new BoxView { Color = Color.Maroon }, 1, 2);

            //grid.Children.Add(new BoxView { Color = Color.Olive }, 2, 0);
            //grid.Children.Add(new BoxView { Color = Color.Pink }, 2, 1);
            //grid.Children.Add(new BoxView { Color = Color.Yellow }, 2, 2);

            //Content = grid;

            Grid grid = new Grid();

            for (int i = 0; i < 5; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star}),
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    //box = new BoxView { Color = Color.FromRgb(200, 100, 50) };
                    Image img = new Image { Source =ImageSource.FromFile( "nolik.PNG" )};
                    grid.Children.Add(box, i, j);
                    var tap = new TapGestureRecognizer();
                    //tap.Tapped += Tap_Tapped;
                    //box.GestureRecognizer.Add(tap);
                    //boxs[i, j].GestureRecognizers.Add(tap);
                    img.GestureRecognizers.Add(tap);
                    tap.Tapped += async (object sender, EventArgs e) =>
                    {
                        BoxView box = sender as BoxView;
                        if (box.Color == new Color(0, 0, 0))
                        {
                            box.Color = Color.FromRgb(200, 100, 50);
                        }
                        else
                        {
                            box.Color = new Color(0, 0, 0);
                        }
                    };

                }
            }
            Content = Grid;
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            BoxView box = sender as BoxView;
            box.Color = Color.FromRgb(0, 0, 0);
        }
     
    }
}
