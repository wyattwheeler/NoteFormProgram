using System;
using System.Data;
using System.Windows.Forms;

namespace Notes
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable(); // Define
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            DGVNoteList.DataSource = table; // link datatable to DGV

            DGVNoteList.Columns["Messages"].Visible = false;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TextTitle.Clear();
            TextMessage.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(TextTitle.Text, TextMessage.Text);

            TextTitle.Text = DGVNoteList.CurrentCell.Value.ToString();

            TextTitle.Clear();
            TextMessage.Clear();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            int iIndex = DGVNoteList.CurrentCell.RowIndex;

            if(iIndex > -1)
            {
                TextTitle.Text = table.Rows[iIndex].ItemArray[0].ToString();
                TextMessage.Text = table.Rows[iIndex].ItemArray[1].ToString();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int iIndex = DGVNoteList.CurrentCell.RowIndex;

            table.Rows[iIndex].Delete();
        }
    }
}