using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinForm_HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cities_SelectedIndexChanged(object sender, EventArgs e)//"EventArgs - an event handler"
        {
            //Whenever an item is selected in the Cities groupbox, a message box
            //will pop up with the selected item
            string text = Cities.GetItemText(Cities.SelectedItem);//Getting the selected list item .
                                                                  //The method "GetItemText" gets the the actual value 
                                                                  //of the selected item (inside the "Cities"),
                                                                  //then it's assigned to the "text" variable...
            MessageBox.Show(text);//MessageBox to show the value 
            //Playing with it : MessageBox.Show("Stas");//MessageBox to show the value 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1_TextChanged_1
            String name = textBox1.Text;

            //textBox2_TextChanged
            String address = textBox2.Text;

          MessageBox.Show(name + " " + address);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
