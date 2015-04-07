using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTableTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable book=new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
            
            string isbn = textBox1.Text;
            if (book.ContainsKey(isbn))
            {

                MessageBox.Show("This book in this List try other");
            }
            else
            {
                book.Add(isbn, textBox2.Text);
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isbn = textBox3.Text;
            if (book.ContainsKey(isbn))
            {


                textBox4.Text = (string) book[isbn];

            }
            else
            {
               
               
                textBox4.Text = string.Empty;
                MessageBox.Show("not Found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}
