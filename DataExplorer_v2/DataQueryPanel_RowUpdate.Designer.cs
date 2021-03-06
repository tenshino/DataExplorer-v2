namespace DataExplorer
{
    partial class DataQueryPanel
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
            this.components = new System.ComponentModel.Container();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            this.panConn = new System.Windows.Forms.Panel();
            this.cmdNewConnStr = new RainstormStudios.Controls.AdvancedButton();
            this.txtConnStr = new System.Windows.Forms.TextBox();
            this.lblProvider = new System.Windows.Forms.Label();
            this.lblCurrentConn = new System.Windows.Forms.Label();
            this.drpProviderType = new System.Windows.Forms.ComboBox();
            this.splQuery = new System.Windows.Forms.SplitContainer();
            this.txtQuery = new RainstormStudios.Controls.QueryTextBox();
            this.ndgvInit = new RainstormStudios.Controls.NumberedDataGridView();
            this.mnuDg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuDgCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDgSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDgSum = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDgAutoStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutoStyleAlt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutoStyleByVal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDgBgStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDgClearStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDgSaveData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDgPgSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDgPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelGeneral = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelRows = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panConn.SuspendLayout();
            this.splQuery.Panel1.SuspendLayout();
            this.splQuery.Panel2.SuspendLayout();
            this.splQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndgvInit)).BeginInit();
            this.mnuDg.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panConn
            // 
            this.panConn.Controls.Add(this.cmdNewConnStr);
            this.panConn.Controls.Add(this.txtConnStr);
            this.panConn.Controls.Add(this.lblProvider);
            this.panConn.Controls.Add(this.lblCurrentConn);
            this.panConn.Controls.Add(this.drpProviderType);
            this.panConn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panConn.Location = new System.Drawing.Point(0, 0);
            this.panConn.MaximumSize = new System.Drawing.Size(10000, 44);
            this.panConn.MinimumSize = new System.Drawing.Size(340, 44);
            this.panConn.Name = "panConn";
            this.panConn.Size = new System.Drawing.Size(428, 44);
            this.panConn.TabIndex = 8;
            // 
            // cmdNewConnStr
            // 
            this.cmdNewConnStr.AllowWordWrap = false;
            this.cmdNewConnStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNewConnStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdNewConnStr.BackgroundRotationDegrees = 0F;
            this.cmdNewConnStr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdNewConnStr.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdNewConnStr.ButtonShape = graphicsPath1;
            this.cmdNewConnStr.CornerFeather = 3;
            this.cmdNewConnStr.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdNewConnStr.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdNewConnStr.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.Standard;
            this.cmdNewConnStr.HighlightMultiplier = 2F;
            this.cmdNewConnStr.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdNewConnStr.HoverHighlightOpacity = 200;
            this.cmdNewConnStr.HoverImage = null;
            this.cmdNewConnStr.ImagePadding = 0;
            this.cmdNewConnStr.Location = new System.Drawing.Point(367, 4);
            this.cmdNewConnStr.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdNewConnStr.MouseDownImage = null;
            this.cmdNewConnStr.MultiSample = true;
            this.cmdNewConnStr.Name = "cmdNewConnStr";
            this.cmdNewConnStr.Size = new System.Drawing.Size(54, 36);
            this.cmdNewConnStr.TabIndex = 8;
            this.cmdNewConnStr.Text = "String\r\nBuilder";
            this.cmdNewConnStr.TextOutline = false;
            this.cmdNewConnStr.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdNewConnStr.TextOutlineOpacity = 255;
            this.cmdNewConnStr.TextOutlineWeight = 2F;
            this.cmdNewConnStr.TextRotationDegrees = 0F;
            this.cmdNewConnStr.TextShadow = false;
            this.cmdNewConnStr.TextShadowOffset = 1F;
            this.cmdNewConnStr.TextShadowOpacity = 80;
            this.cmdNewConnStr.TextVeritcal = false;
            this.cmdNewConnStr.ThreeDEffectDepth = 50;
            this.cmdNewConnStr.UseVisualStyleBackColor = true;
            // 
            // txtConnStr
            // 
            this.txtConnStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnStr.Location = new System.Drawing.Point(7, 20);
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(224, 20);
            this.txtConnStr.TabIndex = 7;
            // 
            // lblProvider
            // 
            this.lblProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProvider.AutoSize = true;
            this.lblProvider.Location = new System.Drawing.Point(234, 4);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(77, 13);
            this.lblProvider.TabIndex = 6;
            this.lblProvider.Text = ".NET Provider:";
            // 
            // lblCurrentConn
            // 
            this.lblCurrentConn.AutoSize = true;
            this.lblCurrentConn.Location = new System.Drawing.Point(4, 4);
            this.lblCurrentConn.Name = "lblCurrentConn";
            this.lblCurrentConn.Size = new System.Drawing.Size(101, 13);
            this.lblCurrentConn.TabIndex = 5;
            this.lblCurrentConn.Text = "Current Connection:";
            // 
            // drpProviderType
            // 
            this.drpProviderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drpProviderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpProviderType.FormattingEnabled = true;
            this.drpProviderType.Items.AddRange(new object[] {
            "SQL Provider",
            "OLE DB Provider",
            "IBM DB2 Provider",
            "ODBC Provider"});
            this.drpProviderType.Location = new System.Drawing.Point(237, 20);
            this.drpProviderType.Name = "drpProviderType";
            this.drpProviderType.Size = new System.Drawing.Size(124, 21);
            this.drpProviderType.TabIndex = 4;
            // 
            // splQuery
            // 
            this.splQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splQuery.Location = new System.Drawing.Point(0, 46);
            this.splQuery.Name = "splQuery";
            this.splQuery.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splQuery.Panel1
            // 
            this.splQuery.Panel1.Controls.Add(this.txtQuery);
            // 
            // splQuery.Panel2
            // 
            this.splQuery.Panel2.Controls.Add(this.ndgvInit);
            this.splQuery.Panel2Collapsed = true;
            this.splQuery.Size = new System.Drawing.Size(428, 388);
            this.splQuery.SplitterDistance = 200;
            this.splQuery.TabIndex = 9;
            // 
            // txtQuery
            // 
            this.txtQuery.AcceptsTab = true;
            this.txtQuery.AliasColor = System.Drawing.Color.Navy;
            this.txtQuery.AllowDrop = true;
            this.txtQuery.CommentColor = System.Drawing.Color.Green;
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuery.EnableAutoDragDrop = true;
            this.txtQuery.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.FunctionColor = System.Drawing.Color.DarkViolet;
            this.txtQuery.GlobalVariableColor = System.Drawing.Color.DarkViolet;
            this.txtQuery.HorizontalScrollPos = 0;
            this.txtQuery.KeywordColor = System.Drawing.Color.Blue;
            this.txtQuery.Location = new System.Drawing.Point(0, 0);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtQuery.Size = new System.Drawing.Size(428, 388);
            this.txtQuery.StringLiteralColor = System.Drawing.Color.Red;
            this.txtQuery.TabIndex = 0;
            this.txtQuery.Text = "";
            this.txtQuery.UseDefaultContextMenu = false;
            this.txtQuery.VerticalScrollPos = 0;
            this.txtQuery.WordWrap = false;
            this.txtQuery.SelectionChanged += new System.EventHandler(this.txtQuery_SelectionChanged);
            // 
            // ndgvInit
            // 
            this.ndgvInit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ndgvInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ndgvInit.Location = new System.Drawing.Point(0, 0);
            this.ndgvInit.Name = "ndgvInit";
            this.ndgvInit.Size = new System.Drawing.Size(428, 184);
            this.ndgvInit.TabIndex = 0;
            this.ndgvInit.ZeroBased = false;
            // 
            // mnuDg
            // 
            this.mnuDg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDgCopy,
            this.mnuDgSelectAll,
            this.toolStripMenuItem1,
            this.mnuDgSum,
            this.toolStripMenuItem2,
            this.mnuDgAutoStyle,
            this.mnuDgBgStyle,
            this.mnuDgClearStyle,
            this.toolStripMenuItem3,
            this.mnuDgSaveData,
            this.toolStripMenuItem4,
            this.mnuDgPgSetup,
            this.mnuDgPrint});
            this.mnuDg.Name = "mnuDg";
            this.mnuDg.Size = new System.Drawing.Size(169, 226);
            this.mnuDg.Opening += new System.ComponentModel.CancelEventHandler(this.mnuDg_Opening);
            // 
            // mnuDgCopy
            // 
            this.mnuDgCopy.Name = "mnuDgCopy";
            this.mnuDgCopy.Size = new System.Drawing.Size(168, 22);
            this.mnuDgCopy.Text = "Copy";
            this.mnuDgCopy.Click += new System.EventHandler(this.mnuDg_onClick);
            // 
            // mnuDgSelectAll
            // 
            this.mnuDgSelectAll.Name = "mnuDgSelectAll";
            this.mnuDgSelectAll.Size = new System.Drawing.Size(168, 22);
            this.mnuDgSelectAll.Text = "Select All";
            this.mnuDgSelectAll.Click += new System.EventHandler(this.mnuDg_onClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuDgSum
            // 
            this.mnuDgSum.Name = "mnuDgSum";
            this.mnuDgSum.Size = new System.Drawing.Size(168, 22);
            this.mnuDgSum.Text = "Sum of Selected";
            this.mnuDgSum.Click += new System.EventHandler(this.mnuDg_onClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuDgAutoStyle
            // 
            this.mnuDgAutoStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAutoStyleAlt,
            this.mnuAutoStyleByVal});
            this.mnuDgAutoStyle.Name = "mnuDgAutoStyle";
            this.mnuDgAutoStyle.Size = new System.Drawing.Size(168, 22);
            this.mnuDgAutoStyle.Text = "Auto Style";
            // 
            // mnuAutoStyleAlt
            // 
            this.mnuAutoStyleAlt.Name = "mnuAutoStyleAlt";
            this.mnuAutoStyleAlt.Size = new System.Drawing.Size(138, 22);
            this.mnuAutoStyleAlt.Text = "Alternating";
            // 
            // mnuAutoStyleByVal
            // 
            this.mnuAutoStyleByVal.Name = "mnuAutoStyleByVal";
            this.mnuAutoStyleByVal.Size = new System.Drawing.Size(138, 22);
            this.mnuAutoStyleByVal.Text = "By Value";
            // 
            // mnuDgBgStyle
            // 
            this.mnuDgBgStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.purpleToolStripMenuItem});
            this.mnuDgBgStyle.Name = "mnuDgBgStyle";
            this.mnuDgBgStyle.Size = new System.Drawing.Size(168, 22);
            this.mnuDgBgStyle.Text = "Background Style";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.redToolStripMenuItem.Text = "Red";
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.orangeToolStripMenuItem.Text = "Orange";
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.purpleToolStripMenuItem.Text = "Purple";
            // 
            // mnuDgClearStyle
            // 
            this.mnuDgClearStyle.Name = "mnuDgClearStyle";
            this.mnuDgClearStyle.Size = new System.Drawing.Size(168, 22);
            this.mnuDgClearStyle.Text = "Clear Style";
            this.mnuDgClearStyle.Click += new System.EventHandler(this.mnuDg_onClick);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuDgSaveData
            // 
            this.mnuDgSaveData.Name = "mnuDgSaveData";
            this.mnuDgSaveData.Size = new System.Drawing.Size(168, 22);
            this.mnuDgSaveData.Text = "Save Data As...";
            this.mnuDgSaveData.Click += new System.EventHandler(this.mnuDg_onClick);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuDgPgSetup
            // 
            this.mnuDgPgSetup.Name = "mnuDgPgSetup";
            this.mnuDgPgSetup.Size = new System.Drawing.Size(168, 22);
            this.mnuDgPgSetup.Text = "Page Setup";
            this.mnuDgPgSetup.Click += new System.EventHandler(this.mnuDg_onClick);
            // 
            // mnuDgPrint
            // 
            this.mnuDgPrint.Name = "mnuDgPrint";
            this.mnuDgPrint.Size = new System.Drawing.Size(168, 22);
            this.mnuDgPrint.Text = "Print";
            this.mnuDgPrint.Click += new System.EventHandler(this.mnuDg_onClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelGeneral,
            this.statusLabelRows,
            this.statusLabelTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(428, 24);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelGeneral
            // 
            this.statusLabelGeneral.AutoSize = false;
            this.statusLabelGeneral.Name = "statusLabelGeneral";
            this.statusLabelGeneral.Size = new System.Drawing.Size(248, 19);
            this.statusLabelGeneral.Spring = true;
            this.statusLabelGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabelRows
            // 
            this.statusLabelRows.AutoSize = false;
            this.statusLabelRows.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusLabelRows.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusLabelRows.Name = "statusLabelRows";
            this.statusLabelRows.Size = new System.Drawing.Size(90, 19);
            this.statusLabelRows.Text = "0 Rows";
            this.statusLabelRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusLabelTime
            // 
            this.statusLabelTime.AutoSize = false;
            this.statusLabelTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusLabelTime.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusLabelTime.Name = "statusLabelTime";
            this.statusLabelTime.Size = new System.Drawing.Size(75, 19);
            this.statusLabelTime.Text = "00:00:00";
            this.statusLabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DataQueryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splQuery);
            this.Controls.Add(this.panConn);
            this.Name = "DataQueryPanel";
            this.Size = new System.Drawing.Size(428, 459);
            this.panConn.ResumeLayout(false);
            this.panConn.PerformLayout();
            this.splQuery.Panel1.ResumeLayout(false);
            this.splQuery.Panel2.ResumeLayout(false);
            this.splQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ndgvInit)).EndInit();
            this.mnuDg.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panConn;
        private RainstormStudios.Controls.AdvancedButton cmdNewConnStr;
        private System.Windows.Forms.TextBox txtConnStr;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Label lblCurrentConn;
        private System.Windows.Forms.ComboBox drpProviderType;
        private System.Windows.Forms.SplitContainer splQuery;
        private RainstormStudios.Controls.QueryTextBox txtQuery;
        private RainstormStudios.Controls.NumberedDataGridView ndgvInit;
        private System.Windows.Forms.ContextMenuStrip mnuDg;
        private System.Windows.Forms.ToolStripMenuItem mnuDgCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuDgSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuDgSum;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuDgAutoStyle;
        private System.Windows.Forms.ToolStripMenuItem mnuAutoStyleAlt;
        private System.Windows.Forms.ToolStripMenuItem mnuAutoStyleByVal;
        private System.Windows.Forms.ToolStripMenuItem mnuDgBgStyle;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDgClearStyle;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuDgSaveData;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuDgPgSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuDgPrint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelGeneral;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelRows;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelTime;
    }
}
