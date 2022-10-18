namespace FormApp
{
    partial class tObra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAdicionar = new System.Windows.Forms.Button();
            this.bPesquisar = new System.Windows.Forms.Button();
            this.bSalvar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bRegistroInicial = new System.Windows.Forms.Button();
            this.bRegistroAnterior = new System.Windows.Forms.Button();
            this.bRegistroFinal = new System.Windows.Forms.Button();
            this.bRegistroSeguinte = new System.Windows.Forms.Button();
            this.lId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lNome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAdicionar
            // 
            this.bAdicionar.Location = new System.Drawing.Point(152, 12);
            this.bAdicionar.Name = "bAdicionar";
            this.bAdicionar.Size = new System.Drawing.Size(28, 29);
            this.bAdicionar.TabIndex = 0;
            this.bAdicionar.Text = "➕";
            this.bAdicionar.UseVisualStyleBackColor = true;
            this.bAdicionar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bPesquisar
            // 
            this.bPesquisar.Location = new System.Drawing.Point(16, 12);
            this.bPesquisar.Name = "bPesquisar";
            this.bPesquisar.Size = new System.Drawing.Size(28, 29);
            this.bPesquisar.TabIndex = 1;
            this.bPesquisar.Text = "🔎";
            this.bPesquisar.UseVisualStyleBackColor = true;
            this.bPesquisar.Click += new System.EventHandler(this.bPesquisar_Click);
            // 
            // bSalvar
            // 
            this.bSalvar.Location = new System.Drawing.Point(50, 12);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Size = new System.Drawing.Size(28, 29);
            this.bSalvar.TabIndex = 2;
            this.bSalvar.Text = "💾";
            this.bSalvar.UseVisualStyleBackColor = true;
            this.bSalvar.Click += new System.EventHandler(this.bSalvar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(84, 12);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(28, 29);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "❌";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bEdita_Click);
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(118, 12);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(28, 29);
            this.bEditar.TabIndex = 4;
            this.bEditar.Text = "✏️";
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bRegistroInicial
            // 
            this.bRegistroInicial.Location = new System.Drawing.Point(229, 12);
            this.bRegistroInicial.Name = "bRegistroInicial";
            this.bRegistroInicial.Size = new System.Drawing.Size(36, 29);
            this.bRegistroInicial.TabIndex = 5;
            this.bRegistroInicial.Text = "|<";
            this.bRegistroInicial.UseVisualStyleBackColor = true;
            this.bRegistroInicial.Click += new System.EventHandler(this.bRegistroInicial_Click);
            // 
            // bRegistroAnterior
            // 
            this.bRegistroAnterior.Location = new System.Drawing.Point(271, 12);
            this.bRegistroAnterior.Name = "bRegistroAnterior";
            this.bRegistroAnterior.Size = new System.Drawing.Size(36, 29);
            this.bRegistroAnterior.TabIndex = 6;
            this.bRegistroAnterior.Text = "<";
            this.bRegistroAnterior.UseVisualStyleBackColor = true;
            this.bRegistroAnterior.Click += new System.EventHandler(this.bRegistroAnterior_Click);
            // 
            // bRegistroFinal
            // 
            this.bRegistroFinal.Location = new System.Drawing.Point(356, 12);
            this.bRegistroFinal.Name = "bRegistroFinal";
            this.bRegistroFinal.Size = new System.Drawing.Size(36, 29);
            this.bRegistroFinal.TabIndex = 8;
            this.bRegistroFinal.Text = ">|";
            this.bRegistroFinal.UseVisualStyleBackColor = true;
            this.bRegistroFinal.Click += new System.EventHandler(this.bRegistroFinal_Click);
            // 
            // bRegistroSeguinte
            // 
            this.bRegistroSeguinte.Location = new System.Drawing.Point(314, 12);
            this.bRegistroSeguinte.Name = "bRegistroSeguinte";
            this.bRegistroSeguinte.Size = new System.Drawing.Size(36, 29);
            this.bRegistroSeguinte.TabIndex = 7;
            this.bRegistroSeguinte.Text = ">";
            this.bRegistroSeguinte.UseVisualStyleBackColor = true;
            this.bRegistroSeguinte.Click += new System.EventHandler(this.bRegistroSeguinte_Click);
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Enabled = false;
            this.lId.Location = new System.Drawing.Point(22, 58);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(22, 20);
            this.lId.TabIndex = 9;
            this.lId.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(50, 55);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(68, 27);
            this.tbId.TabIndex = 10;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(211, 55);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(544, 27);
            this.tbNome.TabIndex = 12;
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Enabled = false;
            this.lNome.Location = new System.Drawing.Point(155, 58);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(50, 20);
            this.lNome.TabIndex = 11;
            this.lNome.Text = "Nome";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 350);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.dtDataFinal);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dtDataInicio);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(9, 45);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(716, 266);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(708, 233);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Condições Ambiente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(6, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(696, 27);
            this.textBox3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(708, 233);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Informações Específicas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFinal.Location = new System.Drawing.Point(336, 12);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(131, 27);
            this.dtDataFinal.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data Final";
            // 
            // dtDataInicio
            // 
            this.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicio.Location = new System.Drawing.Point(96, 12);
            this.dtDataInicio.Name = "dtDataInicio";
            this.dtDataInicio.Size = new System.Drawing.Size(131, 27);
            this.dtDataInicio.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Inicio";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Imagens";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lNome);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.bRegistroFinal);
            this.Controls.Add(this.bRegistroSeguinte);
            this.Controls.Add(this.bRegistroAnterior);
            this.Controls.Add(this.bRegistroInicial);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bSalvar);
            this.Controls.Add(this.bPesquisar);
            this.Controls.Add(this.bAdicionar);
            this.Name = "tObra";
            this.Text = "fObra";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bAdicionar;
        private Button bPesquisar;
        private Button bSalvar;
        private Button bCancelar;
        private Button bEditar;
        private Button bRegistroInicial;
        private Button bRegistroAnterior;
        private Button bRegistroFinal;
        private Button bRegistroSeguinte;
        private Label lId;
        private TextBox tbId;
        private TextBox tbNome;
        private Label lNome;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private DateTimePicker dtDataFinal;
        private Label label4;
        private DateTimePicker dtDataInicio;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox textBox3;
    }
}