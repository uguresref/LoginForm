using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LoginForm
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int hak = 5;
        Random rnd = new Random();
        private void metroTile1_Click(object sender, EventArgs e)
        {
            label2.Text = rnd.Next(10000000, 900000000).ToString();
            if (hak == 0)
            {
                MessageBox.Show("hakkınız kalmadı");
                
            }
            else
            {
                hak--;
            }

            string username = textBox1.Text;
            switch (username)
            {
                case "admin":
                    MessageBox.Show("kullanıcı adı doğru");
                    break;

            }
            
            
        }
    }
}
