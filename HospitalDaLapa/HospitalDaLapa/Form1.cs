using System;
using System.Windows.Forms;

namespace HospitalDaLapa
{
    public partial class frmHL : Form
    {
        //Variveis que armazenarão o valor de cada serviço
        double consulta = 0, internacao = 0, exames = 0, pcnt = 1;
        bool defendaOSus;

        //Metodo para caucular a soma dos serviços
        //sempre é chamado dentro de AtualizarValores
        double CalcularTotalServ()
        {
            return consulta + internacao + exames;
        }

        //Metodo para atualizar os valores a cada vez que algo muda
        //Todos os eventos que possam alterar o valor de alguma label carrega esse metodo
        void AtualizarValores()
        {
            lblPgtValorTotalServ.Text = "R$ " + CalcularTotalServ();
            lblPgtValorTotalAPagar.Text = "R$ " + (CalcularTotalServ() * pcnt);
            lblPgtValorTotalPlanoConvenio.Text = "R$ " + (CalcularTotalServ() * pcnt);
        }

        //metodo para atualizar a visibilidade das labels toda vez que o plano for trocado
        void AtualizarVisibilidade()
        {
            lblPgtValorTotalServ.Visible = true;
            if (rdPlanoParticular.Checked)
            {
                lblPgtValorTotalPlanoConvenio.Visible = false;
                lblPgtTotalPlanoConvenio.Visible = false;
                rdPgtPrazo.Enabled = true;
                rdPgtVista.Enabled = true;
            }
            else
            {
                lblPgtTotalAPagar.Visible = false;
                lblPgtValorTotalAPagar.Visible = false;
                rdPgtPrazo.Enabled = false;
                rdPgtVista.Enabled = false;
                rdPgtVista.Checked = false;
                rdPgtPrazo.Checked = false;
                lblFormPgtTotalFormaPgt.Visible = false;
            }
        }

        public frmHL()
        {
            InitializeComponent();
        }


        //Programação dos checkBox
        //Ao alterar a Checkbox, o valor das variveis são alterados
        private void cbConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConsulta.Checked)
            {
                lblServConsulta.Visible = true;
                consulta = 75;
            }
            else
            {
                lblServConsulta.Visible = false;
                consulta = 0;
            }
            AtualizarValores();
        }

        private void cbInternacao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInternacao.Checked)
            {
                lblServInternacao.Visible = true;
                internacao = 510;
            }
            else
            {
                lblServInternacao.Visible = false;
                internacao = 0;
            }
            AtualizarValores();
        }

        private void cbExames_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExames.Checked)
            {
                lblServExames.Visible = true;
                exames = 150;
            }
            else
            {
                lblServExames.Visible = false;
                exames = 0;
            }
            AtualizarValores();
        }





        //RadioButtons de Planos de Saúde
        private void rdPlanoSUS_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPlanoSUS.Checked)
            {
                pcnt = 1.075;
                defendaOSus = true;
                lblPgtTotalPlanoConvenio.Text = "Cobrar do governo";
            }
            AtualizarValores();
            AtualizarVisibilidade();
        }

        private void rdPlanoParticular_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarValores();
            AtualizarVisibilidade();
        }

        private void rdPlanoPrivado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPlanoPrivado.Checked)
            {
                pcnt = 1.375;
                lblPgtTotalPlanoConvenio.Text = "Cobrar do plano de saúde";
            }
            AtualizarValores();
            AtualizarVisibilidade();
        }





        //RadioButtons de forma de pagamento
        private void rdPgtVista_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPgtVista.Checked)
            {
                pcnt = 0.85;
                lblFormPgtTotalFormaPgt.Text = "Desconto de 15%";
            }
            AtualizarValores();
            lblFormPgtTotalFormaPgt.Visible = true;
        }

        private void rdPgtPrazo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPgtPrazo.Checked)
            {
                pcnt = 1.15;
                lblFormPgtTotalFormaPgt.Text = "Acréscimo de 15%";
            }
            AtualizarValores();
            lblFormPgtTotalFormaPgt.Visible = true;
        }




        //Programação dos botões
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rdPlanoParticular.Checked && rdPgtVista.Enabled)
            {
                lblPgtValorTotalAPagar.Visible = true;
                lblPgtTotalAPagar.Visible = true;
            }
            if (rdPlanoPrivado.Checked || rdPlanoSUS.Checked)
            {
                lblPgtValorTotalPlanoConvenio.Visible = true;
                lblPgtTotalPlanoConvenio.Visible = true;
            }
            AtualizarValores();
        }


        private void bntEncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
            
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdPgtPrazo.Checked = false;
            rdPgtVista.Checked = false;
            rdPlanoParticular.Checked = false;
            rdPlanoPrivado.Checked = false;
            rdPlanoSUS.Checked = false;
            cbConsulta.Checked = false;
            cbExames.Checked = false;
            cbInternacao.Checked = false;
            tbPaciente.Clear();
            tbTel.Clear();
            lblPgtValorTotalServ.Visible = false;
            lblPgtValorTotalPlanoConvenio.Visible = false;
            lblPgtTotalPlanoConvenio.Visible = false;
        }
    }
}