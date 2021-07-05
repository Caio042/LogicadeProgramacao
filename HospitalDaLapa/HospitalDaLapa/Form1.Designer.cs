
namespace HospitalDaLapa
{
    partial class frmHL
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHL));
            this.gpPgt = new System.Windows.Forms.GroupBox();
            this.gpFormaDePgt = new System.Windows.Forms.GroupBox();
            this.rdPgtVista = new System.Windows.Forms.RadioButton();
            this.rdPgtPrazo = new System.Windows.Forms.RadioButton();
            this.lblFormPgtTotalFormaPgt = new System.Windows.Forms.Label();
            this.lblPgtTotalServ = new System.Windows.Forms.Label();
            this.lblPgtValorTotalServ = new System.Windows.Forms.Label();
            this.lblPgtTotalAPagar = new System.Windows.Forms.Label();
            this.lblPgtValorTotalAPagar = new System.Windows.Forms.Label();
            this.lblPgtTotalPlanoConvenio = new System.Windows.Forms.Label();
            this.lblPgtValorTotalPlanoConvenio = new System.Windows.Forms.Label();
            this.gpOperacoes = new System.Windows.Forms.GroupBox();
            this.bntEncerrar = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpServicos = new System.Windows.Forms.GroupBox();
            this.cbExames = new System.Windows.Forms.CheckBox();
            this.cbConsulta = new System.Windows.Forms.CheckBox();
            this.cbInternacao = new System.Windows.Forms.CheckBox();
            this.lblServConsulta = new System.Windows.Forms.Label();
            this.lblServInternacao = new System.Windows.Forms.Label();
            this.lblServExames = new System.Windows.Forms.Label();
            this.gpPlano = new System.Windows.Forms.GroupBox();
            this.rdPlanoPrivado = new System.Windows.Forms.RadioButton();
            this.rdPlanoParticular = new System.Windows.Forms.RadioButton();
            this.rdPlanoSUS = new System.Windows.Forms.RadioButton();
            this.lblNomeHospital = new System.Windows.Forms.Label();
            this.pbLogo2 = new System.Windows.Forms.PictureBox();
            this.pbLogo1 = new System.Windows.Forms.PictureBox();
            this.gpDadosDoPaciente = new System.Windows.Forms.GroupBox();
            this.lblDadosTel = new System.Windows.Forms.Label();
            this.lblDadosPaciente = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbPaciente = new System.Windows.Forms.TextBox();
            this.gpCreditos = new System.Windows.Forms.GroupBox();
            this.lblCreditosLogo = new System.Windows.Forms.Label();
            this.lblCreditosIcone = new System.Windows.Forms.Label();
            this.lblCreditosDev = new System.Windows.Forms.Label();
            this.gpPgt.SuspendLayout();
            this.gpFormaDePgt.SuspendLayout();
            this.gpOperacoes.SuspendLayout();
            this.gpServicos.SuspendLayout();
            this.gpPlano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).BeginInit();
            this.gpDadosDoPaciente.SuspendLayout();
            this.gpCreditos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpPgt
            // 
            this.gpPgt.Controls.Add(this.gpFormaDePgt);
            this.gpPgt.Controls.Add(this.lblPgtTotalServ);
            this.gpPgt.Controls.Add(this.lblPgtValorTotalServ);
            this.gpPgt.Controls.Add(this.lblPgtTotalAPagar);
            this.gpPgt.Controls.Add(this.lblPgtValorTotalAPagar);
            this.gpPgt.Controls.Add(this.lblPgtTotalPlanoConvenio);
            this.gpPgt.Controls.Add(this.lblPgtValorTotalPlanoConvenio);
            this.gpPgt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPgt.Location = new System.Drawing.Point(447, 202);
            this.gpPgt.Name = "gpPgt";
            this.gpPgt.Size = new System.Drawing.Size(398, 236);
            this.gpPgt.TabIndex = 40;
            this.gpPgt.TabStop = false;
            this.gpPgt.Text = "Pagamento";
            // 
            // gpFormaDePgt
            // 
            this.gpFormaDePgt.Controls.Add(this.rdPgtVista);
            this.gpFormaDePgt.Controls.Add(this.rdPgtPrazo);
            this.gpFormaDePgt.Controls.Add(this.lblFormPgtTotalFormaPgt);
            this.gpFormaDePgt.Location = new System.Drawing.Point(24, 86);
            this.gpFormaDePgt.Name = "gpFormaDePgt";
            this.gpFormaDePgt.Size = new System.Drawing.Size(358, 46);
            this.gpFormaDePgt.TabIndex = 31;
            this.gpFormaDePgt.TabStop = false;
            this.gpFormaDePgt.Text = "Forma de Pagamento";
            // 
            // rdPgtVista
            // 
            this.rdPgtVista.AutoSize = true;
            this.rdPgtVista.Enabled = false;
            this.rdPgtVista.Location = new System.Drawing.Point(6, 19);
            this.rdPgtVista.Name = "rdPgtVista";
            this.rdPgtVista.Size = new System.Drawing.Size(73, 25);
            this.rdPgtVista.TabIndex = 19;
            this.rdPgtVista.TabStop = true;
            this.rdPgtVista.Text = "à vista";
            this.rdPgtVista.UseVisualStyleBackColor = true;
            this.rdPgtVista.CheckedChanged += new System.EventHandler(this.rdPgtVista_CheckedChanged);
            // 
            // rdPgtPrazo
            // 
            this.rdPgtPrazo.AutoSize = true;
            this.rdPgtPrazo.Enabled = false;
            this.rdPgtPrazo.Location = new System.Drawing.Point(124, 17);
            this.rdPgtPrazo.Name = "rdPgtPrazo";
            this.rdPgtPrazo.Size = new System.Drawing.Size(79, 25);
            this.rdPgtPrazo.TabIndex = 20;
            this.rdPgtPrazo.TabStop = true;
            this.rdPgtPrazo.Text = "à prazo";
            this.rdPgtPrazo.UseVisualStyleBackColor = true;
            this.rdPgtPrazo.CheckedChanged += new System.EventHandler(this.rdPgtPrazo_CheckedChanged);
            // 
            // lblFormPgtTotalFormaPgt
            // 
            this.lblFormPgtTotalFormaPgt.AutoSize = true;
            this.lblFormPgtTotalFormaPgt.Location = new System.Drawing.Point(217, 19);
            this.lblFormPgtTotalFormaPgt.Name = "lblFormPgtTotalFormaPgt";
            this.lblFormPgtTotalFormaPgt.Size = new System.Drawing.Size(128, 21);
            this.lblFormPgtTotalFormaPgt.TabIndex = 22;
            this.lblFormPgtTotalFormaPgt.Text = "lblTotalFormaPgt";
            this.lblFormPgtTotalFormaPgt.UseMnemonic = false;
            this.lblFormPgtTotalFormaPgt.Visible = false;
            // 
            // lblPgtTotalServ
            // 
            this.lblPgtTotalServ.AutoSize = true;
            this.lblPgtTotalServ.Location = new System.Drawing.Point(21, 31);
            this.lblPgtTotalServ.Name = "lblPgtTotalServ";
            this.lblPgtTotalServ.Size = new System.Drawing.Size(165, 21);
            this.lblPgtTotalServ.TabIndex = 17;
            this.lblPgtTotalServ.Text = "Valor total dos serviços";
            // 
            // lblPgtValorTotalServ
            // 
            this.lblPgtValorTotalServ.AutoSize = true;
            this.lblPgtValorTotalServ.Location = new System.Drawing.Point(313, 31);
            this.lblPgtValorTotalServ.Name = "lblPgtValorTotalServ";
            this.lblPgtValorTotalServ.Size = new System.Drawing.Size(64, 21);
            this.lblPgtValorTotalServ.TabIndex = 18;
            this.lblPgtValorTotalServ.Text = "R$ 0,00";
            this.lblPgtValorTotalServ.Visible = false;
            // 
            // lblPgtTotalAPagar
            // 
            this.lblPgtTotalAPagar.AutoSize = true;
            this.lblPgtTotalAPagar.Location = new System.Drawing.Point(21, 144);
            this.lblPgtTotalAPagar.Name = "lblPgtTotalAPagar";
            this.lblPgtTotalAPagar.Size = new System.Drawing.Size(101, 21);
            this.lblPgtTotalAPagar.TabIndex = 23;
            this.lblPgtTotalAPagar.Text = "Total a pagar";
            this.lblPgtTotalAPagar.Visible = false;
            // 
            // lblPgtValorTotalAPagar
            // 
            this.lblPgtValorTotalAPagar.AutoSize = true;
            this.lblPgtValorTotalAPagar.Location = new System.Drawing.Point(258, 144);
            this.lblPgtValorTotalAPagar.Name = "lblPgtValorTotalAPagar";
            this.lblPgtValorTotalAPagar.Size = new System.Drawing.Size(147, 21);
            this.lblPgtValorTotalAPagar.TabIndex = 24;
            this.lblPgtValorTotalAPagar.Text = "lblValorTotalAPagar";
            this.lblPgtValorTotalAPagar.Visible = false;
            // 
            // lblPgtTotalPlanoConvenio
            // 
            this.lblPgtTotalPlanoConvenio.AutoSize = true;
            this.lblPgtTotalPlanoConvenio.Location = new System.Drawing.Point(21, 178);
            this.lblPgtTotalPlanoConvenio.Name = "lblPgtTotalPlanoConvenio";
            this.lblPgtTotalPlanoConvenio.Size = new System.Drawing.Size(247, 21);
            this.lblPgtTotalPlanoConvenio.TabIndex = 26;
            this.lblPgtTotalPlanoConvenio.Text = "Cobrar do governo/plano de saúde";
            this.lblPgtTotalPlanoConvenio.Visible = false;
            // 
            // lblPgtValorTotalPlanoConvenio
            // 
            this.lblPgtValorTotalPlanoConvenio.AutoSize = true;
            this.lblPgtValorTotalPlanoConvenio.Location = new System.Drawing.Point(21, 203);
            this.lblPgtValorTotalPlanoConvenio.Name = "lblPgtValorTotalPlanoConvenio";
            this.lblPgtValorTotalPlanoConvenio.Size = new System.Drawing.Size(198, 21);
            this.lblPgtValorTotalPlanoConvenio.TabIndex = 25;
            this.lblPgtValorTotalPlanoConvenio.Text = "lblValorTotalPlanoConvenio";
            this.lblPgtValorTotalPlanoConvenio.Visible = false;
            // 
            // gpOperacoes
            // 
            this.gpOperacoes.Controls.Add(this.bntEncerrar);
            this.gpOperacoes.Controls.Add(this.btnCalculadora);
            this.gpOperacoes.Controls.Add(this.btnCalcular);
            this.gpOperacoes.Controls.Add(this.btnLimpar);
            this.gpOperacoes.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpOperacoes.Location = new System.Drawing.Point(72, 454);
            this.gpOperacoes.Name = "gpOperacoes";
            this.gpOperacoes.Size = new System.Drawing.Size(773, 59);
            this.gpOperacoes.TabIndex = 39;
            this.gpOperacoes.TabStop = false;
            this.gpOperacoes.Text = "Operações";
            // 
            // bntEncerrar
            // 
            this.bntEncerrar.Location = new System.Drawing.Point(620, 22);
            this.bntEncerrar.Name = "bntEncerrar";
            this.bntEncerrar.Size = new System.Drawing.Size(132, 31);
            this.bntEncerrar.TabIndex = 13;
            this.bntEncerrar.Text = "&Encerrar - Alt + E";
            this.bntEncerrar.UseVisualStyleBackColor = true;
            this.bntEncerrar.Click += new System.EventHandler(this.bntEncerrar_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Location = new System.Drawing.Point(400, 22);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(174, 31);
            this.btnCalculadora.TabIndex = 12;
            this.btnCalculadora.Text = "&Calculadora - alt + C";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(208, 22);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(146, 31);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "C&alcular - Alt + A";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(25, 22);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 31);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar - Alt + L";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gpServicos
            // 
            this.gpServicos.Controls.Add(this.cbExames);
            this.gpServicos.Controls.Add(this.cbConsulta);
            this.gpServicos.Controls.Add(this.cbInternacao);
            this.gpServicos.Controls.Add(this.lblServConsulta);
            this.gpServicos.Controls.Add(this.lblServInternacao);
            this.gpServicos.Controls.Add(this.lblServExames);
            this.gpServicos.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpServicos.Location = new System.Drawing.Point(72, 269);
            this.gpServicos.Name = "gpServicos";
            this.gpServicos.Size = new System.Drawing.Size(315, 169);
            this.gpServicos.TabIndex = 38;
            this.gpServicos.TabStop = false;
            this.gpServicos.Text = "Serviços";
            // 
            // cbExames
            // 
            this.cbExames.AutoSize = true;
            this.cbExames.Location = new System.Drawing.Point(6, 107);
            this.cbExames.Name = "cbExames";
            this.cbExames.Size = new System.Drawing.Size(177, 25);
            this.cbExames.TabIndex = 9;
            this.cbExames.Text = "Exames Laboratoriais";
            this.cbExames.UseVisualStyleBackColor = true;
            this.cbExames.CheckedChanged += new System.EventHandler(this.cbExames_CheckedChanged);
            // 
            // cbConsulta
            // 
            this.cbConsulta.AutoSize = true;
            this.cbConsulta.Location = new System.Drawing.Point(6, 25);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(89, 25);
            this.cbConsulta.TabIndex = 7;
            this.cbConsulta.Text = "Consulta";
            this.cbConsulta.UseVisualStyleBackColor = true;
            this.cbConsulta.CheckedChanged += new System.EventHandler(this.cbConsulta_CheckedChanged);
            // 
            // cbInternacao
            // 
            this.cbInternacao.AutoSize = true;
            this.cbInternacao.Location = new System.Drawing.Point(6, 63);
            this.cbInternacao.Name = "cbInternacao";
            this.cbInternacao.Size = new System.Drawing.Size(102, 25);
            this.cbInternacao.TabIndex = 8;
            this.cbInternacao.Text = "Internação";
            this.cbInternacao.UseVisualStyleBackColor = true;
            this.cbInternacao.CheckedChanged += new System.EventHandler(this.cbInternacao_CheckedChanged);
            // 
            // lblServConsulta
            // 
            this.lblServConsulta.AutoSize = true;
            this.lblServConsulta.Location = new System.Drawing.Point(204, 26);
            this.lblServConsulta.Name = "lblServConsulta";
            this.lblServConsulta.Size = new System.Drawing.Size(73, 21);
            this.lblServConsulta.TabIndex = 14;
            this.lblServConsulta.Text = "R$ 75,00";
            this.lblServConsulta.Visible = false;
            // 
            // lblServInternacao
            // 
            this.lblServInternacao.AutoSize = true;
            this.lblServInternacao.Location = new System.Drawing.Point(204, 67);
            this.lblServInternacao.Name = "lblServInternacao";
            this.lblServInternacao.Size = new System.Drawing.Size(82, 21);
            this.lblServInternacao.TabIndex = 15;
            this.lblServInternacao.Text = "R$ 510,00";
            this.lblServInternacao.Visible = false;
            // 
            // lblServExames
            // 
            this.lblServExames.AutoSize = true;
            this.lblServExames.Location = new System.Drawing.Point(204, 108);
            this.lblServExames.Name = "lblServExames";
            this.lblServExames.Size = new System.Drawing.Size(82, 21);
            this.lblServExames.TabIndex = 16;
            this.lblServExames.Text = "R$ 150,00";
            this.lblServExames.Visible = false;
            // 
            // gpPlano
            // 
            this.gpPlano.Controls.Add(this.rdPlanoPrivado);
            this.gpPlano.Controls.Add(this.rdPlanoParticular);
            this.gpPlano.Controls.Add(this.rdPlanoSUS);
            this.gpPlano.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPlano.Location = new System.Drawing.Point(72, 202);
            this.gpPlano.Name = "gpPlano";
            this.gpPlano.Size = new System.Drawing.Size(315, 52);
            this.gpPlano.TabIndex = 37;
            this.gpPlano.TabStop = false;
            this.gpPlano.Text = "Plano de Saúde";
            // 
            // rdPlanoPrivado
            // 
            this.rdPlanoPrivado.AutoSize = true;
            this.rdPlanoPrivado.Location = new System.Drawing.Point(208, 19);
            this.rdPlanoPrivado.Name = "rdPlanoPrivado";
            this.rdPlanoPrivado.Size = new System.Drawing.Size(80, 25);
            this.rdPlanoPrivado.TabIndex = 2;
            this.rdPlanoPrivado.TabStop = true;
            this.rdPlanoPrivado.Text = "Privado";
            this.rdPlanoPrivado.UseVisualStyleBackColor = true;
            this.rdPlanoPrivado.CheckedChanged += new System.EventHandler(this.rdPlanoPrivado_CheckedChanged);
            // 
            // rdPlanoParticular
            // 
            this.rdPlanoParticular.AutoSize = true;
            this.rdPlanoParticular.Location = new System.Drawing.Point(88, 19);
            this.rdPlanoParticular.Name = "rdPlanoParticular";
            this.rdPlanoParticular.Size = new System.Drawing.Size(95, 25);
            this.rdPlanoParticular.TabIndex = 1;
            this.rdPlanoParticular.TabStop = true;
            this.rdPlanoParticular.Text = "Particular";
            this.rdPlanoParticular.UseVisualStyleBackColor = true;
            this.rdPlanoParticular.CheckedChanged += new System.EventHandler(this.rdPlanoParticular_CheckedChanged);
            // 
            // rdPlanoSUS
            // 
            this.rdPlanoSUS.AutoSize = true;
            this.rdPlanoSUS.Location = new System.Drawing.Point(6, 19);
            this.rdPlanoSUS.Name = "rdPlanoSUS";
            this.rdPlanoSUS.Size = new System.Drawing.Size(56, 25);
            this.rdPlanoSUS.TabIndex = 0;
            this.rdPlanoSUS.TabStop = true;
            this.rdPlanoSUS.Text = "SUS";
            this.rdPlanoSUS.UseVisualStyleBackColor = true;
            this.rdPlanoSUS.CheckedChanged += new System.EventHandler(this.rdPlanoSUS_CheckedChanged);
            // 
            // lblNomeHospital
            // 
            this.lblNomeHospital.AutoSize = true;
            this.lblNomeHospital.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeHospital.Location = new System.Drawing.Point(153, 38);
            this.lblNomeHospital.Name = "lblNomeHospital";
            this.lblNomeHospital.Size = new System.Drawing.Size(611, 47);
            this.lblNomeHospital.TabIndex = 35;
            this.lblNomeHospital.Text = "Hospital Nossa Senhora da Lapa";
            // 
            // pbLogo2
            // 
            this.pbLogo2.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo2.Image")));
            this.pbLogo2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLogo2.InitialImage")));
            this.pbLogo2.Location = new System.Drawing.Point(770, 10);
            this.pbLogo2.Name = "pbLogo2";
            this.pbLogo2.Size = new System.Drawing.Size(75, 75);
            this.pbLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo2.TabIndex = 34;
            this.pbLogo2.TabStop = false;
            // 
            // pbLogo1
            // 
            this.pbLogo1.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo1.Image")));
            this.pbLogo1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLogo1.InitialImage")));
            this.pbLogo1.Location = new System.Drawing.Point(72, 10);
            this.pbLogo1.Name = "pbLogo1";
            this.pbLogo1.Size = new System.Drawing.Size(75, 75);
            this.pbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo1.TabIndex = 33;
            this.pbLogo1.TabStop = false;
            // 
            // gpDadosDoPaciente
            // 
            this.gpDadosDoPaciente.Controls.Add(this.lblDadosTel);
            this.gpDadosDoPaciente.Controls.Add(this.lblDadosPaciente);
            this.gpDadosDoPaciente.Controls.Add(this.tbTel);
            this.gpDadosDoPaciente.Controls.Add(this.tbPaciente);
            this.gpDadosDoPaciente.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDadosDoPaciente.Location = new System.Drawing.Point(72, 105);
            this.gpDadosDoPaciente.Name = "gpDadosDoPaciente";
            this.gpDadosDoPaciente.Size = new System.Drawing.Size(773, 91);
            this.gpDadosDoPaciente.TabIndex = 36;
            this.gpDadosDoPaciente.TabStop = false;
            this.gpDadosDoPaciente.Text = "Dados do Paciente";
            // 
            // lblDadosTel
            // 
            this.lblDadosTel.AutoSize = true;
            this.lblDadosTel.Location = new System.Drawing.Point(8, 56);
            this.lblDadosTel.Name = "lblDadosTel";
            this.lblDadosTel.Size = new System.Drawing.Size(68, 21);
            this.lblDadosTel.TabIndex = 4;
            this.lblDadosTel.Text = "Telefone";
            // 
            // lblDadosPaciente
            // 
            this.lblDadosPaciente.AutoSize = true;
            this.lblDadosPaciente.Location = new System.Drawing.Point(8, 24);
            this.lblDadosPaciente.Name = "lblDadosPaciente";
            this.lblDadosPaciente.Size = new System.Drawing.Size(70, 21);
            this.lblDadosPaciente.TabIndex = 3;
            this.lblDadosPaciente.Text = "Paciente";
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(88, 51);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(645, 26);
            this.tbTel.TabIndex = 5;
            // 
            // tbPaciente
            // 
            this.tbPaciente.Location = new System.Drawing.Point(88, 19);
            this.tbPaciente.Name = "tbPaciente";
            this.tbPaciente.Size = new System.Drawing.Size(645, 26);
            this.tbPaciente.TabIndex = 6;
            // 
            // gpCreditos
            // 
            this.gpCreditos.Controls.Add(this.lblCreditosLogo);
            this.gpCreditos.Controls.Add(this.lblCreditosIcone);
            this.gpCreditos.Controls.Add(this.lblCreditosDev);
            this.gpCreditos.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCreditos.Location = new System.Drawing.Point(72, 520);
            this.gpCreditos.Name = "gpCreditos";
            this.gpCreditos.Size = new System.Drawing.Size(773, 52);
            this.gpCreditos.TabIndex = 41;
            this.gpCreditos.TabStop = false;
            this.gpCreditos.Text = "Créditos";
            // 
            // lblCreditosLogo
            // 
            this.lblCreditosLogo.AutoSize = true;
            this.lblCreditosLogo.Location = new System.Drawing.Point(534, 16);
            this.lblCreditosLogo.Name = "lblCreditosLogo";
            this.lblCreditosLogo.Size = new System.Drawing.Size(223, 16);
            this.lblCreditosLogo.TabIndex = 2;
            this.lblCreditosLogo.Text = "Logo: Gator Studios, lincença CC Atribution";
            // 
            // lblCreditosIcone
            // 
            this.lblCreditosIcone.AutoSize = true;
            this.lblCreditosIcone.Location = new System.Drawing.Point(262, 16);
            this.lblCreditosIcone.Name = "lblCreditosIcone";
            this.lblCreditosIcone.Size = new System.Drawing.Size(244, 16);
            this.lblCreditosIcone.TabIndex = 1;
            this.lblCreditosIcone.Text = "Ícone: Vincent Le Moign, lincença CC Atribution";
            // 
            // lblCreditosDev
            // 
            this.lblCreditosDev.AutoSize = true;
            this.lblCreditosDev.Location = new System.Drawing.Point(6, 16);
            this.lblCreditosDev.Name = "lblCreditosDev";
            this.lblCreditosDev.Size = new System.Drawing.Size(232, 16);
            this.lblCreditosDev.TabIndex = 0;
            this.lblCreditosDev.Text = "Desenvolvimento: Caio Henrique Gomes Lima";
            // 
            // frmHL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 592);
            this.Controls.Add(this.gpCreditos);
            this.Controls.Add(this.gpPgt);
            this.Controls.Add(this.gpOperacoes);
            this.Controls.Add(this.gpServicos);
            this.Controls.Add(this.gpPlano);
            this.Controls.Add(this.lblNomeHospital);
            this.Controls.Add(this.pbLogo2);
            this.Controls.Add(this.pbLogo1);
            this.Controls.Add(this.gpDadosDoPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHL";
            this.Text = "Hospital da Lapa";
            this.gpPgt.ResumeLayout(false);
            this.gpPgt.PerformLayout();
            this.gpFormaDePgt.ResumeLayout(false);
            this.gpFormaDePgt.PerformLayout();
            this.gpOperacoes.ResumeLayout(false);
            this.gpServicos.ResumeLayout(false);
            this.gpServicos.PerformLayout();
            this.gpPlano.ResumeLayout(false);
            this.gpPlano.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).EndInit();
            this.gpDadosDoPaciente.ResumeLayout(false);
            this.gpDadosDoPaciente.PerformLayout();
            this.gpCreditos.ResumeLayout(false);
            this.gpCreditos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPgt;
        private System.Windows.Forms.GroupBox gpFormaDePgt;
        private System.Windows.Forms.RadioButton rdPgtVista;
        private System.Windows.Forms.RadioButton rdPgtPrazo;
        private System.Windows.Forms.Label lblFormPgtTotalFormaPgt;
        private System.Windows.Forms.Label lblPgtTotalServ;
        private System.Windows.Forms.Label lblPgtValorTotalServ;
        private System.Windows.Forms.Label lblPgtTotalAPagar;
        private System.Windows.Forms.Label lblPgtValorTotalAPagar;
        private System.Windows.Forms.Label lblPgtTotalPlanoConvenio;
        private System.Windows.Forms.Label lblPgtValorTotalPlanoConvenio;
        private System.Windows.Forms.GroupBox gpOperacoes;
        private System.Windows.Forms.Button bntEncerrar;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpServicos;
        private System.Windows.Forms.CheckBox cbExames;
        private System.Windows.Forms.CheckBox cbConsulta;
        private System.Windows.Forms.CheckBox cbInternacao;
        private System.Windows.Forms.Label lblServConsulta;
        private System.Windows.Forms.Label lblServInternacao;
        private System.Windows.Forms.Label lblServExames;
        private System.Windows.Forms.GroupBox gpPlano;
        private System.Windows.Forms.RadioButton rdPlanoPrivado;
        private System.Windows.Forms.RadioButton rdPlanoParticular;
        private System.Windows.Forms.RadioButton rdPlanoSUS;
        private System.Windows.Forms.Label lblNomeHospital;
        private System.Windows.Forms.PictureBox pbLogo2;
        private System.Windows.Forms.PictureBox pbLogo1;
        private System.Windows.Forms.GroupBox gpDadosDoPaciente;
        private System.Windows.Forms.Label lblDadosTel;
        private System.Windows.Forms.Label lblDadosPaciente;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbPaciente;
        private System.Windows.Forms.GroupBox gpCreditos;
        private System.Windows.Forms.Label lblCreditosIcone;
        private System.Windows.Forms.Label lblCreditosDev;
        private System.Windows.Forms.Label lblCreditosLogo;
    }
}