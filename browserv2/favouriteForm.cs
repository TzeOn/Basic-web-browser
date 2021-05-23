using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browserv2
{
    public partial class favouriteForm : Form
    {

        public favouriteForm()
        {
            InitializeComponent();
        }

        public void favouriteForm_Load(object sender, EventArgs e)
        {          
            populateList();
        }

        // Populate the favourites ListView from the favourites object list
        public void populateList()
        {
            // Remove all items from the list for error prevention, prevent duplication
            if (favouritesList.Items.Count > 0)
            {
                favouritesList.Clear();
            }

            int count = 0;

            // Populate the listview
            foreach (string f in favourite.favourites)
            {
                string[] col = f.Split(',');
                string name = col[0];
                string url = col[1];
                ListViewItem item = new ListViewItem(name,count);
                item.SubItems.Add(url);
                favouritesList.Items.Add(item);
                count++;

            }
        }

        // Output the details of the selected item to designated text boxes
        public void favouritesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (favouritesList.SelectedItems.Count > 0)
            {
                // output the name and url of selected item to the textboxes
                textboxName.Text = favouritesList.SelectedItems[0].Text;
                textboxURL.Text = favouritesList.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void favouritesList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //

        }


        // Edits the selected item to new url
        private void btnEditURL_Click(object sender, EventArgs e)
        {
            string oldName = textboxName.Text;
            string newURL = textboxURL.Text;
            favourite.searchAndReplaceURL(oldName, newURL);
            favouritesList.SelectedItems[0].SubItems[1].Text = newURL;


            // Clear the current favourites file
            using (StreamWriter writer = new StreamWriter("../../resources/favouritesList.csv", true))
            {
                writer.WriteLine("");
            }

            // Rewrite updated favourites list to the file
            using (StreamWriter writer = new StreamWriter("../../resources/favouritesList.csv", false))
            {
                foreach (string f in favourite.favourites)
                {
                    writer.WriteLine(f);
                }
            }
        }

        // Edits the selected item name to new name
        private void btnEditName_Click(object sender, EventArgs e)
        {
            string newName = textboxName.Text;
            string oldURL = textboxURL.Text;
            favourite.searchAndReplaceName(newName, oldURL);
            favouritesList.SelectedItems[0].Text = newName;
            

            // Clear the current favourites file
            using (StreamWriter writer = new StreamWriter("../../resources/favouritesList.csv", true))
            {
                writer.WriteLine("");
            }

            // Rewrite updated favourites list to the file
            using(StreamWriter writer = new StreamWriter("../../resources/favouritesList.csv", false))
            {
                foreach(string f in favourite.favourites)
                {
                    writer.WriteLine(f);
                }
            }

        }

        // Shortcut to change name by pressing enter on the textbox
        private void textboxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string newName = textboxName.Text;
                string oldURL = textboxURL.Text;
                favourite.searchAndReplaceName(newName, oldURL);
                favouritesList.SelectedItems[0].Text = newName;


                // Clear the current favourites file
                using (StreamWriter writer = new StreamWriter("../../resources/favouritesList.csv", true))
                {
                    writer.WriteLine("");
                }

                // Rewrite updated favourites list to the file
                using (StreamWriter writer = new StreamWriter("../../resources/favouritesList.csv", false))
                {
                    foreach (string f in favourite.favourites)
                    {
                        writer.WriteLine(f);
                    }
                }
            }
        }

        // Shortcut to change url pressing enter on the textbox
        private void textboxURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string oldName = textboxName.Text;
                string newURL = textboxURL.Text;
                favourite.searchAndReplaceURL(oldName, newURL);
                favouritesList.SelectedItems[0].SubItems[1].Text = newURL;


                // Clear the current favourites file
                using (StreamWriter writer = new StreamWriter("../../resources/favouritesList.csv", true))
                {
                    writer.WriteLine("");
                }

                // Rewrite updated favourites list to the file
                using (StreamWriter writer = new StreamWriter("../../resources/favouritesList.csv", false))
                {
                    foreach (string f in favourite.favourites)
                    {
                        writer.WriteLine(f);
                    }
                }
            }
        }

        // Deletes the selected favourite from the list and file
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = favouritesList.SelectedItems[0].Text;
            string url = favouritesList.SelectedItems[0].SubItems[1].Text;

            favourite.searchAndDelete(name, url);
            favourite.refreshFile();

            favouritesList.SelectedItems[0].Text=null;
            favouritesList.SelectedItems[0].SubItems[1].Text=null;

        }

        // When an item is double clicked, user will navigate to that item url
        private void favouritesList_ItemActivate(object sender, EventArgs e)
        {
            favourite.setFavouriteURL(favouritesList.SelectedItems[0].SubItems[1].Text);
            Form1 newForm = new Form1();
            this.Close();
            newForm.Show();
        }

        // Add new favourite to list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textboxAddName.Text;
            string url = textboxAddURL.Text;

            // If textboxes are not empty
            if(!name.Equals("") && !url.Equals(""))
            {
                favourite.addFavourite(name, url);
                favourite.refreshFile();

                foreach(string f in favourite.favourites)
                {
                    string[] col = f.Split(',');
                    string fName = col[0];
                    string fURL = col[1];

                    // Check if URL already exists before adding to list
                    if (fURL.Equals(url))
                    {
                        return;
                    }
                }

                ListViewItem item = new ListViewItem(name, favouritesList.Items.Count);
                item.SubItems.Add(url);
                favouritesList.Items.Add(item);
            }
        }
    }

    
    
}


