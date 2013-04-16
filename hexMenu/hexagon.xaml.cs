using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
//using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace hexMenu
{

    //an element of the hex menu, has children, image, etc
    public sealed partial class hexagon : UserControl
    {

        LinkedList<hexagon> children;
        int position; //denotes position of this in hex circle? 
        Boolean kidsarevisible = false; //should make use of children instance var to det if kidsarevisible instead, flags are dumb

        public hexagon()
        {
            this.InitializeComponent();
            children = new LinkedList<hexagon>();
        }

        public hexagon(string imagesource)
        {

            BitmapImage bmp = new BitmapImage();
            //bi3.BeginInit();
            bmp.UriSource = new Uri(imagesource, UriKind.Relative);
            //bi3.EndInit();

            //tileImage.ImageSource = bmp;
            
        }

        public void setImage(string imagesource){

        }


        public void addChild(hexagon child, int position)
        {
            children.AddLast(child);

        }

        public void showChildren()
        {
                foreach (hexagon child in children)
                    child.Visibility = Visibility.Visible;


        }

        public void hideChildren()
        {

                foreach (hexagon child in children)
                {
                    child.Visibility = Visibility.Collapsed;
                    child.hideChildren();
                }



        }

        public void setLabel(String newlabel)
        {
            label.Text=newlabel;
        }

        private void hub_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (children.Count == 0)//this is terminal
                hub.Stroke = new SolidColorBrush(Colors.Blue);
            else
            {

                if (kidsarevisible)
                {
                    hideChildren();
                    kidsarevisible = false;
                }
                else
                {
                    showChildren();
                    kidsarevisible = true;
                }

            }


        }

    }
}
