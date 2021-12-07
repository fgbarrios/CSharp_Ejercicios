
namespace frmVista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupUsuario = new System.Windows.Forms.GroupBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupGenero = new System.Windows.Forms.GroupBox();
            this.radioFemenino = new System.Windows.Forms.RadioButton();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.groupCursos = new System.Windows.Forms.GroupBox();
            this.checkJavascript = new System.Windows.Forms.CheckBox();
            this.checkCPlusPlus = new System.Windows.Forms.CheckBox();
            this.checkCSharp = new System.Windows.Forms.CheckBox();
            this.listBoxPaises = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.groupGenero.SuspendLayout();
            this.groupCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupUsuario
            // 
            this.groupUsuario.Controls.Add(this.numEdad);
            this.groupUsuario.Controls.Add(this.tbxDireccion);
            this.groupUsuario.Controls.Add(this.tbxNombre);
            this.groupUsuario.Controls.Add(this.lblEdad);
            this.groupUsuario.Controls.Add(this.lblDireccion);
            this.groupUsuario.Controls.Add(this.lblNombre);
            this.groupUsuario.Location = new System.Drawing.Point(24, 28);
            this.groupUsuario.Name = "groupUsuario";
            this.groupUsuario.Size = new System.Drawing.Size(224, 152);
            this.groupUsuario.TabIndex = 0;
            this.groupUsuario.TabStop = false;
            this.groupUsuario.Text = "Detalles del usurio";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(89, 94);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(120, 23);
            this.numEdad.TabIndex = 5;
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(89, 60);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(120, 23);
            this.tbxDireccion.TabIndex = 4;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(89, 26);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(121, 23);
            this.tbxNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(17, 96);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 60);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // groupGenero
            // 
            this.groupGenero.Controls.Add(this.radioFemenino);
            this.groupGenero.Controls.Add(this.radioMasculino);
            this.groupGenero.Location = new System.Drawing.Point(301, 28);
            this.groupGenero.Name = "groupGenero";
            this.groupGenero.Size = new System.Drawing.Size(149, 111);
            this.groupGenero.TabIndex = 1;
            this.groupGenero.TabStop = false;
            this.groupGenero.Text = "Genero";
            // 
            // radioFemenino
            // 
            this.radioFemenino.AutoSize = true;
            this.radioFemenino.Location = new System.Drawing.Point(7, 63);
            this.radioFemenino.Name = "radioFemenino";
            this.radioFemenino.Size = new System.Drawing.Size(78, 19);
            this.radioFemenino.TabIndex = 1;
            this.radioFemenino.Text = "Femenino";
            this.radioFemenino.UseVisualStyleBackColor = true;
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Checked = true;
            this.radioMasculino.Location = new System.Drawing.Point(7, 29);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(80, 19);
            this.radioMasculino.TabIndex = 0;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "Masculino";
            this.radioMasculino.UseVisualStyleBackColor = true;
            // 
            // groupCursos
            // 
            this.groupCursos.Controls.Add(this.checkJavascript);
            this.groupCursos.Controls.Add(this.checkCPlusPlus);
            this.groupCursos.Controls.Add(this.checkCSharp);
            this.groupCursos.Location = new System.Drawing.Point(301, 168);
            this.groupCursos.Name = "groupCursos";
            this.groupCursos.Size = new System.Drawing.Size(149, 107);
            this.groupCursos.TabIndex = 2;
            this.groupCursos.TabStop = false;
            this.groupCursos.Text = "Cursos";
            // 
            // checkJavascript
            // 
            this.checkJavascript.AutoSize = true;
            this.checkJavascript.Location = new System.Drawing.Point(7, 75);
            this.checkJavascript.Name = "checkJavascript";
            this.checkJavascript.Size = new System.Drawing.Size(78, 19);
            this.checkJavascript.TabIndex = 2;
            this.checkJavascript.Text = "JavaScript";
            this.checkJavascript.UseVisualStyleBackColor = true;
            // 
            // checkCPlusPlus
            // 
            this.checkCPlusPlus.AutoSize = true;
            this.checkCPlusPlus.Location = new System.Drawing.Point(7, 49);
            this.checkCPlusPlus.Name = "checkCPlusPlus";
            this.checkCPlusPlus.Size = new System.Drawing.Size(53, 19);
            this.checkCPlusPlus.TabIndex = 1;
            this.checkCPlusPlus.Text = "C ++";
            this.checkCPlusPlus.UseVisualStyleBackColor = true;
            // 
            // checkCSharp
            // 
            this.checkCSharp.AutoSize = true;
            this.checkCSharp.Location = new System.Drawing.Point(7, 23);
            this.checkCSharp.Name = "checkCSharp";
            this.checkCSharp.Size = new System.Drawing.Size(41, 19);
            this.checkCSharp.TabIndex = 0;
            this.checkCSharp.Text = "C#";
            this.checkCSharp.UseVisualStyleBackColor = true;
            // 
            // listBoxPaises
            // 
            this.listBoxPaises.FormattingEnabled = true;
            this.listBoxPaises.ItemHeight = 15;
            this.listBoxPaises.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.listBoxPaises.Location = new System.Drawing.Point(24, 209);
            this.listBoxPaises.Name = "listBoxPaises";
            this.listBoxPaises.Size = new System.Drawing.Size(224, 109);
            this.listBoxPaises.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(24, 191);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "Pais";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(301, 283);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(149, 35);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 345);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.listBoxPaises);
            this.Controls.Add(this.groupCursos);
            this.Controls.Add(this.groupGenero);
            this.Controls.Add(this.groupUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupUsuario.ResumeLayout(false);
            this.groupUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.groupGenero.ResumeLayout(false);
            this.groupGenero.PerformLayout();
            this.groupCursos.ResumeLayout(false);
            this.groupCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupUsuario;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupGenero;
        private System.Windows.Forms.RadioButton radioFemenino;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.GroupBox groupCursos;
        private System.Windows.Forms.CheckBox checkJavascript;
        private System.Windows.Forms.CheckBox checkCPlusPlus;
        private System.Windows.Forms.CheckBox checkCSharp;
        private System.Windows.Forms.ListBox listBoxPaises;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}

