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
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace GaleriaWPF
{
    /// <summary>
    /// Logika interakcji dla klasy Photos.xaml
    /// </summary>
    public partial class Photos : Window
    {
        private Gallery List = new Gallery();
        private int j = 0;
        public List<Photo> photos = new List<Photo>();

        public Photos(Gallery list)
        {
            InitializeComponent();
            this.List = list;
                      
            foreach (var photo in List.Photos)
            {
                photos.Add(new Photo() { Name = photo.Name, Description = photo.Description, Url = photo.Url });
            }

            name.Content = photos[j].Name;
            desc.Text = photos[j].Description;
            img.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(photos[j].Url);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (j == 0)
            {
                j = photos.Count;
            }

            if (j > 0)
            {
                j--;
                name.Content = photos[j].Name;
                desc.Text = photos[j].Description;
                img.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(photos[j].Url);
                pageCount.Content = j + 1;
            }
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (j == photos.Count - 1)
            {
                j = 0;
                name.Content = photos[j].Name;
                desc.Text = photos[j].Description;
                img.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(photos[j].Url);
                pageCount.Content = j+1;
            }
            else if (j < photos.Count)
            {
                j++;
                name.Content = photos[j].Name;
                desc.Text = photos[j].Description;
                img.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(photos[j].Url);
                pageCount.Content = j+1;
            }
        }
    }
}
