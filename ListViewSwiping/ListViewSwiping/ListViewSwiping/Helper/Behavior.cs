using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Swiping
{
   public class Behavior : Behavior<SfListView>
    {
        SfListView ListView;
        int itemIndex = -1;

        protected override void OnAttachedTo(SfListView bindable)
        {
            ListView = bindable;
            ListView.SwipeEnded += ListView_SwipeEnded;
            ListView.SwipeStarted += ListView_SwipeStarted;
            ListView.Swiping += ListView_Swiping;

            base.OnAttachedTo(bindable);
        }
        protected override void OnDetachingFrom(SfListView bindable)
        {

            base.OnDetachingFrom(bindable);
        }

        private void ListView_SwipeStarted(object sender, SwipeStartedEventArgs e)
        {
            itemIndex = -1;
        }

        private void ListView_Swiping(object sender, SwipingEventArgs e)
        {
            if (e.ItemIndex == 1 && e.SwipeOffSet > 70)
                e.Handled = true;
        }

        private void ListView_SwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            itemIndex = e.ItemIndex;
        }

    }
}
