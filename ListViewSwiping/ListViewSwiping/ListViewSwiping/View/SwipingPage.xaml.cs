using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Swiping
{
    public partial class SwipingPage : ContentPage
    {
        #region Fields

        Image leftImage;
        Image rightImage;
        int itemIndex = -1;

        #endregion

        #region Constructor

        public SwipingPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private void SetFavorites()
        {
            if (itemIndex >= 0)
            {
                var item = viewModel.InboxInfo[itemIndex];
                item.IsFavorite = !item.IsFavorite;
            }
            this.listView.ResetSwipe();
        }

        private void Delete()
        {
            if (itemIndex >= 0)
                viewModel.InboxInfo.RemoveAt(itemIndex);
            this.listView.ResetSwipe();
        }

        #endregion

        #region CallBacks
        
        private void leftImage_BindingContextChanged(object sender, EventArgs e)
        {
            if (leftImage == null)
            {
                leftImage = sender as Image;
                (leftImage.Parent as View).GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(SetFavorites) });
                leftImage.Source = ImageSource.FromResource("ListViewSwiping.Images.Favorites.png");
            }
        }

        private void rightImage_BindingContextChanged(object sender, EventArgs e)
        {
            if (rightImage == null)
            {
                rightImage = sender as Image;
                (rightImage.Parent as View).GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(Delete) });
                rightImage.Source = ImageSource.FromResource("ListViewSwiping.Images.Delete.png");
            }
        }

        private void ListView_SwipeStarted(object sender, Syncfusion.ListView.XForms.SwipeStartedEventArgs e)
        {
            itemIndex = -1;
        }

        private void ListView_Swiping(object sender, SwipingEventArgs e)
        {
            if (e.ItemIndex == 1 && e.SwipeOffSet > 70)
                e.Handled = true;
        }

        private void ListView_SwipeEnded(object sender, Syncfusion.ListView.XForms.SwipeEndedEventArgs e)
        {
            itemIndex = e.ItemIndex;
        }
        #endregion

    }
}
