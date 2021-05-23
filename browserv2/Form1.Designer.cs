namespace browserv2
{
    partial class Form1
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pageText = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.textboxURL = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnFavourites = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetHome = new System.Windows.Forms.Button();
            this.btnHomeEdit = new System.Windows.Forms.Button();
            this.textboxHome = new System.Windows.Forms.TextBox();
            this.btnAddFavourite = new System.Windows.Forms.Button();
            this.textboxFavourite = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuDrop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFavourites = new System.Windows.Forms.ToolStripMenuItem();
            this.browserdbDataSet = new browserv2.browserdbDataSet();
            this.homeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeTableAdapter = new browserv2.browserdbDataSetTableAdapters.homeTableAdapter();
            this.homeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browserdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1691, 1108);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.pageText, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 113);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 992F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 992F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 992F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1685, 992);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pageText
            // 
            this.pageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageText.Location = new System.Drawing.Point(3, 3);
            this.pageText.Name = "pageText";
            this.pageText.Size = new System.Drawing.Size(1679, 986);
            this.pageText.TabIndex = 0;
            this.pageText.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1685, 104);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnFwd, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnRefresh, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnHome, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.textboxURL, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnGo, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnFavourites, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnHistory, 7, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1679, 46);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFwd.Location = new System.Drawing.Point(86, 3);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(77, 40);
            this.btnFwd.TabIndex = 1;
            this.btnFwd.Text = ">";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(169, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 40);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Location = new System.Drawing.Point(252, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(77, 40);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // textboxURL
            // 
            this.textboxURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxURL.Location = new System.Drawing.Point(335, 3);
            this.textboxURL.Name = "textboxURL";
            this.textboxURL.Size = new System.Drawing.Size(1001, 35);
            this.textboxURL.TabIndex = 4;
            this.textboxURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxURL_KeyPress);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(1342, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(161, 40);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnFavourites
            // 
            this.btnFavourites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFavourites.Location = new System.Drawing.Point(1509, 3);
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Size = new System.Drawing.Size(77, 40);
            this.btnFavourites.TabIndex = 6;
            this.btnFavourites.Text = "Favourites";
            this.btnFavourites.UseVisualStyleBackColor = true;
            this.btnFavourites.Click += new System.EventHandler(this.btnFavourites_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHistory.Location = new System.Drawing.Point(1592, 3);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(84, 40);
            this.btnHistory.TabIndex = 7;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.Controls.Add(this.btnSetHome, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnHomeEdit, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.textboxHome, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAddFavourite, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.textboxFavourite, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.menuStrip, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1679, 46);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnSetHome
            // 
            this.btnSetHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetHome.Location = new System.Drawing.Point(3, 3);
            this.btnSetHome.Name = "btnSetHome";
            this.btnSetHome.Size = new System.Drawing.Size(245, 40);
            this.btnSetHome.TabIndex = 0;
            this.btnSetHome.Text = "Use this as Homepage";
            this.btnSetHome.UseVisualStyleBackColor = true;
            this.btnSetHome.Click += new System.EventHandler(this.btnSetHome_Click);
            // 
            // btnHomeEdit
            // 
            this.btnHomeEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHomeEdit.Location = new System.Drawing.Point(254, 3);
            this.btnHomeEdit.Name = "btnHomeEdit";
            this.btnHomeEdit.Size = new System.Drawing.Size(329, 40);
            this.btnHomeEdit.TabIndex = 1;
            this.btnHomeEdit.Text = "Edit Homepage URL:";
            this.btnHomeEdit.UseVisualStyleBackColor = true;
            this.btnHomeEdit.Click += new System.EventHandler(this.btnHomeEdit_Click);
            // 
            // textboxHome
            // 
            this.textboxHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxHome.Location = new System.Drawing.Point(589, 3);
            this.textboxHome.Name = "textboxHome";
            this.textboxHome.Size = new System.Drawing.Size(245, 35);
            this.textboxHome.TabIndex = 2;
            this.textboxHome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxHome_KeyPress);
            // 
            // btnAddFavourite
            // 
            this.btnAddFavourite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddFavourite.Location = new System.Drawing.Point(1091, 3);
            this.btnAddFavourite.Name = "btnAddFavourite";
            this.btnAddFavourite.Size = new System.Drawing.Size(329, 40);
            this.btnAddFavourite.TabIndex = 3;
            this.btnAddFavourite.Text = "Add to favourites:";
            this.btnAddFavourite.UseVisualStyleBackColor = true;
            this.btnAddFavourite.Click += new System.EventHandler(this.btnAddFavourite_Click);
            // 
            // textboxFavourite
            // 
            this.textboxFavourite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxFavourite.Location = new System.Drawing.Point(1426, 3);
            this.textboxFavourite.Name = "textboxFavourite";
            this.textboxFavourite.Size = new System.Drawing.Size(250, 35);
            this.textboxFavourite.TabIndex = 4;
            this.textboxFavourite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxFavourite_KeyPress);
            // 
            // menuStrip
            // 
            this.menuStrip.AllowDrop = true;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDrop});
            this.menuStrip.Location = new System.Drawing.Point(837, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(251, 46);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "Menu";
            // 
            // menuDrop
            // 
            this.menuDrop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHistory,
            this.menuFavourites});
            this.menuDrop.Name = "menuDrop";
            this.menuDrop.Size = new System.Drawing.Size(107, 38);
            this.menuDrop.Text = "Menu";
            // 
            // menuHistory
            // 
            this.menuHistory.Name = "menuHistory";
            this.menuHistory.Size = new System.Drawing.Size(287, 48);
            this.menuHistory.Text = "History";
            this.menuHistory.Click += new System.EventHandler(this.menuHistory_Click);
            // 
            // menuFavourites
            // 
            this.menuFavourites.Name = "menuFavourites";
            this.menuFavourites.Size = new System.Drawing.Size(287, 48);
            this.menuFavourites.Text = "Favourites";
            this.menuFavourites.Click += new System.EventHandler(this.menuFavourites_Click);
            // 
            // browserdbDataSet
            // 
            this.browserdbDataSet.DataSetName = "browserdbDataSet";
            this.browserdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // homeBindingSource
            // 
            this.homeBindingSource.DataMember = "home";
            this.homeBindingSource.DataSource = this.browserdbDataSet;
            // 
            // homeTableAdapter
            // 
            this.homeTableAdapter.ClearBeforeFill = true;
            // 
            // homeBindingSource1
            // 
            this.homeBindingSource1.DataMember = "home";
            this.homeBindingSource1.DataSource = this.browserdbDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 1108);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browserdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox pageText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox textboxURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnFavourites;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnSetHome;
        private System.Windows.Forms.Button btnHomeEdit;
        private System.Windows.Forms.TextBox textboxHome;
        private System.Windows.Forms.Button btnAddFavourite;
        private System.Windows.Forms.TextBox textboxFavourite;
        private browserdbDataSet browserdbDataSet;
        private System.Windows.Forms.BindingSource homeBindingSource;
        private browserdbDataSetTableAdapters.homeTableAdapter homeTableAdapter;
        private System.Windows.Forms.BindingSource homeBindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuDrop;
        private System.Windows.Forms.ToolStripMenuItem menuHistory;
        private System.Windows.Forms.ToolStripMenuItem menuFavourites;
    }
}

