namespace DemoApp
{
    partial class RibbonModuleSplitPanelTemplate
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
			this.graphController = new GraphController();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain.Panel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain.Panel2)).BeginInit();
			this.splitContainerMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tempRibbonControl)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainerMain
			// 
			this.splitContainerMain.Location = new System.Drawing.Point(0, 150);
			this.splitContainerMain.Size = new System.Drawing.Size(841, 319);
			this.splitContainerMain.SplitterPosition = 465;
			// 
			// tempRibbonControl
			// 
			this.tempRibbonControl.ExpandCollapseItem.Id = 0;
			// 
			// 
			// 
			this.tempRibbonControl.SearchEditItem.AccessibleName = "Search Item";
			this.tempRibbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
			this.tempRibbonControl.SearchEditItem.EditWidth = 150;
			this.tempRibbonControl.SearchEditItem.Id = -5000;
			this.tempRibbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
			this.tempRibbonControl.Size = new System.Drawing.Size(841, 150);
			// 
			// graphController
			// 
			this.graphController.IsActive = true;
			// 
			// RibbonModuleSplitPanelTemplate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "RibbonModuleSplitPanelTemplate";
			this.Size = new System.Drawing.Size(841, 469);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain.Panel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain.Panel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
			this.splitContainerMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tempRibbonControl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		protected GraphController graphController;

		#endregion

		//protected GraphController graphController;
	}
}
