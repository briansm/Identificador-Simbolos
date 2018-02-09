namespace Practica1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.editor = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.cargar = new System.Windows.Forms.Button();
            this.analizar = new System.Windows.Forms.Button();
            this.Acercade = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // editor
            // 
            this.editor.Location = new System.Drawing.Point(26, 37);
            this.editor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(215, 312);
            this.editor.TabIndex = 0;
            this.editor.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(283, 37);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(215, 312);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(118, 398);
            this.cargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(63, 20);
            this.cargar.TabIndex = 2;
            this.cargar.Text = "Cargar";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // analizar
            // 
            this.analizar.Location = new System.Drawing.Point(225, 398);
            this.analizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.analizar.Name = "analizar";
            this.analizar.Size = new System.Drawing.Size(63, 20);
            this.analizar.TabIndex = 3;
            this.analizar.Text = "Analizar";
            this.analizar.UseVisualStyleBackColor = true;
            // 
            // Acercade
            // 
            this.Acercade.Location = new System.Drawing.Point(328, 398);
            this.Acercade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Acercade.Name = "Acercade";
            this.Acercade.Size = new System.Drawing.Size(63, 20);
            this.Acercade.TabIndex = 4;
            this.Acercade.Text = "Acerca de";
            this.Acercade.UseVisualStyleBackColor = true;
            this.Acercade.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(130, 463);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(246, 122);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 614);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.Acercade);
            this.Controls.Add(this.analizar);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.editor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Identificador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox editor;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Button analizar;
        private System.Windows.Forms.Button Acercade;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}

