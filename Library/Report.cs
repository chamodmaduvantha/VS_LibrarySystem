using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Report : Form
    {
        function fn = new function();
        String query;
        public Report()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void Report_Load(object sender, EventArgs e)
        {
            query = "select * from issue ";
            DataSet ds1 = fn.getData(query);
            DGVissue.DataSource = ds1.Tables[0];

            query = "select * from retbook ";
            DataSet ds2 = fn.getData(query);
            DGVreturn.DataSource = ds2.Tables[0];
        }
    }
}
