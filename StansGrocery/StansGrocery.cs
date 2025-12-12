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
            
        }
        //Program Logic-------------------------------------------------------------------------------------------------

        string Grocery;
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
                        Grocery = fileRead.ReadLine();
                        GroceryList = Grocery.Split(":");
                        DisplayListBox.Items.Add(GroceryList[0]);
                    } while (fileRead.EndOfStream == false);
                    
                    
                }
            }
            catch (Exception)
            {
                using (StreamWriter fileWrite = File.CreateText(GroceryFilePath))
                {
                    fileWrite.WriteLine("Item:Aisle:Category:");
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
                FilterComboBox.Items.Add(GroceryList[1]);
            }
            else 
            {
                FilterComboBox.Items.Add(GroceryList[2]);
            }
        }

        void DisplayResult()
        {
            DisplayLabel.Text = $"{item} is on {aisle} with the {category}.";
        }

        //Event Handlers-------------------------------------------------------------------------------------------------
        private void SearchButton_Click(object sender, EventArgs e)
        {
            GroceryPath();
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
    }
}
