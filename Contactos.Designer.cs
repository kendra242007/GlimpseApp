
namespace GlimpseApp
{
    partial class Contactos
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
            this.btnvinicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelale = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvinicio
            // 
            this.btnvinicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvinicio.Location = new System.Drawing.Point(19, 23);
            this.btnvinicio.Name = "btnvinicio";
            this.btnvinicio.Size = new System.Drawing.Size(112, 31);
            this.btnvinicio.TabIndex = 0;
            this.btnvinicio.Text = "<- Inicio";
            this.btnvinicio.UseVisualStyleBackColor = true;
            this.btnvinicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos de las creadoras";
            // 
            // labelale
            // 
            this.labelale.AutoSize = true;
            this.labelale.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelale.Location = new System.Drawing.Point(61, 152);
            this.labelale.Name = "labelale";
            this.labelale.Size = new System.Drawing.Size(384, 60);
            this.labelale.TabIndex = 3;
            this.labelale.Text = "Alejandra Jazmin Palencia Mayen 18\r\n\r\npalencia.m.alejandraa.loyola@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "María Fátima Ramírez Zetino 20\r\n\r\nmaria.ramirez.loyola@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 60);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adriana Reyes Hernández 21\r\n\r\nreyes.h.adriana.loyola@gmail.com";
            // 
            // Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvinicio);
            this.Name = "Contactos";
            this.Text = "Contactos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvinicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}