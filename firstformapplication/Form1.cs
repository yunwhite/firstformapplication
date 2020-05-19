using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstformapplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            myButton.Enabled = true;
            myButton.Text = "개학하기 싫다";
            myButton.Width = 200;

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);

                button.Location = new Point(213, 13 + (23 + 3) * i);
                button.Text = "집 가고싶다";
                button.Width = 100;
            }
        }
    }
}
