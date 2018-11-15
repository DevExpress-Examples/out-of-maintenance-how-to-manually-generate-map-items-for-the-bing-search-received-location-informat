<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/MapControl_ManualSearch/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/MapControl_ManualSearch/MainWindow.xaml.vb))**
* [MainWindow.xaml.cs](./CS/MapControl_ManualSearch/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MapControl_ManualSearch/MainWindow.xaml.vb))
<!-- default file list end -->
# How to manually generate map items for the Bing Search received location information


This example demonstrates how to manually generate map items for the Bing Search received location information.


<h3>Description</h3>

To manually generate vector items handle the&nbsp;<a href="https://documentation.devexpress.com/#wpf/DevExpressXpfMapBingSearchDataProvider_SearchCompletedtopic">BingSearchDataProvider.SearchCompleted</a> event. Note that the&nbsp;<a href="https://documentation.devexpress.com/#wpf/DevExpressXpfMapInformationDataProviderBase_GenerateLayerItemstopic">BingSearchDataProvider.GenerateLayerItems</a> property value should be <strong>false</strong>.

<br/>


