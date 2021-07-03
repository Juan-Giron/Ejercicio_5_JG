namespace Ejercicio5_JuanGiron
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ejecutar_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Filas_textBox = new System.Windows.Forms.TextBox();
            this.Columnas_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ejecutar_button
            // 
            this.Ejecutar_button.Location = new System.Drawing.Point(86, 226);
            this.Ejecutar_button.Name = "Ejecutar_button";
            this.Ejecutar_button.Size = new System.Drawing.Size(155, 35);
            this.Ejecutar_button.TabIndex = 0;
            this.Ejecutar_button.Text = "Ejecutar";
            this.Ejecutar_button.UseVisualStyleBackColor = true;
            this.Ejecutar_button.Click += new System.EventHandler(this.Ejecutar_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Filas :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de Columnas :";
            // 
            // Filas_textBox
            // 
            this.Filas_textBox.Location = new System.Drawing.Point(146, 40);
            this.Filas_textBox.Name = "Filas_textBox";
            this.Filas_textBox.Size = new System.Drawing.Size(100, 20);
            this.Filas_textBox.TabIndex = 3;
            // 
            // Columnas_textBox
            // 
            this.Columnas_textBox.Location = new System.Drawing.Point(146, 79);
            this.Columnas_textBox.Name = "Columnas_textBox";
            this.Columnas_textBox.Size = new System.Drawing.Size(100, 20);
            this.Columnas_textBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Columnas_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Filas_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 155);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz N x M";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 285);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Ejecutar_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ejecutar_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Filas_textBox;
        private System.Windows.Forms.TextBox Columnas_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

