using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App_Appuntamenti
{
    public partial class frm : Form
    {
        Registro List_Medici;
        Registro List_Pazienti;

        List<Patologia> List_Patologie;
        List<Specializzazione> List_Specializzazioni;
        List<Appuntamento> List_Appuntamenti;

        List<string> Nomi_Medici;
        List<string> Nomi_Pazienti;

        string filePath;
        string[] dataFile;

        public frm()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            List_Medici = new Registro();
            List_Patologie = new List<Patologia>();
            List_Specializzazioni = new List<Specializzazione>();
            List_Pazienti = new Registro();
            List_Appuntamenti = new List<Appuntamento>();

            Nomi_Medici = new List<string>();
            Nomi_Pazienti = new List<string>();

            Loader();
            BindData();
        }

        public void Loader()
        {
            filePath = @"..\..\bin\Data\patologie.csv";
            dataFile = File.ReadAllLines(filePath);

            foreach (var line in dataFile)
            {
                string[] data = line.Split(';');
                if (data[1] != "nome")
                {
                    List_Patologie.Add(new Patologia(data[0], data[1]));
                }
            }

            filePath = @"..\..\bin\Data\specializzazioni.csv";
            dataFile = File.ReadAllLines(filePath);

            foreach (var line in dataFile)
            {
                string[] data = line.Split(';');
                if (data[1] != "nome")
                {
                    List_Specializzazioni.Add(new Specializzazione(data[0], data[1]));
                }
            }

            filePath = @"..\..\bin\Data\medici.csv";
            dataFile = File.ReadAllLines(filePath);

            foreach (var line in dataFile)
            {
                string[] data = line.Split(';');
                if (data[0] != "nome")
                {
                    List_Medici.Add(new Medico(data[3], data[0], data[1]));
                    Nomi_Medici.Add(data[1] + " " + data[0]);
                }
            }

            filePath = @"..\..\bin\Data\pazienti.csv";
            dataFile = File.ReadAllLines(filePath);

            foreach (var line in dataFile)
            {
                string[] data = line.Split(';');
                if (data[0] != "nome")
                {
                    List_Pazienti.Add(new Paziente(data[6], data[0], data[1]));
                    Nomi_Pazienti.Add(data[1] + " " + data[0]);
                }
            }

            filePath = @"..\..\bin\Data\appuntamenti.csv";
            dataFile = File.ReadAllLines(filePath);

            foreach (var line in dataFile)
            {
                string[] data = line.Split(';');
                if (data[0] != "data")
                {
                    List_Appuntamenti.Add(new Appuntamento(Convert.ToDateTime(data[0]), List_Pazienti.FindId(data[1]), List_Medici.FindId(data[2])));
                }
            }
        }

        public void BindData()
        {
            dgwMedici.DataSource = null;
            dgwMedici.DataSource = List_Medici.Lista;

            dgwPatologie.DataSource = null;
            dgwPatologie.DataSource = List_Patologie;

            dgwSpecializzazioni.DataSource = null;
            dgwSpecializzazioni.DataSource = List_Specializzazioni;

            dgwPazienti.DataSource = null;
            dgwPazienti.DataSource = List_Pazienti.Lista;

            dgwAppuntamenti.DataSource = null;
            dgwAppuntamenti.DataSource = List_Appuntamenti;

            cmbMedico.DataSource = null;
            cmbMedico.DataSource = Nomi_Medici;

            cmbPaziente.DataSource = null;
            cmbPaziente.DataSource = Nomi_Pazienti;
        }

        private void btnMedici_Click(object sender, EventArgs e)
        {
            tbp1.Show();
            tbc.SelectedIndex = 0;
        }

        private void btnPatologie_Click(object sender, EventArgs e)
        {
            tbp2.Show();
            tbc.SelectedIndex = 1;
        }

        private void btnSpecializzazioni_Click(object sender, EventArgs e)
        {
            tbp3.Show();
            tbc.SelectedIndex = 2;
        }

        private void btnPazienti_Click(object sender, EventArgs e)
        {
            tbp4.Show();
            tbc.SelectedIndex = 3;
        }

        private void btnAppuntamenti_Click(object sender, EventArgs e)
        {
            tbp5.Show();
            tbc.SelectedIndex = 4;
        }

        private void ckbpData_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbData.Checked == true)
            {
                cmbData.Enabled = true;
            }
            else if (ckbData.Checked == false)
            {
                cmbData.Enabled = false;
            }
        }

        private void ckbMedico_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMedico.Checked == true)
            {
                cmbMedico.Enabled = true;
            }
            else if (ckbMedico.Checked == false)
            {
                cmbMedico.Enabled = false;
            }
        }

        private void ckbPaziente_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPaziente.Checked == true)
            {
                cmbPaziente.Enabled = true;
            }
            else if (ckbPaziente.Checked == false)
            {
                cmbPaziente.Enabled = false;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DateTime Data = DateTime.Now;
            string Medico = "";
            string Paziente = "";

            int ctr = 0;
            int counter = 0;

            List<Appuntamento> NewList_Appuntamenti = new List<Appuntamento>();

            if (ckbData.Checked == true)
            {
                Data = cmbData.Value;
                counter++;
            }
            if (ckbMedico.Checked == true)
            {
                Medico = cmbMedico.Text;
                counter++;
            }
            if (ckbPaziente.Checked == true)
            {
                Paziente = cmbPaziente.Text;
                counter++;
            }
            
            foreach(Appuntamento appuntamento in List_Appuntamenti)
            {
                if (ckbData.Checked == true && Data.Year == appuntamento.Data.Year && Data.Month == appuntamento.Data.Month && Data.Day == appuntamento.Data.Day)
                {
                    ctr++;
                }
                if (ckbMedico.Checked == true && Medico == appuntamento.Medico)
                {
                    ctr++;
                }
                if (ckbPaziente.Checked == true && Paziente == appuntamento.Paziente)
                {
                    ctr++;
                }
                if (ctr == counter)
                {
                    NewList_Appuntamenti.Add(appuntamento);
                }

                ctr = 0;
            }
            

            dgwAppuntamenti.DataSource = null;
            dgwAppuntamenti.DataSource = NewList_Appuntamenti;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbData.Value = DateTime.Now;
            cmbData.Enabled = false;
            cmbMedico.Enabled = false;
            cmbPaziente.Enabled = false;

            ckbData.Checked = false;
            ckbMedico.Checked = false;
            ckbPaziente.Checked = false;

            BindData();
        }
    }
}
