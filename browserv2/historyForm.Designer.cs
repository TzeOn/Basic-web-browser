namespace browserv2
{
    partial class historyForm
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
            this.historyListView = new System.Windows.Forms.ListView();
            this.historyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyListView
            // 
            this.historyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.historyHeader});
            this.historyListView.HideSelection = false;
            this.historyListView.Location = new System.Drawing.Point(11, 7);
            this.historyListView.Name = "historyListView";
            this.historyListView.Size = new System.Drawing.Size(1118, 1046);
            this.historyListView.TabIndex = 0;
            this.historyListView.UseCompatibleStateImageBehavior = false;
            this.historyListView.View = System.Windows.Forms.View.Details;
            this.historyListView.ItemActivate += new System.EventHandler(this.historyListView_ItemActivate);
            // 
            // historyHeader
            // 
            this.historyHeader.Text = "History";
            this.historyHeader.Width = 500;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(1156, 62);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(164, 71);
            this.btnClearHistory.TabIndex = 1;
            this.btnClearHistory.Text = "Clear history";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // historyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 1064);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.historyListView);
            this.Name = "historyForm";
            this.Text = "historyForm";
            this.Load += new System.EventHandler(this.historyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView historyListView;
        private System.Windows.Forms.ColumnHeader historyHeader;
        private System.Windows.Forms.Button btnClearHistory;
    }
}