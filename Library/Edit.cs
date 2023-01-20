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
    public partial class Edit : Form
    {
        function fn = new function();
        String query;
        public Edit()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            loadDataBook();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtUbookid.Text == "" || txtUname.Text == "" || comboUcategoy.Text == "" || txtUauother.Text == "" || txtUprice.Text == "" || txtUyear.Text == "")
            {
                MessageBox.Show("Please enter the all details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                query = "update book set Book_ID= '"+txtUbookid.Text+"' , Book_Name='"+txtUname.Text+"' , Category='" + comboUcategoy.Text + "' , Auother='" + txtUauother.Text + "', Price='" + txtUprice.Text + "' , Publish_Year='" + txtUyear.Text + "' where Book_ID='"+ txtUbookid.Text + "'";
                fn.setData(query);
                loadDataBook();
                MessageBox.Show("Update Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUbookid.Clear();
                txtUname.Clear();
                //comboUcategoy.Clear();
                txtUauother.Clear();
                txtUprice.Clear();
                txtUyear.Clear();
            }
        }

        private void txtUbookSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from book where Book_Name like '" + txtUbookSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            DGVupdatebook.DataSource = ds.Tables[0];
        }

        public void loadDataBook()
        {
            query = "select * from book";
            DataSet ds = fn.getData(query);
            DGVupdatebook.DataSource = ds.Tables[0];
        }

        private void DGVupdatebook_Click(object sender, EventArgs e)
        {

        }


       // int id;
        private void DGVupdatebook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String bookid = DGVupdatebook.Rows[e.RowIndex].Cells[0].Value.ToString();
            string bookname = DGVupdatebook.Rows[e.RowIndex].Cells[1].Value.ToString();
            string category = DGVupdatebook.Rows[e.RowIndex].Cells[2].Value.ToString();
            string auother = DGVupdatebook.Rows[e.RowIndex].Cells[3].Value.ToString();
            string price = DGVupdatebook.Rows[e.RowIndex].Cells[4].Value.ToString();
            String year = DGVupdatebook.Rows[e.RowIndex].Cells[5].Value.ToString();

            txtUbookid.Text = bookid;
            txtUname.Text = bookname;
            comboUcategoy.Text = category;
            txtUauother.Text = auother;
            txtUprice.Text = price;
            txtUyear.Text = year;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUstudentsearch_TextChanged(object sender, EventArgs e)
        {
           
        }

       // int sid;
        private void DGVUstudent_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        public void loadDataStudent()
        {
            query = "select * from student";
            DataSet ds = fn.getData(query);
            DGVUstudent.DataSource = ds.Tables[0];
        }

        private void PUstudent_Paint(object sender, PaintEventArgs e)
        {
            loadDataStudent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void Edit_Load(object sender, EventArgs e)
        {
           PUstudent.Visible = false;
           PUbook.Visible = false;

            String date = DateTime.Now.ToString("yyyy-MM-dd");
            lbldate.Text = date;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtUstudentsearch_TextChanged_1(object sender, EventArgs e)
        {
            query = "select * from student where Student_ID like '" + txtUstudentsearch.Text + "%'";
            DataSet ds = fn.getData(query);
            DGVUstudent.DataSource = ds.Tables[0];
        }

        private void DGVUstudent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            loadDataStudent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
             PUstudent.Visible = true;
             PUstudent.BringToFront();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
             PUbook.Visible = true;
             PUbook.BringToFront();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (txtUstudentid.Text == "" || txtUstudentname.Text == "" || txtUaddress.Text == "" || txtUtpno.Text == "" || comboUcourse.Text == "" || comboUfaculity.Text == "" || txtUnicno.Text == "")
            {
                MessageBox.Show("Please enter the all details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                query = "update student set Student_ID= '" + txtUstudentid.Text + "' , Student_Name='" + txtUstudentname.Text + "' , Address='" + txtUaddress.Text + "' , TP_NO='" + txtUtpno.Text + "', Course_Name='" + comboUcourse.Text + "' , Faculity_Name='" + comboUfaculity.Text + "' , NIC_NO='" + txtUnicno.Text + "' where Student_ID='" + txtUstudentid.Text + "'";
                fn.setData(query);
                loadDataStudent();
                MessageBox.Show("Update Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUstudentid.Clear();
                txtUstudentname.Clear();
                //comboUcategoy.Clear();
                txtUaddress.Clear();
                txtUtpno.Clear();
                txtUnicno.Clear();
            }
        }

        private void DGVUstudent_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            String studentid = DGVUstudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            string studentname = DGVUstudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            string address = DGVUstudent.Rows[e.RowIndex].Cells[2].Value.ToString();
            string tpno = DGVUstudent.Rows[e.RowIndex].Cells[3].Value.ToString();
            string course = DGVUstudent.Rows[e.RowIndex].Cells[4].Value.ToString();
            String faculity = DGVUstudent.Rows[e.RowIndex].Cells[5].Value.ToString();
            String nicno = DGVUstudent.Rows[e.RowIndex].Cells[6].Value.ToString();

            txtUstudentid.Text = studentid;
            txtUstudentname.Text = studentname;
            txtUaddress.Text = address;
            txtUtpno.Text = tpno;
            comboUcourse.Text = course;
            comboUfaculity.Text = faculity;
            txtUnicno.Text = nicno;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtUstudentsearch_TextChanged_2(object sender, EventArgs e)
        {
            
        }

        private void txtUstudentsearch_TextChanged_3(object sender, EventArgs e)
        {
            query = "select * from student where Student_Name like '" + txtUstudentsearch.Text + "%'";
            DataSet ds = fn.getData(query);
            DGVUstudent.DataSource = ds.Tables[0];
        }
    }
}
