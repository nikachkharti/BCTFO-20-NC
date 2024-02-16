using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var source = @"../../../test.txt";

            //using (StreamWriter writer = new(source, append: true))
            //{
            //    writer.WriteLine("Hello");
            //}

            //List<string> lineList = new();

            //using (StreamReader reader = new(source))
            //{
            //    string line = string.Empty;

            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        lineList.Add(line);
            //    }
            //}

        }

    }
}
