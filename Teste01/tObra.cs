using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ClassLibrary1.SQL;

namespace FormApp
{
    public partial class tObra : Form
    {
        private SQLStringConnector Conexion;
        public tObra()
        {
            InitializeComponent();

            Conexion = new SQLStringConnector();
            DataTable tbl = SQLInteraction.SelectAND(Conexion, "", "obras", null);

            tbId.Text = tbl.Rows[0]["id"].ToString();
            tbNome.Text = tbl.Rows[0]["nome"].ToString();

            VerificaHabilitaBotao(tbl);
        }
        private void bRegistroInicial_Click(object sender, EventArgs e)
        {
            DataTable tbl = SQLInteraction.SelectAND(Conexion, "", "obras", null);

            tbId.Text = tbl.Rows[0]["id"].ToString();
            tbNome.Text = tbl.Rows[0]["nome"].ToString();

            VerificaHabilitaBotao(tbl);
        }
        private void bRegistroAnterior_Click(object sender, EventArgs e)
        {
            DataTable tbl = SQLInteraction.SelectAND(Conexion, "", "obras", null);

            for (int I = 0; I < tbl.Rows.Count; I++)
            {
                if (Convert.ToInt32(tbl.Rows[I]["id"]) == Convert.ToInt32(tbId.Text))
                {
                    tbId.Text = tbl.Rows[I - 1]["id"].ToString();
                    tbNome.Text = tbl.Rows[I - 1]["nome"].ToString();

                    break;
                }
            }
            VerificaHabilitaBotao(tbl);
        }

        private void bRegistroSeguinte_Click(object sender, EventArgs e)
        {
            DataTable tbl = SQLInteraction.SelectAND(Conexion, "", "obras", null);

            for (int I = 0; I < tbl.Rows.Count; I++)
            {
                if (Convert.ToInt32(tbl.Rows[I]["id"]) == Convert.ToInt32(tbId.Text))
                {
                    tbId.Text = tbl.Rows[I + 1]["id"].ToString();
                    tbNome.Text = tbl.Rows[I + 1]["nome"].ToString();

                    break;
                }
            }

            VerificaHabilitaBotao(tbl);
        }

        private void bRegistroFinal_Click(object sender, EventArgs e)
        {
            DataTable tbl = SQLInteraction.SelectAND(Conexion, "", "obras", null);

            tbId.Text = tbl.Rows[tbl.Rows.Count - 1]["id"].ToString();
            tbNome.Text = tbl.Rows[tbl.Rows.Count - 1]["nome"].ToString();

            VerificaHabilitaBotao(tbl);
        }

        private void bSalvar_Click(object sender, EventArgs e)
        {
            //SQLInteraction.Update(Conexion, "obras", new List<string> { "id", "nome", "datainicio", "datafinal", "Condambiente" }, new List<string> { tbId.Text, tbNome.Text, DateOnly.Parse(dtDataInicio.Text).ToString(), DateOnly.Parse(dtDataFinal.Text).ToString(), tbCondambiente.Text });
        }


        private void bEdita_Click(object sender, EventArgs e)
        {
            
        }

        private void VerificaHabilitaBotao(DataTable tbl)
        {
            if (tbId.Text == tbl.Rows[0]["id"].ToString())
            {
                if (bRegistroInicial.Enabled)
                    bRegistroInicial.Enabled = false;

                if (bRegistroAnterior.Enabled)
                    bRegistroAnterior.Enabled = false;
            }
            else
            {
                if (!bRegistroInicial.Enabled)
                    bRegistroInicial.Enabled = true;

                if (!bRegistroAnterior.Enabled)
                    bRegistroAnterior.Enabled = true;
            }

            if (tbId.Text == tbl.Rows[tbl.Rows.Count - 1]["id"].ToString())
            {
                if (bRegistroFinal.Enabled)
                    bRegistroFinal.Enabled = false;

                if (bRegistroSeguinte.Enabled)
                    bRegistroSeguinte.Enabled = false;
            }
            else
            {
                if (!bRegistroFinal.Enabled)
                    bRegistroFinal.Enabled = true;

                if (!bRegistroSeguinte.Enabled)
                    bRegistroSeguinte.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (bRegistroFinal.Enabled)
                bRegistroFinal.Enabled = false;

            if (bRegistroSeguinte.Enabled)
                bRegistroSeguinte.Enabled = false;

            if (bRegistroAnterior.Enabled)
                bRegistroAnterior.Enabled = false;

            if (bRegistroInicial.Enabled)
                bRegistroInicial.Enabled = false;

            if (bPesquisar.Enabled)
                bPesquisar.Enabled = false;

            if (bSalvar.Enabled)
                bSalvar.Enabled = false;



            if (!tbId.Enabled)
                tbId.Enabled = true;

            if (!tbNome.Enabled)
                tbNome.Enabled = true;

            if (!dtDataInicio.Enabled)
                dtDataInicio.Enabled = true;

            if (!dtDataFinal.Enabled)
                dtDataFinal.Enabled = true;

        }

        private void bPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}