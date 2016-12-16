using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace SharkOperativo
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            cargarGrupos();
            cargarProductos();
        }

        

        private void cargarProductos() {
            for (int i = 0; i <5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Image groupImage = new Image();
                    groupImage.Name = "imageGrupo_POLLOS" + i;
                    groupImage.Source = new BitmapImage(new Uri("ms-appx:/Assets/AA.jpg"));
                    groupImage.Margin = new Thickness(2, 2, 2, 2);
                    groupImage.Stretch = Stretch.UniformToFill;

                    StackPanel panel = new StackPanel();
                    panel.Background = new SolidColorBrush(Colors.Black);
                    panel.Opacity = 0.7;
                    panel.VerticalAlignment = VerticalAlignment.Bottom;
                    panel.Margin = new Thickness(2, 2, 2, 2);

                    TextBlock groupName = new TextBlock();
                    groupName.Text = "Producto " + j;
                    groupName.HorizontalAlignment = HorizontalAlignment.Center;
                    groupName.Foreground = new SolidColorBrush(Colors.White);

                    panel.Children.Add(groupName);


                    gridProductos.Children.Add(groupImage);
                    gridProductos.Children.Add(panel);
                    Grid.SetRow(groupImage, j);
                    Grid.SetColumn(groupImage, i);
                    Grid.SetRow(panel, j);
                    Grid.SetColumn(panel, i);
                }

            }
        }

        private void cargarGrupos()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Image groupImage = new Image();
                    groupImage.Name = "imageGrupo_POLLOS" + i;
                    groupImage.Source = new BitmapImage(new Uri("ms-appx:/Assets/tupadre.jpg"));
                    groupImage.Margin = new Thickness(2, 2, 2, 2);
                    groupImage.Stretch = Stretch.Fill;


                    StackPanel panel = new StackPanel();
                    panel.Background = new SolidColorBrush(Colors.Black);
                    panel.Opacity = 0.7;
                    panel.VerticalAlignment = VerticalAlignment.Bottom;
                    panel.Margin = new Thickness(2, 2, 2, 2);

                    TextBlock groupName = new TextBlock();
                    groupName.Text = "Grupo " + j;
                    groupName.HorizontalAlignment = HorizontalAlignment.Center;
                    groupName.Foreground = new SolidColorBrush(Colors.White);

                    panel.Children.Add(groupName);


                    gridGrupos.Children.Add(groupImage);
                    gridGrupos.Children.Add(panel);
                    Grid.SetRow(groupImage, j);
                    Grid.SetColumn(groupImage, i);
                    Grid.SetRow(panel, j);
                    Grid.SetColumn(panel, i);
                }

            }

        }
    }
}
