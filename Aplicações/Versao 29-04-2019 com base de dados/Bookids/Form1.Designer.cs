﻿namespace Bookids
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AbrirAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FecharPrograma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AbrirAdmin
            // 
            this.AbrirAdmin.BackColor = System.Drawing.Color.Transparent;
            this.AbrirAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AbrirAdmin.BackgroundImage")));
            this.AbrirAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbrirAdmin.ForeColor = System.Drawing.Color.White;
            this.AbrirAdmin.Location = new System.Drawing.Point(295, 101);
            this.AbrirAdmin.Name = "AbrirAdmin";
            this.AbrirAdmin.Size = new System.Drawing.Size(292, 138);
            this.AbrirAdmin.TabIndex = 0;
            this.AbrirAdmin.Text = "Abrir o Bookids";
            this.AbrirAdmin.UseVisualStyleBackColor = false;
            this.AbrirAdmin.Click += new System.EventHandler(this.AbrirAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(171, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem Vindo à área de gestão do Bookids";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(327, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Programa desenvolvido por: Miguel Mendonça e Rodolfo Barreira";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(515, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alunos da escola IPL - 1º ano TeSP PSI";
            // 
            // FecharPrograma
            // 
            this.FecharPrograma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FecharPrograma.BackgroundImage")));
            this.FecharPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FecharPrograma.ForeColor = System.Drawing.Color.White;
            this.FecharPrograma.Location = new System.Drawing.Point(295, 271);
            this.FecharPrograma.Name = "FecharPrograma";
            this.FecharPrograma.Size = new System.Drawing.Size(292, 138);
            this.FecharPrograma.TabIndex = 4;
            this.FecharPrograma.Text = "Sair do Bookids";
            this.FecharPrograma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 534);
            this.Controls.Add(this.FecharPrograma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AbrirAdmin);
            this.Name = "Form1";
            this.Text = "Bookids";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AbrirAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FecharPrograma;
    }
}

