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
                        Grocery = Grocery.Replace("##LOC", "");
                        Grocery = Grocery.Replace("%%CAT", "");
                        Grocery = Grocery.Replace('"', ' ');
                        GroceryList = Grocery.Split(",");
                        Grocery = Grocery + "," + "\n";
                        TotalGroceryList += Grocery;
                        if (GroceryList[0] != " ")
                        {
                            DisplayListBox.Items.Add(GroceryList[0]);
                        }
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

        }

        void Filter()
        {
            FilterComboBox.Items.Clear();
            if (FilterByAisleRadioButton.Checked == true)
            {
                FilterComboBox.Items.Add("Show All");

            }
            else
            {
                FilterComboBox.Items.Add("Show All");
            }
        }

        void DisplayResult(int order)
        {
            item = GroceryList[0 + (3 * order)];
            aisle = " Aisle" + GroceryList[1 + (3 * order)];
            category = GroceryList[2 + (3 * order)];
            DisplayLabel.Text = $"{item} is on {aisle} with the {category}";
        }

        //Event Handlers-------------------------------------------------------------------------------------------------
        private void SearchButton_Click(object sender, EventArgs e)
        {

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
            int order = DisplayListBox.SelectedIndex;
            DisplayResult(order);
        }
    }
}
