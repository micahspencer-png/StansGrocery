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
        }
        //Program Logic-------------------------------------------------------------------------------------------------

        List<string> Grocery;
        string GroceryFilePath = "";
        string[] GroceryList;
        string item = GroceryList[0];
        string aisle = GroceryList[1];
        string category = GroceryList[2];
        string number = GroceryList[3];
        void SetDefaults()
        {
            SearchTextBox.Text = "";
            SearchTextBox.Focus();
            FilterComboBox.SelectedIndex = 0;
            FilterByAisleRadioButton.Checked = true;
        }

        void DisplayResult() 
        {
            DisplayLabel.Text = $"{item} is on {aisle} with the {category}. There are {number} left";
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

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
