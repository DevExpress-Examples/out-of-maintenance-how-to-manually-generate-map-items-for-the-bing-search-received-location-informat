using System.Windows;
using DevExpress.Xpf.Map;

namespace MapControl_ManualSearch {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        #region #ManualItemGenerationEventHandler
        private void BingSearchDataProvider_SearchCompleted(object sender, BingSearchCompletedEventArgs e) {
            if (e.Cancelled) return;
            if (e.RequestResult.ResultCode != RequestResultCode.Success) return;

            storage.Items.Clear();
            if (e.RequestResult.SearchResults.Count != 0)
                foreach (LocationInformation locationInformation in e.RequestResult.SearchResults)
                    AddMapItem(locationInformation);
            else
                AddMapItem(e.RequestResult.SearchRegion);
        }

        void AddMapItem(LocationInformation locationInformation) {
            storage.Items.Add(new MapDot() { Location = locationInformation.Location, 
                ToolTipPattern = locationInformation.DisplayName, 
                Size = 20
            }); 
        }
        #endregion #ManualItemGenerationEventHandler
    }
}
