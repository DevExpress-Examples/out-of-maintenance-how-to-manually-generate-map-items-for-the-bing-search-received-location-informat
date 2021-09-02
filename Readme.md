<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571674/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T189452)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/MapControl_ManualSearch/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MapControl_ManualSearch/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/MapControl_ManualSearch/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MapControl_ManualSearch/MainWindow.xaml.vb))
<!-- default file list end -->
# How to manually generate map items for the Bing Search received location information


This example demonstrates how to manually generate map items for the Bing Search received location information.


<h3>Description</h3>

To manually generate vector items handle the&nbsp;<a href="https://documentation.devexpress.com/#wpf/DevExpressXpfMapBingSearchDataProvider_SearchCompletedtopic">BingSearchDataProvider.SearchCompleted</a> event. Note that the&nbsp;<a href="https://documentation.devexpress.com/#wpf/DevExpressXpfMapInformationDataProviderBase_GenerateLayerItemstopic">BingSearchDataProvider.GenerateLayerItems</a> property value should be <strong>false</strong>.

<br/>


