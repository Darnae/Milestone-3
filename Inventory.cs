using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Darnae Simmons
// This is my own Work

namespace Inventory_Manager
{
    public partial class Inventory_Form : Form
    {
        public Inventory_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Inventory_Button_Click(object sender, EventArgs e) //  button that displays methods
        {
            Inventory_Manager inventory_Manager = new Inventory_Manager();

            inventory_Manager.increase_Storage(); // adds item to storage 

            inventory_Manager.decrease_Storage(); // deletes item from storage

            inventory_Manager.restock_Storage(); // restocks an item in storage

            inventory_Manager.search_Storage(); // searchs for item in storage based on criteria

            inventory_Manager.getStorage(); // returns storage value
        }
    }
    class Inventory_Manager // inventory class
    {
        private string[] storage;

        public Inventory_Manager()
        {
            storage = new string[5];
        }
        public void increase_Storage() // add to storage
        {
            storage[0] = "Equipment ";
            storage[1] = "Weapons Cash  ";
            storage[2] = "Power tools  ";        
        }
        public void decrease_Storage() // remove from storage
        {
            storage[1] = "      NA      ";
        }

        public void restock_Storage()
        {
            storage[3] = " Weapons Cash(restocked)  ";
        }
        public void search_Storage() // searches for item in storage
        {

            string search = Array.Find(storage, element => element.StartsWith("E", StringComparison.Ordinal));

            MessageBox.Show("I searched for  " + search + " by first letter");

            string second_Search = Array.Find(storage, element => element.Equals(search));

            MessageBox.Show("Then I found  " + second_Search + " by name");
        }

        public string getStorage() // displays storage
        {
            MessageBox.Show(" Items Currently in storage: " + storage[0] + storage[1] + storage[2] + storage[3]);

            return storage.ToString();
        }



    } // For Class
}// For Namespace
