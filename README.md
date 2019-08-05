# Assiginig left and right swipe templates in ListView

The User Interface (UI) for swiping can be customized by using swipe templates [SfListView.LeftSwipeTemplate](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~LeftSwipeTemplate.html) when swiping towards right and [SfListView.RightSwipeTemplate](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~RightSwipeTemplate.html) when swiping towards left. The contents inside the swipe template are arranged based on the offset values when swiping an item. You can reset the swiping item or swiped item by calling the [SfListView.ResetSwipe](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~ResetSwipe.html) method.

```
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
  <syncfusion:SfListView x:Name="listView" AllowSwiping="True">
    <syncfusion:SfListView.LeftSwipeTemplate>
      <DataTemplate x:Name="LeftSwipeTemplate">
        <Grid>
          <Grid BackgroundColor="#009EDA" HorizontalOptions="Fill" VerticalOptions="Fill" Grid.Column="0">
            <Grid VerticalOptions="Center" HorizontalOptions="Center">
              <Image Grid.Column="0"
                    Grid.Row="0"
                    BackgroundColor="Transparent"
                    HeightRequest="35"
                    WidthRequest="35"
                    Source="Favorites.png" />
            </Grid>
          </Grid>
        </Grid>
      </DataTemplate>
    </syncfusion:SfListView.LeftSwipeTemplate>
  </syncfusion:SfListView>
</ContentPage>
```
To know more about swiping in ListView , please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/swiping).