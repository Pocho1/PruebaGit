namespace Pocho01
{
    partial class Dashboard1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard1));
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.imageDashboardItem1 = new DevExpress.DashboardCommon.ImageDashboardItem();
            this.textBoxDashboardItem1 = new DevExpress.DashboardCommon.TextBoxDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // imageDashboardItem1
            // 
            this.imageDashboardItem1.ComponentName = "imageDashboardItem1";
            this.imageDashboardItem1.DataSerializable = resources.GetString("imageDashboardItem1.DataSerializable");
            this.imageDashboardItem1.Name = "Imagen 1";
            this.imageDashboardItem1.ShowCaption = true;
            // 
            // textBoxDashboardItem1
            // 
            this.textBoxDashboardItem1.ComponentName = "textBoxDashboardItem1";
            this.textBoxDashboardItem1.InnerRtf = resources.GetString("textBoxDashboardItem1.InnerRtf");
            this.textBoxDashboardItem1.Name = "Cuadro de Texto 1";
            this.textBoxDashboardItem1.ShowCaption = true;
            // 
            // Dashboard1
            // 
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.imageDashboardItem1,
            this.textBoxDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.textBoxDashboardItem1;
            dashboardLayoutItem1.Weight = 50D;
            dashboardLayoutItem2.DashboardItem = this.imageDashboardItem1;
            dashboardLayoutItem2.Weight = 50D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Tablero de control";
            ((System.ComponentModel.ISupportInitialize)(this.imageDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.ImageDashboardItem imageDashboardItem1;
        private DevExpress.DashboardCommon.TextBoxDashboardItem textBoxDashboardItem1;

    }
}
