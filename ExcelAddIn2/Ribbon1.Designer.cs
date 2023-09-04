namespace ExcelAddIn2
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl9 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnTable = this.Factory.CreateRibbonButton();
            this.btnImg = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.btnZoom = this.Factory.CreateRibbonButton();
            this.listZoom = this.Factory.CreateRibbonDropDown();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "OhuchiTool";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnImg);
            this.group1.Items.Add(this.btnTable);
            this.group1.Label = "マークダウン";
            this.group1.Name = "group1";
            // 
            // btnTable
            // 
            this.btnTable.Image = ((System.Drawing.Image)(resources.GetObject("btnTable.Image")));
            this.btnTable.Label = "表";
            this.btnTable.Name = "btnTable";
            this.btnTable.ShowImage = true;
            this.btnTable.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnTable_Click);
            // 
            // btnImg
            // 
            this.btnImg.Image = ((System.Drawing.Image)(resources.GetObject("btnImg.Image")));
            this.btnImg.Label = "imgタグ";
            this.btnImg.Name = "btnImg";
            this.btnImg.ShowImage = true;
            this.btnImg.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnImg_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.listZoom);
            this.group2.Items.Add(this.btnZoom);
            this.group2.Label = "Zoom";
            this.group2.Name = "group2";
            // 
            // btnZoom
            // 
            this.btnZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom.Image")));
            this.btnZoom.Label = "倍率変更";
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.ShowImage = true;
            this.btnZoom.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnZoom_Click);
            // 
            // listZoom
            // 
            this.listZoom.Image = ((System.Drawing.Image)(resources.GetObject("listZoom.Image")));
            ribbonDropDownItemImpl1.Label = "150%";
            ribbonDropDownItemImpl2.Label = "140%";
            ribbonDropDownItemImpl3.Label = "130%";
            ribbonDropDownItemImpl4.Label = "120%";
            ribbonDropDownItemImpl5.Label = "110%";
            ribbonDropDownItemImpl6.Label = "100%";
            ribbonDropDownItemImpl7.Label = "90%";
            ribbonDropDownItemImpl8.Label = "80%";
            ribbonDropDownItemImpl9.Label = "70%";
            this.listZoom.Items.Add(ribbonDropDownItemImpl1);
            this.listZoom.Items.Add(ribbonDropDownItemImpl2);
            this.listZoom.Items.Add(ribbonDropDownItemImpl3);
            this.listZoom.Items.Add(ribbonDropDownItemImpl4);
            this.listZoom.Items.Add(ribbonDropDownItemImpl5);
            this.listZoom.Items.Add(ribbonDropDownItemImpl6);
            this.listZoom.Items.Add(ribbonDropDownItemImpl7);
            this.listZoom.Items.Add(ribbonDropDownItemImpl8);
            this.listZoom.Items.Add(ribbonDropDownItemImpl9);
            this.listZoom.Label = "倍率";
            this.listZoom.Name = "listZoom";
            this.listZoom.ShowImage = true;
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnImg;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTable;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown listZoom;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnZoom;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
