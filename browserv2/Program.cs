using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browserv2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Load the history stack and favourites list from the file
            history.loadStack();
            favourite.loadFavourites();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
    
    // History class that can be accessed globally to load and store data from history file
    public static class history
    {
        public static Stack<string> mainStack = new Stack<string>();
        public static Stack<string> tempStack = new Stack<string>();

        public static string url="";

        // Set and Get used for navigation when clicking items in the history form
        public static void setHistoryURL(string s)
        {
            history.url = s;
        }
        public static string getHistoryURL()
        {
            return history.url;
        }

        // Load the contents of the history file into the global history stack
        public static void loadStack()
        {
            string[] rawText = System.IO.File.ReadAllLines("../../Resources/historyList.csv");
            foreach (string textLine in rawText)
            {
                history.mainStack.Push(textLine);
            }
        }

        // Clear the history file and stack
        public static void clearHistory()
        {
            try
            {
                // Rewrites over the historyList file with empty string; erasing all previous history
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("../../Resources/historyList.csv", false))
                {
                    file.WriteLine("");
                }
            }
            catch (Exception ex) { Console.WriteLine("Error: ", ex); }
            // Clear the current listview 
            history.mainStack.Clear();
        }

        // Update the history file with the new URL
        public static void updateHistoryFIle(string url)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("../../Resources/historyList.csv", true))
                {
                    file.WriteLine(url);
                }
            }
            catch (Exception ex) { Console.WriteLine("Error: ", ex); }
        }

    }

    // Favourite class that can be accessed globally to load and store from favourites file
    public static class favourite
    {
        public static string name;
        public static string url;
        public static List<string> favourites = new List<string>();

        // Add name and url to list, separated by a comma for CSV
        public static void addFavourite(string name, string url)
        {
            foreach(string f in favourite.favourites)
            {
                string[] col = f.Split(',');
                string n = col[0];
                string u = col[1];

                // If the URL already exists in the list then message will display to warn user they have already
                // favourited the URL, and exit out the method without adding a duplicate
                if (u.Equals(url))
                {
                    MessageBox.Show("You have already favourited this webpage");
                    return;
                }
            }
            favourite.favourites.Add(name + "," + url);
        }

        // Load the contents of the favourites file to the favourites list
        public static void loadFavourites()
        {
            // If the list already contains items, then clear it before adding more to prevent duplication
            if (favourite.favourites.Count > 0)
            {
                favourite.favourites.Clear(); 
            }
            
            string[] rawText = System.IO.File.ReadAllLines("../../Resources/favouritesList.csv");
            foreach (string textLine in rawText)
            {
                favourite.favourites.Add(textLine);
            }
        }

        // Method that searches through the favourites list where the url matches, then changes the name
        public static void searchAndReplaceName(string name, string url)
        {
            foreach(string f in favourite.favourites)
            {
                // Split the line into name and url
                string[] col = f.Split(',');
                string fName = col[0];
                string fURL = col[1];
                int index;

                // If the stored URL is the same as the input, change the name to new input name
                if (fURL.Equals(url))
                {
                    string newFavourite = name + ',' + fURL;
                    index=favourite.favourites.IndexOf(f);
                    favourite.favourites.Insert(index, newFavourite);
                    favourite.favourites.Remove(f);
                    return;
                }
            }
        }

        // Method that searches through the favourites list where the name matches, then changes the url
        public static void searchAndReplaceURL(string name, string url)
        {
            foreach (string f in favourite.favourites)
            {
                // Split the line into name and url
                string[] col = f.Split(',');
                string fName = col[0];
                string fURL = col[1];
                int index;

                // If the stored name is the same as the input, change the URL to new input URL
                if (fName.Equals(name))
                {
                    string newFavourite = fName + ',' + url;
                    index = favourite.favourites.IndexOf(f);
                    favourite.favourites.Insert(index, newFavourite);
                    favourite.favourites.Remove(f);
                    return;
                }
            }
        }

        // Search through the favourites list for a matching name + url, then removes from list
        public static void searchAndDelete(string name, string url)
        {
            foreach (string f in favourite.favourites)
            {
                // Split the line into name and url
                string[] col = f.Split(',');
                string fName = col[0];
                string fURL = col[1];

                // If the passed name and url match the favourite, remove it then exit method
                if (fName.Equals(name) && fURL.Equals(url))
                {
                    favourite.favourites.Remove(f);
                    return;
                }
            }
        }

        // Write over the favourites file with new list of favourites
        public static void refreshFile()
        {
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

        // Set and Get both used for navigating to selected URLs from the favourites list when clicked
        public static void setFavouriteURL(string s)
        {
            favourite.url = s;
        }
        public static string getFavouriteURL()
        {
            return favourite.url;
        }

    }

    // Home class that can be accessed globally. Loads and stores data from the Home file.
    public static class home
    {
        public static string url;

        // Returns the homepage URL from the home file as a string, if null returns google.com as default home page 
        public static string getHome()
        {
            string[] rawText = System.IO.File.ReadAllLines("../../Resources/homeTest.csv");
            string homeURL;
            foreach (string textLine in rawText)
            {
                homeURL = textLine;
                if (!homeURL.Equals(""))
                {
                    return homeURL;
                }
            }
            return "google.com";
        }

        // Sets the homepage by writing over the current contents of the home file.
        public static void setHome(string s)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("../../Resources/homeTest.csv", false))
                {
                    file.WriteLine(s);
                }
            }
            catch (Exception ex) { Console.WriteLine("Error: ", ex); }
        }
    }
}
