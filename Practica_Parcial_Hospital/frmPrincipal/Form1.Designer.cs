
namespace frmPrincipal
{
    partial class frmPrincipal
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
            this.groupPersonal = new System.Windows.Forms.GroupBox();
            this.groupIngresado = new System.Windows.Forms.GroupBox();
            this.groupEgresado = new System.Windows.Forms.GroupBox();
            this.richIngresado = new System.Windows.Forms.RichTextBox();
            this.richEgresado = new System.Windows.Forms.RichTextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEgresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupPersonal.SuspendLayout();
            this.groupIngresado.SuspendLayout();
            this.groupEgresado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPersonal
            // 
            this.groupPersonal.Controls.Add(this.groupEgresado);
            this.groupPersonal.Controls.Add(this.groupIngresado);
            this.groupPersonal.Location = new System.Drawing.Point(13, 13);
            this.groupPersonal.Name = "groupPersonal";
            this.groupPersonal.Size = new System.Drawing.Size(885, 425);
            this.groupPersonal.TabIndex = 0;
            this.groupPersonal.TabStop = false;
            this.groupPersonal.Text = "Personal";
            // 
            // groupIngresado
            // 
            this.groupIngresado.Controls.Add(this.btnEgresar);
            this.groupIngresado.Controls.Add(this.btnIngresar);
            this.groupIngresado.Controls.Add(this.richIngresado);
            this.groupIngresado.Location = new System.Drawing.Point(7, 23);
            this.groupIngresado.Name = "groupIngresado";
            this.groupIngresado.Size = new System.Drawing.Size(399, 396);
            this.groupIngresado.TabIndex = 0;
            this.groupIngresado.TabStop = false;
            this.groupIngresado.Text = "Ingresado";
            // 
            // groupEgresado
            // 
            this.groupEgresado.Controls.Add(this.comboBox1);
            this.groupEgresado.Controls.Add(this.label1);
            this.groupEgresado.Controls.Add(this.richEgresado);
            this.groupEgresado.Location = new System.Drawing.Point(413, 23);
            this.groupEgresado.Name = "groupEgresado";
            this.groupEgresado.Size = new System.Drawing.Size(466, 396);
            this.groupEgresado.TabIndex = 1;
            this.groupEgresado.TabStop = false;
            this.groupEgresado.Text = "Egresado";
            // 
            // richIngresado
            // 
            this.richIngresado.Location = new System.Drawing.Point(7, 23);
            this.richIngresado.Name = "richIngresado";
            this.richIngresado.Size = new System.Drawing.Size(386, 291);
            this.richIngresado.TabIndex = 0;
            this.richIngresado.Text = "";
            // 
            // richEgresado
            // 
            this.richEgresado.Location = new System.Drawing.Point(7, 23);
            this.richEgresado.Name = "richEgresado";
            this.richEgresado.Size = new System.Drawing.Size(453, 291);
            this.richEgresado.TabIndex = 0;
            this.richEgresado.Text = "";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(7, 339);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(126, 51);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnEgresar
            // 
            this.btnEgresar.Location = new System.Drawing.Point(275, 339);
            this.btnEgresar.Name = "btnEgresar";
            this.btnEgresar.Size = new System.Drawing.Size(118, 51);
            this.btnEgresar.TabIndex = 2;
            this.btnEgresar.Text = "Egresar";
            this.btnEgresar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordenar por";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 354);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.groupPersonal);
            this.Name = "frmPrincipal";
            this.Text = "Barrios Fernando";
            this.groupPersonal.ResumeLayout(false);
            this.groupIngresado.ResumeLayout(false);
            this.groupEgresado.ResumeLayout(false);
            this.groupEgresado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPersonal;
        private System.Windows.Forms.GroupBox groupEgresado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richEgresado;
        private System.Windows.Forms.GroupBox groupIngresado;
        private System.Windows.Forms.Button btnEgresar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.RichTextBox richIngresado;
    }
}

