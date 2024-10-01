
namespace MapaSala.Formularios.Editar
{
    partial class frmEditarSalas
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
            this.TxtNomeSala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumComputadores = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numCadeiras = new System.Windows.Forms.NumericUpDown();
            this.chkIsLab = new System.Windows.Forms.CheckBox();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumComputadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNomeSala
            // 
            this.TxtNomeSala.Location = new System.Drawing.Point(12, 49);
            this.TxtNomeSala.Name = "TxtNomeSala";
            this.TxtNomeSala.Size = new System.Drawing.Size(100, 20);
            this.TxtNomeSala.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome da sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "N de computadores";
            // 
            // NumComputadores
            // 
            this.NumComputadores.Location = new System.Drawing.Point(12, 124);
            this.NumComputadores.Name = "NumComputadores";
            this.NumComputadores.Size = new System.Drawing.Size(120, 20);
            this.NumComputadores.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "N de cadeiras";
            // 
            // numCadeiras
            // 
            this.numCadeiras.Location = new System.Drawing.Point(12, 204);
            this.numCadeiras.Name = "numCadeiras";
            this.numCadeiras.Size = new System.Drawing.Size(120, 20);
            this.numCadeiras.TabIndex = 15;
            // 
            // chkIsLab
            // 
            this.chkIsLab.AutoSize = true;
            this.chkIsLab.Location = new System.Drawing.Point(15, 249);
            this.chkIsLab.Name = "chkIsLab";
            this.chkIsLab.Size = new System.Drawing.Size(85, 17);
            this.chkIsLab.TabIndex = 16;
            this.chkIsLab.Text = "É laboratorio";
            this.chkIsLab.UseVisualStyleBackColor = true;
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Location = new System.Drawing.Point(15, 290);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(77, 17);
            this.chkDisponivel.TabIndex = 17;
            this.chkDisponivel.Text = "Disponível";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 330);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmEditarSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.chkIsLab);
            this.Controls.Add(this.numCadeiras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumComputadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomeSala);
            this.Name = "frmEditarSalas";
            this.Text = "frmEditarSalas";
            ((System.ComponentModel.ISupportInitialize)(this.NumComputadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNomeSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumComputadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCadeiras;
        private System.Windows.Forms.CheckBox chkIsLab;
        private System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.Button btnSalvar;
    }
}