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
            GroceryPath();
            SetDefaults();
        }
        //Program Logic-------------------------------------------------------------------------------------------------

        List<string> Grocery;
        string GroceryFilePath = "..\\..\\..\\..\\Grocery.txt";
        string[] GroceryList;
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
                        string inventory = fileRead.ReadLine();
                        GroceryList = inventory.Split(":");
                    } while (fileRead.EndOfStream == false);
                }
            }
            catch (Exception)
            {
                using (StreamWriter fileWrite = File.CreateText(GroceryFilePath))
                {
                    fileWrite.WriteLine("Item:Aisle:Category");
                }
            }
        }

        void SetDefaults()
        {
            SearchTextBox.Text = "";
            SearchTextBox.Focus();
            FilterComboBox.SelectedIndex = 0;
            FilterByAisleRadioButton.Checked = true;
        }

        void ChangeCombobox() 
        { 
        
        }

        void DisplayResult()
        {
            DisplayLabel.Text = $"{item} is on {aisle} with the {category}.";
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

        }
    }
}
