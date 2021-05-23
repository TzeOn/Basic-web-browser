namespace browserv2
{
    partial class favouriteForm
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
            this.favouritesList = new System.Windows.Forms.ListView();
            this.favouriteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.favouriteURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxURL = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditURL = new System.Windows.Forms.Button();
            this.btnEditName = new System.Windows.Forms.Button();
            this.textboxAddURL = new System.Windows.Forms.TextBox();
            this.textboxAddName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // favouritesList
            // 
            this.favouritesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.favouriteName,
            this.favouriteURL});
            this.favouritesList.HideSelection = false;
            this.favouritesList.Location = new System.Drawing.Point(10, 3);
            this.favouritesList.Name = "favouritesList";
            this.favouritesList.Size = new System.Drawing.Size(922, 1015);
            this.favouritesList.TabIndex = 0;
            this.favouritesList.UseCompatibleStateImageBehavior = false;
            this.favouritesList.View = System.Windows.Forms.View.Details;
            this.favouritesList.ItemActivate += new System.EventHandler(this.favouritesList_ItemActivate);
            this.favouritesList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.favouritesList_ItemSelectionChanged);
            this.favouritesList.SelectedIndexChanged += new System.EventHandler(this.favouritesList_SelectedIndexChanged);
            // 
            // favouriteName
            // 
            this.favouriteName.Text = "Name";
            this.favouriteName.Width = 200;
            // 
            // favouriteURL
            // 
            this.favouriteURL.Text = "URL";
            this.favouriteURL.Width = 600;
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(966, 75);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(260, 35);
            this.textboxName.TabIndex = 1;
            this.textboxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxName_KeyPress);
            // 
            // textboxURL
            // 
            this.textboxURL.Location = new System.Drawing.Point(966, 178);
            this.textboxURL.Name = "textboxURL";
            this.textboxURL.Size = new System.Drawing.Size(260, 35);
            this.textboxURL.TabIndex = 2;
            this.textboxURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxURL_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1027, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 47);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditURL
            // 
            this.btnEditURL.Location = new System.Drawing.Point(1269, 172);
            this.btnEditURL.Name = "btnEditURL";
            this.btnEditURL.Size = new System.Drawing.Size(155, 47);
            this.btnEditURL.TabIndex = 5;
            this.btnEditURL.Text = "Edit URL";
            this.btnEditURL.UseVisualStyleBackColor = true;
            this.btnEditURL.Click += new System.EventHandler(this.btnEditURL_Click);
            // 
            // btnEditName
            // 
            this.btnEditName.Location = new System.Drawing.Point(1269, 69);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(155, 47);
            this.btnEditName.TabIndex = 6;
            this.btnEditName.Text = "Edit Name";
            this.btnEditName.UseVisualStyleBackColor = true;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // textboxAddURL
            // 
            this.textboxAddURL.Location = new System.Drawing.Point(966, 678);
            this.textboxAddURL.Name = "textboxAddURL";
            this.textboxAddURL.Size = new System.Drawing.Size(260, 35);
            this.textboxAddURL.TabIndex = 7;
            // 
            // textboxAddName
            // 
            this.textboxAddName.Location = new System.Drawing.Point(966, 605);
            this.textboxAddName.Name = "textboxAddName";
            this.textboxAddName.Size = new System.Drawing.Size(260, 35);
            this.textboxAddName.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1269, 640);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 47);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // favouriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 1026);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textboxAddName);
            this.Controls.Add(this.textboxAddURL);
            this.Controls.Add(this.btnEditName);
            this.Controls.Add(this.btnEditURL);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textboxURL);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.favouritesList);
            this.Name = "favouriteForm";
            this.Text = "favouriteForm";
            this.Load += new System.EventHandler(this.favouriteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView favouritesList;
        private System.Windows.Forms.ColumnHeader favouriteName;
        private System.Windows.Forms.ColumnHeader favouriteURL;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxURL;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditURL;
        private System.Windows.Forms.Button btnEditName;
        private System.Windows.Forms.TextBox textboxAddURL;
        private System.Windows.Forms.TextBox textboxAddName;
        private System.Windows.Forms.Button btnAdd;
    }
}