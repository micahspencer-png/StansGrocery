using System.Diagnostics.Eventing.Reader;

namespace StansGrocery
{
    //Micah Spencer
    //RCET 2265
    //Fall 2025
    //Stans Grocery Search Form
    //https://github.com/micahspencer-png/StansGrocery.git
    public partial class StansGrocery : Form
    {
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
        string TotalGroceryList;
        string item = "";
        string aisle = "";
        string category = "";
        string[] FilterIndex;
        string[] DisplayBoxList;
        int index = 0;
        string FilterList;
        void GroceryPath()
        {
            try
            {

                using (StreamReader fileRead = new StreamReader(GroceryFilePath))
                {
                    
                    do
                    {
                        Grocery = fileRead.ReadLine();
                        Grocery = Grocery.Replace("$$ITM", "");
                        Grocery = Grocery.Replace("##LOC", "Aisle ");
                        Grocery = Grocery.Replace("%%CAT", "");
                        Grocery = Grocery.Replace('"', ' ');
                        Grocery = Grocery.ToLower();
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
        }

        void Filter()
        {
            FilterComboBox.Items.Clear();
            FilterComboBox.Items.Add("Show All");

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
                        FilterList += v + ",";
                    }
                   
                }   
            }
            else
            {
                for (int r = 0; r < index; r++)
                {
                    string v = GroceryList[2 + (r * 3)];

                    if (FilterComboBox.Items.Contains(v))
                    {

                    }
                    else
                    {
                        FilterComboBox.Items.Add(v);
                        FilterList += v + ",";
                    }
                    
                }  
            }
            
        }

        void SearchField() 
        {
            string search = SearchTextBox.Text;
            search = search.ToLower();


            DisplayListBox.Items.Clear();

            if (search == "zzz")
            {
                this.Close();
            }

            else 
            {
                for (int r = 0; r < index; r++)
                {
                    if (GroceryList[(0 + (3 * r))].Contains(search))
                    {
                        DisplayListBox.Items.Add(GroceryList[0 + (3 * r)]);
                    }
                }
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
