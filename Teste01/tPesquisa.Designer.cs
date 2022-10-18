namespace FormApp
{
    partial class tPesquisa
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
            this.components = new System.ComponentModel.Container();
            this.sQLInteractionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sQLInteractionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sQLInteractionBindingSource
            // 
            this.sQLInteractionBindingSource.DataSource = typeof(ClassLibrary1.SQL.SQLInteraction);
            // 
            // tPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "tPesquisa";
            this.Text = "tPesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.sQLInteractionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource sQLInteractionBindingSource;
    }
}