namespace Tarea_ejercicios_cap_11
{
    partial class TareaCap11
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tcTareaCap11 = new System.Windows.Forms.TabControl();
            this.tabCadenas = new System.Windows.Forms.TabPage();
            this.tabarchivo = new System.Windows.Forms.TabPage();
            this.txtDireccionArchivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProcesar2 = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbResultado2 = new System.Windows.Forms.Label();
            this.tabCopiarArchivo = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProcesar3 = new System.Windows.Forms.Button();
            this.txtArchivoNombre = new System.Windows.Forms.TextBox();
            this.tcTareaCap11.SuspendLayout();
            this.tabCadenas.SuspendLayout();
            this.tabarchivo.SuspendLayout();
            this.tabCopiarArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba la cadena de caracteres";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(174, 56);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(157, 20);
            this.txtCadena.TabIndex = 1;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(202, 83);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(98, 31);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(237, 148);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 13);
            this.lbResultado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado :";
            // 
            // tcTareaCap11
            // 
            this.tcTareaCap11.Controls.Add(this.tabCadenas);
            this.tcTareaCap11.Controls.Add(this.tabarchivo);
            this.tcTareaCap11.Controls.Add(this.tabCopiarArchivo);
            this.tcTareaCap11.Location = new System.Drawing.Point(-1, -3);
            this.tcTareaCap11.Name = "tcTareaCap11";
            this.tcTareaCap11.SelectedIndex = 0;
            this.tcTareaCap11.Size = new System.Drawing.Size(524, 263);
            this.tcTareaCap11.TabIndex = 5;
            // 
            // tabCadenas
            // 
            this.tabCadenas.Controls.Add(this.btnProcesar);
            this.tabCadenas.Controls.Add(this.txtCadena);
            this.tabCadenas.Controls.Add(this.label3);
            this.tabCadenas.Controls.Add(this.label1);
            this.tabCadenas.Controls.Add(this.lbResultado);
            this.tabCadenas.Location = new System.Drawing.Point(4, 22);
            this.tabCadenas.Name = "tabCadenas";
            this.tabCadenas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadenas.Size = new System.Drawing.Size(516, 237);
            this.tabCadenas.TabIndex = 0;
            this.tabCadenas.Text = "Ejercicio#1";
            this.tabCadenas.UseVisualStyleBackColor = true;
            // 
            // tabarchivo
            // 
            this.tabarchivo.Controls.Add(this.txtDireccionArchivo);
            this.tabarchivo.Controls.Add(this.label6);
            this.tabarchivo.Controls.Add(this.btnProcesar2);
            this.tabarchivo.Controls.Add(this.txtNombreArchivo);
            this.tabarchivo.Controls.Add(this.label2);
            this.tabarchivo.Controls.Add(this.label4);
            this.tabarchivo.Controls.Add(this.lbResultado2);
            this.tabarchivo.Location = new System.Drawing.Point(4, 22);
            this.tabarchivo.Name = "tabarchivo";
            this.tabarchivo.Padding = new System.Windows.Forms.Padding(3);
            this.tabarchivo.Size = new System.Drawing.Size(516, 237);
            this.tabarchivo.TabIndex = 1;
            this.tabarchivo.Text = "Ejercicio#2";
            this.tabarchivo.UseVisualStyleBackColor = true;
            // 
            // txtDireccionArchivo
            // 
            this.txtDireccionArchivo.Location = new System.Drawing.Point(181, 75);
            this.txtDireccionArchivo.Name = "txtDireccionArchivo";
            this.txtDireccionArchivo.Size = new System.Drawing.Size(157, 20);
            this.txtDireccionArchivo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Escriba el nombre del archivo";
            // 
            // btnProcesar2
            // 
            this.btnProcesar2.Location = new System.Drawing.Point(210, 101);
            this.btnProcesar2.Name = "btnProcesar2";
            this.btnProcesar2.Size = new System.Drawing.Size(98, 31);
            this.btnProcesar2.TabIndex = 7;
            this.btnProcesar2.Text = "Procesar";
            this.btnProcesar2.UseVisualStyleBackColor = true;
            this.btnProcesar2.Click += new System.EventHandler(this.btnProcesar2_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(182, 37);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(157, 20);
            this.txtNombreArchivo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resultado :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Escriba la ruta del archivo";
            // 
            // lbResultado2
            // 
            this.lbResultado2.AutoSize = true;
            this.lbResultado2.Location = new System.Drawing.Point(245, 166);
            this.lbResultado2.Name = "lbResultado2";
            this.lbResultado2.Size = new System.Drawing.Size(35, 13);
            this.lbResultado2.TabIndex = 8;
            this.lbResultado2.Text = "label2";
            // 
            // tabCopiarArchivo
            // 
            this.tabCopiarArchivo.Controls.Add(this.label5);
            this.tabCopiarArchivo.Controls.Add(this.btnProcesar3);
            this.tabCopiarArchivo.Controls.Add(this.txtArchivoNombre);
            this.tabCopiarArchivo.Location = new System.Drawing.Point(4, 22);
            this.tabCopiarArchivo.Name = "tabCopiarArchivo";
            this.tabCopiarArchivo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCopiarArchivo.Size = new System.Drawing.Size(516, 237);
            this.tabCopiarArchivo.TabIndex = 2;
            this.tabCopiarArchivo.Text = "Ejercicio#4";
            this.tabCopiarArchivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Escriba la ruta exacta del archivo.txt que quiera borrar";
            // 
            // btnProcesar3
            // 
            this.btnProcesar3.Location = new System.Drawing.Point(209, 92);
            this.btnProcesar3.Name = "btnProcesar3";
            this.btnProcesar3.Size = new System.Drawing.Size(98, 31);
            this.btnProcesar3.TabIndex = 14;
            this.btnProcesar3.Text = "Procesar";
            this.btnProcesar3.UseVisualStyleBackColor = true;
            this.btnProcesar3.Click += new System.EventHandler(this.btnProcesar3_Click);
            // 
            // txtArchivoNombre
            // 
            this.txtArchivoNombre.Location = new System.Drawing.Point(182, 55);
            this.txtArchivoNombre.Name = "txtArchivoNombre";
            this.txtArchivoNombre.Size = new System.Drawing.Size(157, 20);
            this.txtArchivoNombre.TabIndex = 13;
            // 
            // TareaCap11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 253);
            this.Controls.Add(this.tcTareaCap11);
            this.Name = "TareaCap11";
            this.Text = "Tarea cap#11";
            this.Load += new System.EventHandler(this.TareaCap11_Load);
            this.tcTareaCap11.ResumeLayout(false);
            this.tabCadenas.ResumeLayout(false);
            this.tabCadenas.PerformLayout();
            this.tabarchivo.ResumeLayout(false);
            this.tabarchivo.PerformLayout();
            this.tabCopiarArchivo.ResumeLayout(false);
            this.tabCopiarArchivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tcTareaCap11;
        private System.Windows.Forms.TabPage tabCadenas;
        private System.Windows.Forms.TabPage tabarchivo;
        private System.Windows.Forms.TextBox txtDireccionArchivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProcesar2;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbResultado2;
        private System.Windows.Forms.TabPage tabCopiarArchivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProcesar3;
        private System.Windows.Forms.TextBox txtArchivoNombre;
    }
}

