using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static System.Net.Mime.MediaTypeNames;

namespace GaleriaWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Gallery> accGall = new ObservableCollection<Gallery>();
        public ObservableCollection<Gallery> secList = new ObservableCollection<Gallery>();

        int category;
        int page = 0;

        InjectObjects Inject = new InjectObjects();

        public MainWindow()
        {
            InitializeComponent();

            Load(1);
        }

        private void ClearGallery()
        {
            //czyszczenie zdjęć i podpisów
            img1.Source = null;
            img1.DataContext = null;
            text1.Content = "";
            img2.Source = null;
            img2.DataContext = null;
            text2.Content = "";
            img3.Source = null;
            img3.DataContext = null;
            text3.Content = "";
            img4.Source = null;
            img4.DataContext = null;
            text4.Content = "";
        }

        //kategorie
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(((MenuItem)sender).DataContext);
            Load(id);
        }

        private void Load(int category)
        {
            page = 0;
            accGall.Clear();

            ClearGallery();

            this.category = category;
            secList = new ObservableCollection<Gallery>(Inject.galleries);

            //pętla przypisująca obiekty z listy do listy aktualnie wyświetlanych zdjęć
            for (int i = 0; i < secList.Count; i++)
            {
                if (secList[i].CatID == category)
                {
                    accGall.Add(secList[i]);

                    if (secList[i].SubCatID == 1)
                    {
                        img1.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(secList[i].SubCatUrl);
                        img1.DataContext = secList[i];
                        text1.Content = secList[i].SubCat;
                    }
                    if (secList[i].SubCatID == 2)
                    {
                        img2.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(secList[i].SubCatUrl);
                        img2.DataContext = secList[i];
                        text2.Content = secList[i].SubCat;
                    }
                    if (secList[i].SubCatID == 3)
                    {
                        img3.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(secList[i].SubCatUrl);
                        img3.DataContext = secList[i];
                        text3.Content = secList[i].SubCat;
                    }
                    if (secList[i].SubCatID == 4)
                    {
                        img4.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(secList[i].SubCatUrl);
                        img4.DataContext = secList[i];
                        text4.Content = secList[i].SubCat;
                    }

                    if (secList[i].SubCatID > 4)
                    {
                        next.Visibility = Visibility.Visible;
                        back.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        next.Visibility = Visibility.Hidden;
                        back.Visibility = Visibility.Hidden;
                    }
                }
            }
        }

        private void showPhotos(object sender)
        {
            var img = (System.Windows.Controls.Image)sender;
            var lista = (Gallery)img.DataContext;

            Photos photos = new Photos(lista);

            if (lista != null)
            {
                photos.ShowDialog();
            }
        }

        private void img1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            showPhotos(sender);
        }

        private void img2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            showPhotos(sender);
        }

        private void img3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            showPhotos(sender);
        }

        private void img4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            showPhotos(sender);
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            page++;

            ClearGallery();

            for (int i = 0; i < accGall.Count; i++)
            {
                if (accGall[i].SubCatID == (page * 4) + 1)
                {
                    img1.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(accGall[i].SubCatUrl);
                    img1.DataContext = accGall[i];
                    text1.Content = accGall[i].SubCat;
                }
                if (accGall[i].SubCatID == (page * 4) + 2)
                {
                    img2.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(accGall[i].SubCatUrl);
                    img2.DataContext = accGall[i];
                    text2.Content = accGall[i].SubCat;
                }
                if (accGall[i].SubCatID == (page * 4) + 3)
                {
                    img3.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(accGall[i].SubCatUrl);
                    img3.DataContext = accGall[i];
                    text3.Content = accGall[i].SubCat;
                }
                if (accGall[i].SubCatID == (page * 4) + 4)
                {
                    img4.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(accGall[i].SubCatUrl);
                    img4.DataContext = accGall[i];
                    text4.Content = accGall[i].SubCat;
                }

                //sprawdzanie czy przyciski powinny zostać wyświetlone
                if (accGall[i].SubCatID > (page * 4) + 4)
                {
                    next.Visibility = Visibility.Visible;
                    back.Visibility = Visibility.Visible;
                }
                else
                {
                    back.Visibility = Visibility.Visible;
                    next.Visibility = Visibility.Hidden;
                }
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            page--;

            ClearGallery();

            for (int i = 0; i < accGall.Count; i++)
            {
                if (accGall[i].SubCatID == (page * 4) + 1)
                {
                    img1.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(accGall[i].SubCatUrl);
                    img1.DataContext = accGall[i];
                    text1.Content = accGall[i].SubCat;
                }
                if (accGall[i].SubCatID == (page * 4) + 2)
                {
                    img2.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(accGall[i].SubCatUrl);
                    img2.DataContext = accGall[i];
                    text2.Content = accGall[i].SubCat;
                }
                if (accGall[i].SubCatID == (page * 4) + 3)
                {
                    img3.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(accGall[i].SubCatUrl);
                    img3.DataContext = accGall[i];
                    text3.Content = accGall[i].SubCat;
                }
                if (accGall[i].SubCatID == (page * 4) + 4)
                {
                    img4.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(accGall[i].SubCatUrl);
                    img4.DataContext = accGall[i];
                    text4.Content = accGall[i].SubCat;
                }
                
                if (page == 0 && accGall[i].SubCatID > (page * 4) + 4)
                {
                    back.Visibility = Visibility.Hidden;
                    next.Visibility = Visibility.Visible;
                }
                if (page > 0 && accGall[i].SubCatID > (page * 4) + 4)
                {
                    back.Visibility = Visibility.Visible;
                    next.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
