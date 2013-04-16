using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace hexMenu
{


    //this is a menu, 
    public sealed partial class hex : UserControl
    {

        LinkedList<hexagon> children;
        int position; //denotes position of this in hex circle? 
        Boolean kidsarevisible = false;


        public hex()
        {
            this.InitializeComponent();
            children = new LinkedList<hexagon>();
            hub.setLabel("central");
            leaf1.setLabel("level1a");
            leaf2.setLabel("level1b");
            leaf3.setLabel("level1c");

            hub.addChild(leaf1,2);
            hub.addChild(leaf2,3);
            hub.addChild(leaf3,4);

            //leaf1kid.setImage("marmoset.bmp");
            leaf1kid.setLabel("terminal");

            leaf1.addChild(leaf1kid,2);
            leaf1.addChild(leaf1kid2, 3);

            leaf3.addChild(leaf3kid, 4);

            //leaf1.hideChildren();

            //children.AddLast(leaf1);
            //children.AddLast(leaf2);
            hub.hideChildren();

        }


    }
}
