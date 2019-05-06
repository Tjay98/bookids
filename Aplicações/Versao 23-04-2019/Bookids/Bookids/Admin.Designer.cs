namespace Bookids
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnAnimadores = new System.Windows.Forms.Button();
            this.btnEscola = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Controls.Add(this.btnEventos);
            this.groupBox1.Controls.Add(this.btnAnimadores);
            this.groupBox1.Controls.Add(this.btnEscola);
            this.groupBox1.Controls.Add(this.btnClientes);
            this.groupBox1.Location = new System.Drawing.Point(148, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 380);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area de Administrador";
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEventos.Location = new System.Drawing.Point(281, 220);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(201, 79);
            this.btnEventos.TabIndex = 7;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = false;
            // 
            // btnAnimadores
            // 
            this.btnAnimadores.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAnimadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnimadores.Location = new System.Drawing.Point(34, 220);
            this.btnAnimadores.Name = "btnAnimadores";
            this.btnAnimadores.Size = new System.Drawing.Size(201, 79);
            this.btnAnimadores.TabIndex = 6;
            this.btnAnimadores.Text = "Animadores";
            this.btnAnimadores.UseVisualStyleBackColor = false;
            // 
            // btnEscola
            // 
            this.btnEscola.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEscola.Location = new System.Drawing.Point(281, 76);
            this.btnEscola.Name = "btnEscola";
            this.btnEscola.Size = new System.Drawing.Size(201, 79);
            this.btnEscola.TabIndex = 5;
            this.btnEscola.Text = "Escolas";
            this.btnEscola.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.Location = new System.Drawing.Point(34, 76);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(201, 79);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin";
            this.Text = "Registo";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnAnimadores;
        private System.Windows.Forms.Button btnEscola;
        private System.Windows.Forms.Button btnClientes;
    }
}