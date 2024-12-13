using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace piratesfinals
{
    public partial class frmPirates : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Kyle\\Downloads\\dpPirates.accdb";
        OleDbConnection conn;
        public frmPirates()
        {
            InitializeComponent();

        }

        private void frmPirates_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select piratename as ALIAS, givenname as NAME, age as AGE, pirategroup as PIRATEGROUP, bounty as BOUNTY from pirates";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            grdView.DataSource = dt;
            grdView.Columns["age"].Visible = false;


            cboGroup.DataSource = dt;
            
            cboGroup.DisplayMember = "pirategroup";
            cboPirate.DataSource = dt;
            cboPirate.DisplayMember = "pirategroup";

        }

        private void grdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAlias.Text = grdView.SelectedCells[0].Value.ToString();
            txtName.Text = grdView.SelectedCells[1].Value.ToString();
            txtAge.Text = grdView.SelectedCells[2].Value.ToString();
            cboPirate.Text = grdView.SelectedCells[3].Value.ToString();
            txtBounty.Text = grdView.SelectedCells[4].Value.ToString();
        }

        private void btnSearchPirate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKeyword.Text) || (string.IsNullOrEmpty(cboGroup.Text)))
            {
                MessageBox.Show("PLEASE FILL UP THE TEXTBOX", "ERROR");
            }
            else
            {
                DataTable dt = new DataTable();
                string query = "select piratename as ALIAS, givenname as NAME,age as AGE, pirategroup as PIRATEGROUP, bounty as BOUNTY from pirates where givenname = '" + txtKeyword.Text + "' or piratename = '" + txtKeyword.Text + "' ";
                conn = new OleDbConnection(connStr);
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                adapter.Fill(dt);
                conn.Close();

                grdView.DataSource = dt;
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            btnNewRecord.Enabled = false;
            txtAlias.Enabled = true;
            txtName.Enabled = true;
            txtAge.Enabled = true;
            cboPirate.Enabled = true;
            txtBounty.Enabled = true;
            DataTable dt = new DataTable();
            string query = "select piratename as ALIAS, givenname as NAME,age as AGE, pirategroup as PIRATEGROUP, bounty as BOUNTY from pirates where piratename = '"+txtAlias.Text+"' ";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            grdView.DataSource = dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAlias.Text = " ";
            txtName.Text = " ";
            txtAge.Text = " ";
            cboPirate.Text = " ";
            txtBounty.Text = " ";
            btnNewRecord.Enabled = false;
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            txtAlias.Text = " ";
            txtName.Text = " ";
            txtAge.Text = " ";
            cboPirate.Text = " ";
            txtBounty.Text = " ";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT into pirates (piratename, givenname, age, bounty, pirategroup) values(@alias, @name, @age, @bounty, @pirategroup)";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@alias", txtAlias.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            cmd.Parameters.AddWithValue("@bounty", txtBounty.Text);
            cmd.Parameters.AddWithValue("@pirategroup", cboGroup.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Input added");
        }

        private void groupBPirate_Enter(object sender, EventArgs e)
        {
            
            
        }
    }
}
