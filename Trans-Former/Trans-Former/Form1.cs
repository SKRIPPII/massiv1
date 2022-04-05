using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trans_Former
{
    
    public partial class Form1 : Form
    {
        public string[] array = new string[80];
        public string[] array1 = new string[80];
        public int[] price = new int[80];
        Random random = new Random();
        public int sum = 0;

        public Form1()
        {

            
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            form.Update();
            System.Threading.Thread.Sleep(5000);
            form.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             
         for (int i = 0; i < listBox1.Items.Count; i++)
            {
                array[i] = listBox1.Items[i].ToString();
            }

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                array1[i] = listBox2.Items[i].ToString();
            }
            for (int i = 0; i < array.Length; i++)
            {
                price[i] = random.Next(1000, 10000);
            }

            listBox2.Items.Add(listBox1.Text);


            for (int i = 0; i < array1.Length; i++)
            {
                sum += price[i];
            }

            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sum.ToString());
        }
    }
}
