using System;
using System.Windows.Forms;
using System.IO;

namespace Faktura {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            try{
                var file = new StreamReader("db.txt");
                string line;
                while ((line = file.ReadLine()) != null){
                    var client = Client.deserialize(line);
                    dataGridView1.Rows.Add(client.id, client.imie, client.nazwisko, client.nrtel);
                }file.Close();
            }catch { }
        }
        private void button_Add_Click(object sender, EventArgs e) {
            FormClient frm = new FormClient();
            frm.ShowDialog();
            var lastId = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.Add(lastId+1, frm.client.imie, frm.client.nazwisko, frm.client.nrtel);
            var s = frm.client.serialize();
            var file = new StreamWriter("db.txt", append: true);
            file.WriteLine(s);
            file.Close();
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            } else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void customImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            FormClient frm = new FormClient();
            frm.client.id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            frm.client.imie = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            frm.client.nazwisko = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            frm.client.nrtel = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            frm.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            if (tabControl2.TabPages.Contains(tabPage1)){
                tabControl2.SelectTab(tabPage1); 
            }else{
                tabControl2.TabPages.Add(tabPage1); 
                tabControl2.SelectTab(tabPage1);   
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl2.TabPages.Contains(tabPage2))
            {
                tabControl2.SelectTab(tabPage2);
            }
            else
            {
                tabControl2.TabPages.Add(tabPage2);
                tabControl2.SelectTab(tabPage2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl2.TabPages.Contains(tabPage3))
            {
                tabControl2.SelectTab(tabPage3);
            }
            else
            {
                tabControl2.TabPages.Add(tabPage3);
                tabControl2.SelectTab(tabPage3);
            }
        }
    }
}
