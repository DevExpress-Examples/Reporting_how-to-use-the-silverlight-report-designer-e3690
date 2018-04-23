﻿using System.Windows.Controls;
using DevExpress.Xpf.Printing;

namespace SilverlightReportDesignerDemo {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void dXTabControl1_SelectionChanged(object sender, DevExpress.Xpf.Core.TabControlSelectionChangedEventArgs e) {
            if (e.NewSelectedItem == previewTab) {
                var reportPreviewModel = (ReportPreviewModel)documentPreview.Model;
                reportPreviewModel.ReportName = reportDesigner.SessionId;
                reportPreviewModel.CreateDocument();
            }
        }
    }
}
