using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED
{
    public partial class Form1 : Form
    {
        SqlConnection sql;
        string connetionString = @"Data Source=200.69.137.167,11333;Initial Catalog=BD3K3G05_2022;User ID=BD3K3G05_2022;Password=CLV05_25089";
        public Form1()
        {
            InitializeComponent();
            sql = new SqlConnection(connetionString);
            sql.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
