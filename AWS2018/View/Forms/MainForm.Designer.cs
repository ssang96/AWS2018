namespace AWS2018
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.textDisplayItem = new DevExpress.XtraBars.BarButtonItem();
            this.widgetDisplayItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.textDisplayItem,
            this.widgetDisplayItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonHome,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1189, 150);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "그래프";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonHome
            // 
            this.ribbonHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonHome.Name = "ribbonHome";
            this.ribbonHome.Text = "HOME";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.ImageOptions.Image")));
            this.ribbonPageGroup1.ImageOptions.ImageUri.Uri = "Add";
            this.ribbonPageGroup1.ItemLinks.Add(this.textDisplayItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.widgetDisplayItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "GRAPH";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "REPORT";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ENVIRONMENT";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // textDisplayItem
            // 
            this.textDisplayItem.Caption = "Text Display";
            this.textDisplayItem.Id = 5;
            this.textDisplayItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.textDisplayItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.textDisplayItem.Name = "textDisplayItem";
            this.textDisplayItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.textDisplayItem_ItemClick);
            // 
            // widgetDisplayItem
            // 
            this.widgetDisplayItem.Caption = "Widget Display";
            this.widgetDisplayItem.Id = 6;
            this.widgetDisplayItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("widgetDisplayItem.ImageOptions.Image")));
            this.widgetDisplayItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("widgetDisplayItem.ImageOptions.LargeImage")));
            this.widgetDisplayItem.Name = "widgetDisplayItem";
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 667);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWS 2018";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem textDisplayItem;
        private DevExpress.XtraBars.BarButtonItem widgetDisplayItem;
    }
}

