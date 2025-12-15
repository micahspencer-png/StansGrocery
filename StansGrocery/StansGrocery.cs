using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text.RegularExpressions;

namespace StansGrocery
{
    //Micah Spencer
    //RCET 2265
    //Fall 2025
    //Stans Grocery Search Form
    //https://github.com/micahspencer-png/StansGrocery.git
    public partial class StansGrocery : Form
    {
        //For future project adjustments
        //
        //Add splashscreen to the project.
        //adjust list so that null fields can't exist
        //link about button to a messagebox to show top comments
        //

        public StansGrocery()
        {
            InitializeComponent();
            SetDefaults();
            GroceryPath();
            Filter();
        }
        //Program Logic-------------------------------------------------------------------------------------------------

        string Grocery;
        string GroceryFilePath = "..\\..\\..\\..\\Grocery.txt";
        string[] GroceryList;
        string[] SearchList;
        string TotalGroceryList;
        string item = "";
        string aisle = "";
        string category = "";
        int index = 0;
        
        void GroceryPath()
        {
            try
            {

                using (StreamReader fileRead = new StreamReader(GroceryFilePath))
                {
                    
                    do
                    {
                        Grocery = fileRead.ReadLine();
                        Grocery = Grocery.Replace(" ", "");
                        Grocery = Grocery.Replace("$$ITM", "");
                        Grocery = Grocery.Replace("##LOC", "Aisle ");
                        Grocery = Grocery.Replace("%%CAT", "");
                        Grocery = Grocery.Replace('"', ' ');
                        Grocery = Grocery.Trim();
                        GroceryList = Grocery.Split(",");
                        Grocery = Grocery + "," + "\n";
                        TotalGroceryList += Grocery;
                        
                        if (GroceryList[0] != "")
                        {
                            DisplayListBox.Items.Add(GroceryList[0]);
                        }
                        index++;
                    } while (fileRead.EndOfStream == false);

                    GroceryList = TotalGroceryList.Split(",");
                    TotalGroceryList = TotalGroceryList.ToLower();
                    SearchList = TotalGroceryList.Split(",");
                    DisplayListBox.Sorted = true;
                }
            }
            catch (Exception)
            {
                using (StreamWriter fileWrite = File.CreateText(GroceryFilePath))
                {
                    fileWrite.WriteLine("$$ITM{name}", "##LOC{aisle}", "%%CAT{category}");
                }
            }
        }

        void SetDefaults()
        {
            SearchTextBox.Text = "";
            SearchTextBox.Focus();
            FilterComboBox.SelectedIndex = 0;
            FilterByAisleRadioButton.Checked = true;
            DisplayListBox.Items.Clear();
            DisplayLabel.Text = "";
        }

        void ChangeCombobox()
        {
            string comboitem = FilterComboBox.SelectedItem.ToString();
            DisplayListBox.Items.Clear();

            if (comboitem == "Show All")
            {
                for (int r = 0; r < index; r++)
                {
                    DisplayListBox.Items.Add(GroceryList[0 + (3 * r)]);
                }
            }

            else 
            {
                if (FilterByAisleRadioButton.Checked == true)
                {
                    for (int r = 0; r < index; r++)
                    {
                        if (GroceryList[(1 + (3 * r))].Contains(comboitem))
                        {
                            DisplayListBox.Items.Add(GroceryList[0 + (3 * r)]);
                        }
                    }
                }

                else
                {
                    for (int r = 0; r < index; r++)
                    {
                        if (GroceryList[2 + (3 * r)].Contains(comboitem))
                        {
                            DisplayListBox.Items.Add(GroceryList[0 + (3 * r)]);
                        }
                    }
                }
            }

            DisplayListBox.Sorted = true;
        }

        // Custom comparer for natural numeric sorting
        public class NaturalStringComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                if (x == null || y == null)
                    return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);

                // Extract numbers from strings
                var numX = ExtractNumber(x);
                var numY = ExtractNumber(y);

                // If both have numbers, compare numerically
                if (numX.HasValue && numY.HasValue)
                {
                    int cmp = numX.Value.CompareTo(numY.Value);
                    if (cmp != 0) return cmp;
                }

                // Fallback to case-insensitive string comparison
                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
            }

            private int? ExtractNumber(string input)
            {
                var match = Regex.Match(input, @"\d+");
                if (match.Success && int.TryParse(match.Value, out int number))
                    return number;
                return null;
            }
        }


        void Filter()
        {
            
            string Combofilter = "";
           

            if (FilterByAisleRadioButton.Checked == true)
            {
                for (int r = 0; r  < index; r++)
                {
                    string v = GroceryList[1 + (r * 3)];
                   
                    if (FilterComboBox.Items.Contains(v))
                    {

                    }
                    else 
                    { 
                        FilterComboBox.Items.Add(v);
                        Combofilter += v + ",";
                    }
                   
                }   
            }
            else
            {
                for (int r = 0; r < index; r++)
                {
                    string x = GroceryList[2 + (r * 3)];

                    if (FilterComboBox.Items.Contains(x))
                    {

                    }
                    else
                    {
                        FilterComboBox.Items.Add(x);
                        Combofilter += x + ",";
                    }
                    
                }  
            }

            List<string> FilterIndex = Combofilter.Split(",").ToList();
            if (FilterByAisleRadioButton.Checked == true)
            {
                FilterIndex.Sort(new NaturalStringComparer());
            }
            else
            {

                FilterIndex.Sort();
            }
            FilterComboBox.Items.Clear();
            FilterComboBox.Items.Add("Show All");
            foreach (var items in FilterIndex) 
            { 
                FilterComboBox.Items.Add(items);
            }


        }

        void SearchField() 
        {
            string searchString = SearchTextBox.Text;
            searchString = searchString.ToLower();


            DisplayListBox.Items.Clear();

            if (searchString == "zzz")
            {
                this.Close();
            }

            else 
            {
                for (int r = 0; r < index; r++)
                {
                    if (SearchList[(0 + (3 * r))].Contains(searchString) ||
                        SearchList[(1 + (3 * r))].Contains(searchString) ||
                        SearchList[(2 + (3 * r))].Contains(searchString) )
                    {
                        DisplayListBox.Items.Add(GroceryList[0 + (3 * r)]);
                    }
                }
            }

            if (DisplayListBox.Items.Count == 0) 
            { 
                DisplayLabel.Text = $"Sorry no matches for {searchString}";
            }
        }

        void DisplayResult()
        {
            string select = DisplayListBox.SelectedItem.ToString();

            for (int r = 0; r < index; r++)
            {
                if (GroceryList[0 + (3 * r)].Contains(select))
                {
                    item = GroceryList[0 + (3 * r)];
                    aisle = GroceryList[1 + (3 * r)];
                    category = GroceryList[2 + (3 * r)];
                }
            }

            
            DisplayLabel.Text = $"{item} is on {aisle} with the {category}";
        }

        //Event Handlers-------------------------------------------------------------------------------------------------
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchField();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCombobox();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterByAisleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void DisplayListBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            DisplayResult();
        }
    }
}
