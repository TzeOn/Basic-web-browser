using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browserv2
{
    public partial class historyForm : Form
    {
        public historyForm()
        {
            InitializeComponent();
        }

        private void historyForm_Load(object sender, EventArgs e)
        {
            // Populate the ListViw from the main stack
            while(history.mainStack.Count != 0)
            {
                history.tempStack.Push(history.mainStack.Peek());
                historyListView.Items.Add(history.mainStack.Pop());
            }

            // After main list has been popped into the list view, repopulate main stack from temp stack
            while (history.tempStack.Count != 0)
            {
                history.mainStack.Push(history.tempStack.Pop());
            }

        }

        // Clears the history stack and file
        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            history.clearHistory();
            historyListView.Items.Clear();
        }

        // When an item is double clicked, user will navigate to that url in a new window, closing this form
        private void historyListView_ItemActivate(object sender, EventArgs e)
        {
            history.setHistoryURL(historyListView.SelectedItems[0].Text);
            Form1 newForm = new Form1();
            this.Close();
            newForm.Show();           
        }
    }
}
