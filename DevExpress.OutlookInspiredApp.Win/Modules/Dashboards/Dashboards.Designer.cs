﻿namespace DevExpress.OutlookInspiredApp.Win.Modules
{
    partial class Dashboards
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboards));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonNewDashboard = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer();
=======
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.barButtonNew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonEdit = new DevExpress.XtraBars.BarButtonItem();
>>>>>>> 58d5963b05133ab1068392b2084d015cb969dfb8
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
<<<<<<< HEAD
            this.barButtonEdit,
            this.barButtonNewDashboard});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
=======
            this.barButtonNew,
            this.barButtonEdit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> 58d5963b05133ab1068392b2084d015cb969dfb8
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
<<<<<<< HEAD
            this.ribbonControl1.Size = new System.Drawing.Size(803, 142);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonEdit
            // 
            this.barButtonEdit.Caption = "Edit";
            this.barButtonEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonEdit.Glyph")));
            this.barButtonEdit.Id = 1;
            this.barButtonEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonEdit.LargeGlyph")));
            this.barButtonEdit.Name = "barButtonEdit";
            // 
            // barButtonNewDashboard
            // 
            this.barButtonNewDashboard.Caption = "New";
            this.barButtonNewDashboard.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonNewDashboard.Glyph")));
            this.barButtonNewDashboard.Id = 2;
            this.barButtonNewDashboard.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonNewDashboard.LargeGlyph")));
            this.barButtonNewDashboard.Name = "barButtonNewDashboard";
            // 
=======
            this.ribbonControl1.Size = new System.Drawing.Size(1204, 169);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
>>>>>>> 58d5963b05133ab1068392b2084d015cb969dfb8
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
<<<<<<< HEAD
=======
            this.ribbonPage1.MergeOrder = 1;
>>>>>>> 58d5963b05133ab1068392b2084d015cb969dfb8
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HOME";
            // 
            // ribbonPageGroup1
            // 
<<<<<<< HEAD
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonNewDashboard);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonEdit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Dashboards";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 563);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(803, 27);
=======
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonEdit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Dashboard Stuffs";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 831);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1204, 31);
>>>>>>> 58d5963b05133ab1068392b2084d015cb969dfb8
            // 
            // dashboardViewer1
            // 
            this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.dashboardViewer1.Location = new System.Drawing.Point(0, 142);
=======
            this.dashboardViewer1.Location = new System.Drawing.Point(0, 169);
            this.dashboardViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> 58d5963b05133ab1068392b2084d015cb969dfb8
            this.dashboardViewer1.Name = "dashboardViewer1";
            this.dashboardViewer1.PrintingOptions.DocumentContentOptions.FilterState = DevExpress.DashboardWin.DashboardPrintingFilterState.None;
            this.dashboardViewer1.PrintingOptions.FontInfo.GdiCharSet = ((byte)(0));
            this.dashboardViewer1.PrintingOptions.FontInfo.Name = null;
<<<<<<< HEAD
            this.dashboardViewer1.Size = new System.Drawing.Size(803, 421);
            this.dashboardViewer1.TabIndex = 5;
            // 
            // Dashboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
=======
            this.dashboardViewer1.Size = new System.Drawing.Size(1204, 662);
            this.dashboardViewer1.TabIndex = 2;
            // 
            // barButtonNew
            // 
            this.barButtonNew.Caption = "New";
            this.barButtonNew.Id = 1;
            this.barButtonNew.LargeGlyph = global::DevExpress.OutlookInspiredApp.Win.Properties.Resources.icon_new_opportunities_32;
            this.barButtonNew.Name = "barButtonNew";
            // 
            // barButtonEdit
            // 
            this.barButtonEdit.Caption = "Edit";
            this.barButtonEdit.Id = 2;
            this.barButtonEdit.LargeGlyph = global::DevExpress.OutlookInspiredApp.Win.Properties.Resources.icon_edit_32;
            this.barButtonEdit.Name = "barButtonEdit";
            // 
            // Dashboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
>>>>>>> 58d5963b05133ab1068392b2084d015cb969dfb8
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dashboardViewer1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
<<<<<<< HEAD
            this.Name = "Dashboards";
            this.Size = new System.Drawing.Size(803, 590);
=======
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboards";
            this.Size = new System.Drawing.Size(1204, 862);
>>>>>>> 58d5963b05133ab1068392b2084d015cb969dfb8
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
<<<<<<< HEAD
        private XtraBars.BarButtonItem barButtonEdit;
        private DashboardWin.DashboardViewer dashboardViewer1;
        private XtraBars.BarButtonItem barButtonNewDashboard;
=======
        private DashboardWin.DashboardViewer dashboardViewer1;
        private XtraBars.BarButtonItem barButtonNew;
        private XtraBars.BarButtonItem barButtonEdit;
>>>>>>> 58d5963b05133ab1068392b2084d015cb969dfb8
    }
}
