using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktura {
    public partial class FormClient : Form {
        public Client client = new Client();
        public Form1 form1 = new Form1();

        public FormClient() {
            InitializeComponent();
            client.ValuesChanged += Client_ValuesChanged;}

        private void Client_ValuesChanged(){
            RelaodData();}

        public void RelaodData(){
            tbID.Text = Convert.ToString(client.id);
            tbImie.Text = client.imie;
            tbNazwisko.Text = client.nazwisko;
            tbNrTel.Text = client.nrtel;}


        private void button_Canel_Click(object sender, EventArgs e){
            Close();}

        private void customImageButton1_Click(object sender, EventArgs e){
            Application.Exit();}

        private void button_Save_Click_1(object sender, EventArgs e){
            client.id = Convert.ToInt32( tbID.Text );
            client.imie = tbImie.Text;
            client.nazwisko = tbNazwisko.Text;
            client.nrtel = tbNrTel.Text;
            Close();}

        private void button_Clear_Click(object sender, EventArgs e){
            client.ValuesChanged -= Client_ValuesChanged;

            client = new Client();
            tbImie.Text = "";
            tbNazwisko.Text = "";
            tbNrTel.Text = "";}
    }
}
