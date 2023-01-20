using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class Delete : Form
    {
        function fn = new function();
        String query;

        public Delete()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PDstudent.Visible = true;
            PDstudent.BringToFront();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            PDstudent.Visible = false;
            PDbook.Visible = false;

            String date = DateTime.Now.ToString("yyyy-MM-dd");
            lbldate.Text = date;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PDbook.Visible = true;
            PDbook.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from student where Student_ID like'" + txtDstudentsearch.Text + "%'";
            DataSet ds = fn.getData(query);
            DGVDstudent.DataSource = ds.Tables[0];

        }

        public void loadDataStudent()
        {
            query = "select * from student";
            DataSet ds = fn.getData(query);
            DGVDstudent.DataSource = ds.Tables[0];
        }

        public void loadDataBook()
        {
            query = "select * from book";
            DataSet ds = fn.getData(query);
            DGVDbook.DataSource = ds.Tables[0];
        }

        private void DGVDstudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Student?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(DGVDstudent.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from student where Student_ID=" + id + "";
                fn.setData(query);

                loadDataStudent();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            query = "select * from book where Book_ID like'" + txtDbooksearch.Text + "%'";
            DataSet ds = fn.getData(query);
            DGVDbook.DataSource = ds.Tables[0];
        }

        private void DGVDbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Book?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(DGVDbook.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from book where Student_ID=" + id + "";
                fn.setData(query);

                loadDataBook();
            }
        }

        private void PDstudent_Paint(object sender, PaintEventArgs e)
        {
            loadDataStudent();
        }

        private void PDbook_Paint(object sender, PaintEventArgs e)
        {
            loadDataBook();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }
    }
}
