namespace Matriz
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnLlenarXRenglón = new System.Windows.Forms.Button();
            this.btnMostrarXRenglón = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarPro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrarXColumna = new System.Windows.Forms.Button();
            this.btnLlenarXColumna = new System.Windows.Forms.Button();
            this.btnInversoRenglón = new System.Windows.Forms.Button();
            this.btnInversoColumna = new System.Windows.Forms.Button();
            this.btnArribaDiagPrinc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDebajoDiagPrinc = new System.Windows.Forms.Button();
            this.btnDiagPrinc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnArribaDiagSec = new System.Windows.Forms.Button();
            this.btnDebajoDiagSec = new System.Windows.Forms.Button();
            this.btnDiagSec = new System.Windows.Forms.Button();
            this.btnRotarXPrincipal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(145, 11);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(57, 28);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(85, 12);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(54, 24);
            this.txtSize.TabIndex = 1;
            // 
            // btnLlenarXRenglón
            // 
            this.btnLlenarXRenglón.AutoSize = true;
            this.btnLlenarXRenglón.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlenarXRenglón.Location = new System.Drawing.Point(12, 84);
            this.btnLlenarXRenglón.Name = "btnLlenarXRenglón";
            this.btnLlenarXRenglón.Size = new System.Drawing.Size(92, 28);
            this.btnLlenarXRenglón.TabIndex = 2;
            this.btnLlenarXRenglón.Text = "Llenar";
            this.btnLlenarXRenglón.UseVisualStyleBackColor = true;
            this.btnLlenarXRenglón.Click += new System.EventHandler(this.btnLlenarXRenglón_Click);
            // 
            // btnMostrarXRenglón
            // 
            this.btnMostrarXRenglón.AutoSize = true;
            this.btnMostrarXRenglón.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarXRenglón.Location = new System.Drawing.Point(110, 84);
            this.btnMostrarXRenglón.Name = "btnMostrarXRenglón";
            this.btnMostrarXRenglón.Size = new System.Drawing.Size(92, 28);
            this.btnMostrarXRenglón.TabIndex = 3;
            this.btnMostrarXRenglón.Text = "Mostrar";
            this.btnMostrarXRenglón.UseVisualStyleBackColor = true;
            this.btnMostrarXRenglón.Click += new System.EventHandler(this.btnMostrarXRenglón_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(213, 12);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShow.Size = new System.Drawing.Size(520, 520);
            this.txtShow.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tamaño:";
            // 
            // btnMostrarPro
            // 
            this.btnMostrarPro.AutoSize = true;
            this.btnMostrarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPro.Location = new System.Drawing.Point(12, 483);
            this.btnMostrarPro.Name = "btnMostrarPro";
            this.btnMostrarPro.Size = new System.Drawing.Size(190, 28);
            this.btnMostrarPro.TabIndex = 6;
            this.btnMostrarPro.Text = "Mostrar Pro";
            this.btnMostrarPro.UseVisualStyleBackColor = true;
            this.btnMostrarPro.Click += new System.EventHandler(this.btnMostrarPro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Por columna:";
            // 
            // btnMostrarXColumna
            // 
            this.btnMostrarXColumna.AutoSize = true;
            this.btnMostrarXColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarXColumna.Location = new System.Drawing.Point(110, 188);
            this.btnMostrarXColumna.Name = "btnMostrarXColumna";
            this.btnMostrarXColumna.Size = new System.Drawing.Size(92, 28);
            this.btnMostrarXColumna.TabIndex = 9;
            this.btnMostrarXColumna.Text = "Mostrar";
            this.btnMostrarXColumna.UseVisualStyleBackColor = true;
            this.btnMostrarXColumna.Click += new System.EventHandler(this.btnMostrarXColumna_Click);
            // 
            // btnLlenarXColumna
            // 
            this.btnLlenarXColumna.AutoSize = true;
            this.btnLlenarXColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlenarXColumna.Location = new System.Drawing.Point(12, 188);
            this.btnLlenarXColumna.Name = "btnLlenarXColumna";
            this.btnLlenarXColumna.Size = new System.Drawing.Size(92, 28);
            this.btnLlenarXColumna.TabIndex = 8;
            this.btnLlenarXColumna.Text = "Llenar";
            this.btnLlenarXColumna.UseVisualStyleBackColor = true;
            this.btnLlenarXColumna.Click += new System.EventHandler(this.btnLlenarXColumna_Click);
            // 
            // btnInversoRenglón
            // 
            this.btnInversoRenglón.AutoSize = true;
            this.btnInversoRenglón.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInversoRenglón.Location = new System.Drawing.Point(52, 118);
            this.btnInversoRenglón.Name = "btnInversoRenglón";
            this.btnInversoRenglón.Size = new System.Drawing.Size(111, 28);
            this.btnInversoRenglón.TabIndex = 11;
            this.btnInversoRenglón.Text = "Llenar inverso";
            this.btnInversoRenglón.UseVisualStyleBackColor = true;
            this.btnInversoRenglón.Click += new System.EventHandler(this.btnInversoRenglón_Click);
            // 
            // btnInversoColumna
            // 
            this.btnInversoColumna.AutoSize = true;
            this.btnInversoColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInversoColumna.Location = new System.Drawing.Point(52, 222);
            this.btnInversoColumna.Name = "btnInversoColumna";
            this.btnInversoColumna.Size = new System.Drawing.Size(111, 28);
            this.btnInversoColumna.TabIndex = 12;
            this.btnInversoColumna.Text = "Llenar inverso";
            this.btnInversoColumna.UseVisualStyleBackColor = true;
            this.btnInversoColumna.Click += new System.EventHandler(this.btnInversoColumna_Click);
            // 
            // btnArribaDiagPrinc
            // 
            this.btnArribaDiagPrinc.AutoSize = true;
            this.btnArribaDiagPrinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArribaDiagPrinc.Location = new System.Drawing.Point(12, 292);
            this.btnArribaDiagPrinc.Name = "btnArribaDiagPrinc";
            this.btnArribaDiagPrinc.Size = new System.Drawing.Size(92, 28);
            this.btnArribaDiagPrinc.TabIndex = 16;
            this.btnArribaDiagPrinc.Text = "Arriba de";
            this.btnArribaDiagPrinc.UseVisualStyleBackColor = true;
            this.btnArribaDiagPrinc.Click += new System.EventHandler(this.btnArribaDiagPrinc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Por diagonal principal:";
            // 
            // btnDebajoDiagPrinc
            // 
            this.btnDebajoDiagPrinc.AutoSize = true;
            this.btnDebajoDiagPrinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebajoDiagPrinc.Location = new System.Drawing.Point(110, 292);
            this.btnDebajoDiagPrinc.Name = "btnDebajoDiagPrinc";
            this.btnDebajoDiagPrinc.Size = new System.Drawing.Size(92, 28);
            this.btnDebajoDiagPrinc.TabIndex = 14;
            this.btnDebajoDiagPrinc.Text = "Debajo de";
            this.btnDebajoDiagPrinc.UseVisualStyleBackColor = true;
            this.btnDebajoDiagPrinc.Click += new System.EventHandler(this.btnDebajoDiagPrinc_Click);
            // 
            // btnDiagPrinc
            // 
            this.btnDiagPrinc.AutoSize = true;
            this.btnDiagPrinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagPrinc.Location = new System.Drawing.Point(110, 326);
            this.btnDiagPrinc.Name = "btnDiagPrinc";
            this.btnDiagPrinc.Size = new System.Drawing.Size(92, 28);
            this.btnDiagPrinc.TabIndex = 13;
            this.btnDiagPrinc.Text = "Mostrar";
            this.btnDiagPrinc.UseVisualStyleBackColor = true;
            this.btnDiagPrinc.Click += new System.EventHandler(this.btnDiagPrinc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Por diagonal secundaria:";
            // 
            // btnArribaDiagSec
            // 
            this.btnArribaDiagSec.AutoSize = true;
            this.btnArribaDiagSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArribaDiagSec.Location = new System.Drawing.Point(12, 396);
            this.btnArribaDiagSec.Name = "btnArribaDiagSec";
            this.btnArribaDiagSec.Size = new System.Drawing.Size(92, 28);
            this.btnArribaDiagSec.TabIndex = 22;
            this.btnArribaDiagSec.Text = "Arriba de";
            this.btnArribaDiagSec.UseVisualStyleBackColor = true;
            this.btnArribaDiagSec.Click += new System.EventHandler(this.btnArribaDiagSec_Click);
            // 
            // btnDebajoDiagSec
            // 
            this.btnDebajoDiagSec.AutoSize = true;
            this.btnDebajoDiagSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebajoDiagSec.Location = new System.Drawing.Point(110, 396);
            this.btnDebajoDiagSec.Name = "btnDebajoDiagSec";
            this.btnDebajoDiagSec.Size = new System.Drawing.Size(92, 28);
            this.btnDebajoDiagSec.TabIndex = 21;
            this.btnDebajoDiagSec.Text = "Debajo de";
            this.btnDebajoDiagSec.UseVisualStyleBackColor = true;
            this.btnDebajoDiagSec.Click += new System.EventHandler(this.btnDebajoDiagSec_Click);
            // 
            // btnDiagSec
            // 
            this.btnDiagSec.AutoSize = true;
            this.btnDiagSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagSec.Location = new System.Drawing.Point(54, 430);
            this.btnDiagSec.Name = "btnDiagSec";
            this.btnDiagSec.Size = new System.Drawing.Size(92, 28);
            this.btnDiagSec.TabIndex = 20;
            this.btnDiagSec.Text = "Mostrar";
            this.btnDiagSec.UseVisualStyleBackColor = true;
            this.btnDiagSec.Click += new System.EventHandler(this.btnDiagSec_Click);
            // 
            // btnRotarXPrincipal
            // 
            this.btnRotarXPrincipal.AutoSize = true;
            this.btnRotarXPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotarXPrincipal.Location = new System.Drawing.Point(12, 326);
            this.btnRotarXPrincipal.Name = "btnRotarXPrincipal";
            this.btnRotarXPrincipal.Size = new System.Drawing.Size(92, 28);
            this.btnRotarXPrincipal.TabIndex = 23;
            this.btnRotarXPrincipal.Text = "Rotar";
            this.btnRotarXPrincipal.UseVisualStyleBackColor = true;
            this.btnRotarXPrincipal.Click += new System.EventHandler(this.btnRotarXPrincipal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Por renglón:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 543);
            this.Controls.Add(this.btnRotarXPrincipal);
            this.Controls.Add(this.btnArribaDiagSec);
            this.Controls.Add(this.btnDebajoDiagSec);
            this.Controls.Add(this.btnDiagSec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnArribaDiagPrinc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDebajoDiagPrinc);
            this.Controls.Add(this.btnDiagPrinc);
            this.Controls.Add(this.btnInversoColumna);
            this.Controls.Add(this.btnInversoRenglón);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMostrarXColumna);
            this.Controls.Add(this.btnLlenarXColumna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarPro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnMostrarXRenglón);
            this.Controls.Add(this.btnLlenarXRenglón);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.btnCreate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnLlenarXRenglón;
        private System.Windows.Forms.Button btnMostrarXRenglón;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarPro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMostrarXColumna;
        private System.Windows.Forms.Button btnLlenarXColumna;
        private System.Windows.Forms.Button btnInversoRenglón;
        private System.Windows.Forms.Button btnInversoColumna;
        private System.Windows.Forms.Button btnArribaDiagPrinc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDebajoDiagPrinc;
        private System.Windows.Forms.Button btnDiagPrinc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnArribaDiagSec;
        private System.Windows.Forms.Button btnDebajoDiagSec;
        private System.Windows.Forms.Button btnDiagSec;
        private System.Windows.Forms.Button btnRotarXPrincipal;
        private System.Windows.Forms.Label label2;
    }
}

