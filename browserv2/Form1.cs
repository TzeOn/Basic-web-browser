using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Net;

namespace browserv2
{
    public partial class Form1 : Form
    {
        // Stacks created to store URL data for navigating back and forward
        static Stack<string> runningHistory = new Stack<string>();
        static Stack<string> poppedHistory = new Stack<string>(); 

        public Form1()
        {
            InitializeComponent();
        }

        // When initially loaded in, will get HTTP content from home page
        // If loaded in from history form action, will get HTTP content from the selected history page
        // If loaded in from the favourites form action, will get HTTP content from the selected favourites page
        public void Form1_Load(object sender, EventArgs e)
        {         
            try
            {
                if (!history.getHistoryURL().Equals(""))
                {
                    getRequest(history.getHistoryURL(), pageText);
                    history.setHistoryURL("");
                }
                if (!favourite.getFavouriteURL().Equals(""))
                {
                    getRequest(favourite.getFavouriteURL(), pageText);
                    favourite.setFavouriteURL("");
                }
                else
                {
                    getRequest(home.getHome(), pageText);
                }
            }catch(NullReferenceException ex) { getRequest(home.getHome(), pageText); } // If history/favourites == empty
        }

        // getRequest method sends a URL request, receives the response then displays the content in a richTextBox 
        async void getRequest(string url, RichTextBox t)
        {
            try
            {
                if (!url.Equals(""))    // continue if the url is not empty
                {
                    // initiates new HttpClient object
                    using HttpClient client = new HttpClient();

                    //Check whether it starts with http:// or https://
                    if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                    {
                        // If it isn't a typical URL ending, perform google query on input
                        if (!url.EndsWith(".com") && !url.EndsWith(".co.uk") && !url.EndsWith(".ac.uk") && !url.Contains("."))
                        {
                            string google = "http://www.google.com/search?q=";
                            url = google + url;
                        }
                        else
                        {
                            url = "http://" + url; // string url now starts with http://
                        }
                    }
                    // Uses HttpResponseMessage to store the response from the given URL              
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        string s = response.StatusCode.ToString();
                        // Error messages for status code 400, 403, 404
                        if (response.StatusCode.ToString().Equals("BadRequest"))
                        {
                            MessageBox.Show("Error: Bad Request!");
                        }
                        else if (response.StatusCode.ToString().Equals("Forbidden"))
                        {
                            MessageBox.Show("Error: Forbidden!");
                        }
                        else if (response.StatusCode.ToString().Equals("NotFound"))
                        {
                            MessageBox.Show("Error: Not found!");
                        }

                        // Uses the HttpResponseMessage to display the HttpContent as strings
                        using (HttpContent content = response.Content)
                        {
                            string mycontent = await content.ReadAsStringAsync();   // read in HTML code to a string variable
                            t.Text = mycontent;
                            string pageTitle = "";

                            // Generate the title of the page from the HTML to be displayed at the top of the browser from the HTML code
                            Regex x = new Regex("<title>(.*)</title>");
                            MatchCollection m = x.Matches(mycontent);
                            if (m.Count > 0)
                            {
                                pageTitle = m[0].Value.Replace("<title>", "").Replace("</title>", "");
                            }
                            Form1.ActiveForm.Text = s + " " + pageTitle;

                            // updates the temporary stacks for page forward and back, does not re-add on refresh
                            if (runningHistory.Count == 0)
                            {
                                runningHistory.Push(url);
                            }
                            if (!runningHistory.Peek().Equals(url))
                            {
                                runningHistory.Push(url);
                            }

                            //Display the current URL in the URL textbox
                            textboxURL.Text = url;
                            // Update global history stack
                            history.mainStack.Push(url);
                            // Update history file
                            history.updateHistoryFIle(url);
                        }
                    }
                }
            }   // catch exceptions for invalid url and webexception, displays relevant messages
                catch(System.Exception ex) 
                {
                    if(ex is UriFormatException)
                    {
                        MessageBox.Show("Invalid URL!");
                    }
                    if(ex is WebException)
                    {
                        MessageBox.Show("WebException!");
                    }
                }
        }

        // Set the current URL as homepage    
        private void btnSetHome_Click(object sender, EventArgs e)
            {
                home.setHome(textboxURL.Text);
            }

        // Edits the stored homepage to the text value inside textboxHome
        private void btnHomeEdit_Click(object sender, EventArgs e)
        {
            if (!textboxHome.Equals(""))
            {
                home.setHome(textboxHome.Text);
            }
        }

        // Navigate to home page 
        private void btnHome_Click(object sender, EventArgs e)
        {
            getRequest(home.getHome(), pageText);
        }

        // Alternative to clicking the Go button. Press enter
        private void textboxURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && !textboxURL.Text.Equals(""))
            {
                getRequest(textboxURL.Text, pageText);
            }
        }

        // If the URL textbox is not empty - navigate to that url
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!textboxURL.Text.Equals(""))
            {
                getRequest(textboxURL.Text, pageText);
            }
        }

        // Alternative to clicking the edit homepage button
        private void textboxHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && !textboxHome.Text.Equals(""))
            {
                home.setHome(textboxHome.Text);
            }
        }

        // Finds the current URL even if the URL textbox is empty or has been changed, then reloads the current page
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getRequest(history.mainStack.Peek(), pageText);
        }

        // Navigate to the previous page in the stack
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (runningHistory.Count > 1)
            {
                poppedHistory.Push(runningHistory.Pop());
                string newURL = runningHistory.Peek();
                getRequest(newURL, pageText);
            }

        }

        // Navigate to the next page, using the stacks
        private void btnFwd_Click(object sender, EventArgs e)
        {
            if (poppedHistory.Count > 0)
            {
                runningHistory.Push(poppedHistory.Pop());
                string newURL = runningHistory.Peek();
                getRequest(newURL, pageText);
            }
        }

        // Opens up the history list form that displays the past URLs
        private void btnHistory_Click(object sender, EventArgs e)
        {
            historyForm hForm = new historyForm();
            hForm.Show();
        }

        // Add the current page to the favourites list, taking the text in textboxFavourite as the name
        private void btnAddFavourite_Click(object sender, EventArgs e)
        {
            favourite.addFavourite(textboxFavourite.Text, textboxURL.Text);
            favourite.refreshFile();
        }

        // Open up favourites form to display favourites list
        private void btnFavourites_Click(object sender, EventArgs e)
        {
            favouriteForm fForm = new favouriteForm();
            fForm.Show();
        }

        // Shortcut to add current page to favourites list by using the enter key
        private void textboxFavourite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                favourite.addFavourite(textboxFavourite.Text, textboxURL.Text);
                favourite.refreshFile();
            }
        }

        // Keyboard shortcuts for History (ctrl + H), Favourites (ctrl + B) and Refresh (F5)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.H)
            {
                historyForm hForm = new historyForm();
                hForm.Show();
            }

            if (e.Control && e.KeyCode == Keys.B)
            {
                favouriteForm fForm = new favouriteForm();
                fForm.Show();
            }
            if(e.KeyCode == Keys.F5)
            {
                getRequest(history.mainStack.Peek(), pageText);
            }
        }

        // Menu functionality to navigate to History and Favourite forms
        private void menuHistory_Click(object sender, EventArgs e)
        {
            historyForm hForm = new historyForm();
            hForm.Show();
        }

        private void menuFavourites_Click(object sender, EventArgs e)
        {
            favouriteForm fForm = new favouriteForm();
            fForm.Show();
        }
    }
}

