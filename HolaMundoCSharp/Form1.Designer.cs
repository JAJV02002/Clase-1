namespace HolaMundoCSharp
{
    partial class TextBoxBienvenida
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
            this.LabelBienvenida = new System.Windows.Forms.Label();
            this.LabelPregunta = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelBienvenida
            // 
            this.LabelBienvenida.AutoSize = true;
            this.LabelBienvenida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelBienvenida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBienvenida.Location = new System.Drawing.Point(305, 46);
            this.LabelBienvenida.Name = "LabelBienvenida";
            this.LabelBienvenida.Size = new System.Drawing.Size(390, 34);
            this.LabelBienvenida.TabIndex = 0;
            this.LabelBienvenida.Text = "Hola usuario bienvenido a C#";
            this.LabelBienvenida.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LabelPregunta
            // 
            this.LabelPregunta.AutoSize = true;
            this.LabelPregunta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPregunta.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelPregunta.Location = new System.Drawing.Point(29, 118);
            this.LabelPregunta.Name = "LabelPregunta";
            this.LabelPregunta.Size = new System.Drawing.Size(216, 25);
            this.LabelPregunta.TabIndex = 1;
            this.LabelPregunta.Text = "¿Cual es tu nombre? :0";
            this.LabelPregunta.Click += new System.EventHandler(this.LabelPregunta_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(258, 118);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(244, 22);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.TextBoxNombre_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(274, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Presiona aqui";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBoxBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.LabelPregunta);
            this.Controls.Add(this.LabelBienvenida);
            this.Name = "TextBoxBienvenida";
            this.Text = "Hola Mundo C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelBienvenida;
        private System.Windows.Forms.Label LabelPregunta;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button button1;
    }
}

