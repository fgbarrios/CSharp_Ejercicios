
namespace frmPrincipal
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
            this.gb_Detalles = new System.Windows.Forms.GroupBox();
            this.num_Edad = new System.Windows.Forms.NumericUpDown();
            this.tb_Direccion = new System.Windows.Forms.TextBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.lb_edad = new System.Windows.Forms.Label();
            this.lb_Direccion = new System.Windows.Forms.Label();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.gb_Genero = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gb_Cursos = new System.Windows.Forms.GroupBox();
            this.cb_Javascript = new System.Windows.Forms.CheckBox();
            this.cb_Cplusplus = new System.Windows.Forms.CheckBox();
            this.cb_C = new System.Windows.Forms.CheckBox();
            this.lb_Paises = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Ingresar = new System.Windows.Forms.Button();
            this.gb_Detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Edad)).BeginInit();
            this.gb_Genero.SuspendLayout();
            this.gb_Cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Detalles
            // 
            this.gb_Detalles.Controls.Add(this.num_Edad);
            this.gb_Detalles.Controls.Add(this.tb_Direccion);
            this.gb_Detalles.Controls.Add(this.tb_Nombre);
            this.gb_Detalles.Controls.Add(this.lb_edad);
            this.gb_Detalles.Controls.Add(this.lb_Direccion);
            this.gb_Detalles.Controls.Add(this.lb_Nombre);
            this.gb_Detalles.Location = new System.Drawing.Point(25, 13);
            this.gb_Detalles.Name = "gb_Detalles";
            this.gb_Detalles.Size = new System.Drawing.Size(222, 139);
            this.gb_Detalles.TabIndex = 0;
            this.gb_Detalles.TabStop = false;
            this.gb_Detalles.Text = "Detalles de Usuario";
            // 
            // num_Edad
            // 
            this.num_Edad.Location = new System.Drawing.Point(79, 97);
            this.num_Edad.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.num_Edad.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Edad.Name = "num_Edad";
            this.num_Edad.Size = new System.Drawing.Size(137, 23);
            this.num_Edad.TabIndex = 5;
            this.num_Edad.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.Location = new System.Drawing.Point(79, 59);
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.PlaceholderText = "Ingrese su direccion aqui";
            this.tb_Direccion.Size = new System.Drawing.Size(137, 23);
            this.tb_Direccion.TabIndex = 4;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(79, 20);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.PlaceholderText = "Ingrese su nombre aqui";
            this.tb_Nombre.Size = new System.Drawing.Size(137, 23);
            this.tb_Nombre.TabIndex = 3;
            // 
            // lb_edad
            // 
            this.lb_edad.AutoSize = true;
            this.lb_edad.Location = new System.Drawing.Point(7, 97);
            this.lb_edad.Name = "lb_edad";
            this.lb_edad.Size = new System.Drawing.Size(33, 15);
            this.lb_edad.TabIndex = 2;
            this.lb_edad.Text = "Edad";
            // 
            // lb_Direccion
            // 
            this.lb_Direccion.AutoSize = true;
            this.lb_Direccion.Location = new System.Drawing.Point(7, 62);
            this.lb_Direccion.Name = "lb_Direccion";
            this.lb_Direccion.Size = new System.Drawing.Size(57, 15);
            this.lb_Direccion.TabIndex = 1;
            this.lb_Direccion.Text = "Direccion";
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(7, 23);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lb_Nombre.TabIndex = 0;
            this.lb_Nombre.Text = "Nombre";
            // 
            // gb_Genero
            // 
            this.gb_Genero.Controls.Add(this.radioButton2);
            this.gb_Genero.Controls.Add(this.radioButton1);
            this.gb_Genero.Location = new System.Drawing.Point(291, 31);
            this.gb_Genero.Name = "gb_Genero";
            this.gb_Genero.Size = new System.Drawing.Size(151, 102);
            this.gb_Genero.TabIndex = 1;
            this.gb_Genero.TabStop = false;
            this.gb_Genero.Text = "Genero";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Femenino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // gb_Cursos
            // 
            this.gb_Cursos.Controls.Add(this.cb_Javascript);
            this.gb_Cursos.Controls.Add(this.cb_Cplusplus);
            this.gb_Cursos.Controls.Add(this.cb_C);
            this.gb_Cursos.Location = new System.Drawing.Point(291, 153);
            this.gb_Cursos.Name = "gb_Cursos";
            this.gb_Cursos.Size = new System.Drawing.Size(151, 121);
            this.gb_Cursos.TabIndex = 2;
            this.gb_Cursos.TabStop = false;
            this.gb_Cursos.Text = "Cursos";
            // 
            // cb_Javascript
            // 
            this.cb_Javascript.AutoSize = true;
            this.cb_Javascript.Location = new System.Drawing.Point(23, 90);
            this.cb_Javascript.Name = "cb_Javascript";
            this.cb_Javascript.Size = new System.Drawing.Size(77, 19);
            this.cb_Javascript.TabIndex = 2;
            this.cb_Javascript.Text = "Javascript";
            this.cb_Javascript.UseVisualStyleBackColor = true;
            // 
            // cb_Cplusplus
            // 
            this.cb_Cplusplus.AutoSize = true;
            this.cb_Cplusplus.Location = new System.Drawing.Point(23, 56);
            this.cb_Cplusplus.Name = "cb_Cplusplus";
            this.cb_Cplusplus.Size = new System.Drawing.Size(53, 19);
            this.cb_Cplusplus.TabIndex = 1;
            this.cb_Cplusplus.Text = "C ++";
            this.cb_Cplusplus.UseVisualStyleBackColor = true;
            // 
            // cb_C
            // 
            this.cb_C.AutoSize = true;
            this.cb_C.Checked = true;
            this.cb_C.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_C.Location = new System.Drawing.Point(23, 22);
            this.cb_C.Name = "cb_C";
            this.cb_C.Size = new System.Drawing.Size(41, 19);
            this.cb_C.TabIndex = 0;
            this.cb_C.Text = "C#";
            this.cb_C.UseVisualStyleBackColor = true;
            // 
            // lb_Paises
            // 
            this.lb_Paises.FormattingEnabled = true;
            this.lb_Paises.ItemHeight = 15;
            this.lb_Paises.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lb_Paises.Location = new System.Drawing.Point(25, 185);
            this.lb_Paises.Name = "lb_Paises";
            this.lb_Paises.Size = new System.Drawing.Size(222, 139);
            this.lb_Paises.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pais";
            // 
            // bt_Ingresar
            // 
            this.bt_Ingresar.Location = new System.Drawing.Point(291, 291);
            this.bt_Ingresar.Name = "bt_Ingresar";
            this.bt_Ingresar.Size = new System.Drawing.Size(151, 33);
            this.bt_Ingresar.TabIndex = 5;
            this.bt_Ingresar.Text = "Ingresar";
            this.bt_Ingresar.UseVisualStyleBackColor = true;
            this.bt_Ingresar.Click += new System.EventHandler(this.bt_Ingresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 344);
            this.Controls.Add(this.bt_Ingresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Paises);
            this.Controls.Add(this.gb_Cursos);
            this.Controls.Add(this.gb_Genero);
            this.Controls.Add(this.gb_Detalles);
            this.Name = "Form1";
            this.Text = "Registro";
            this.gb_Detalles.ResumeLayout(false);
            this.gb_Detalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Edad)).EndInit();
            this.gb_Genero.ResumeLayout(false);
            this.gb_Genero.PerformLayout();
            this.gb_Cursos.ResumeLayout(false);
            this.gb_Cursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Detalles;
        private System.Windows.Forms.NumericUpDown num_Edad;
        private System.Windows.Forms.TextBox tb_Direccion;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label lb_edad;
        private System.Windows.Forms.Label lb_Direccion;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.GroupBox gb_Genero;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gb_Cursos;
        private System.Windows.Forms.CheckBox cb_Javascript;
        private System.Windows.Forms.CheckBox cb_Cplusplus;
        private System.Windows.Forms.CheckBox cb_C;
        private System.Windows.Forms.ListBox lb_Paises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Ingresar;
    }
}

