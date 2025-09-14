namespace Matrices_Cofactores
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
            this.rd2x2 = new System.Windows.Forms.RadioButton();
            this.rd3x3 = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.GP2x2 = new System.Windows.Forms.GroupBox();
            this.txtA22 = new System.Windows.Forms.TextBox();
            this.txtA21 = new System.Windows.Forms.TextBox();
            this.txtA12 = new System.Windows.Forms.TextBox();
            this.txtA11 = new System.Windows.Forms.TextBox();
            this.GB3x3 = new System.Windows.Forms.GroupBox();
            this.txtA33 = new System.Windows.Forms.TextBox();
            this.txtA32 = new System.Windows.Forms.TextBox();
            this.txtA31 = new System.Windows.Forms.TextBox();
            this.txtA23 = new System.Windows.Forms.TextBox();
            this.txtA13 = new System.Windows.Forms.TextBox();
            this.txtA22_3x3 = new System.Windows.Forms.TextBox();
            this.txtA21_3x3 = new System.Windows.Forms.TextBox();
            this.txtA12_3x3 = new System.Windows.Forms.TextBox();
            this.txtA11_3x3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCeros = new System.Windows.Forms.Button();
            this.lblDet = new System.Windows.Forms.Label();
            this.GP2x2.SuspendLayout();
            this.GB3x3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rd2x2
            // 
            this.rd2x2.AutoSize = true;
            this.rd2x2.Location = new System.Drawing.Point(210, 115);
            this.rd2x2.Name = "rd2x2";
            this.rd2x2.Size = new System.Drawing.Size(86, 20);
            this.rd2x2.TabIndex = 0;
            this.rd2x2.Text = "Matriz 2x2";
            this.rd2x2.UseVisualStyleBackColor = true;
            this.rd2x2.CheckedChanged += new System.EventHandler(this.rd2x2_CheckedChanged);
            // 
            // rd3x3
            // 
            this.rd3x3.AutoSize = true;
            this.rd3x3.Location = new System.Drawing.Point(425, 115);
            this.rd3x3.Name = "rd3x3";
            this.rd3x3.Size = new System.Drawing.Size(86, 20);
            this.rd3x3.TabIndex = 1;
            this.rd3x3.Text = "Matriz 3x3";
            this.rd3x3.UseVisualStyleBackColor = true;
            this.rd3x3.CheckedChanged += new System.EventHandler(this.rd3x3_CheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(320, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(131, 16);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Matriz por cofactores";
            // 
            // GP2x2
            // 
            this.GP2x2.Controls.Add(this.lblDet);
            this.GP2x2.Controls.Add(this.txtA22);
            this.GP2x2.Controls.Add(this.txtA21);
            this.GP2x2.Controls.Add(this.txtA12);
            this.GP2x2.Controls.Add(this.txtA11);
            this.GP2x2.Location = new System.Drawing.Point(172, 174);
            this.GP2x2.Name = "GP2x2";
            this.GP2x2.Size = new System.Drawing.Size(424, 232);
            this.GP2x2.TabIndex = 3;
            this.GP2x2.TabStop = false;
            this.GP2x2.Text = "Matriz 2x2";
            // 
            // txtA22
            // 
            this.txtA22.Location = new System.Drawing.Point(218, 114);
            this.txtA22.Name = "txtA22";
            this.txtA22.Size = new System.Drawing.Size(65, 22);
            this.txtA22.TabIndex = 3;
            // 
            // txtA21
            // 
            this.txtA21.Location = new System.Drawing.Point(126, 114);
            this.txtA21.Name = "txtA21";
            this.txtA21.Size = new System.Drawing.Size(65, 22);
            this.txtA21.TabIndex = 2;
            // 
            // txtA12
            // 
            this.txtA12.Location = new System.Drawing.Point(218, 64);
            this.txtA12.Name = "txtA12";
            this.txtA12.Size = new System.Drawing.Size(65, 22);
            this.txtA12.TabIndex = 1;
            // 
            // txtA11
            // 
            this.txtA11.Location = new System.Drawing.Point(126, 64);
            this.txtA11.Name = "txtA11";
            this.txtA11.Size = new System.Drawing.Size(65, 22);
            this.txtA11.TabIndex = 0;
            // 
            // GB3x3
            // 
            this.GB3x3.Controls.Add(this.txtA33);
            this.GB3x3.Controls.Add(this.txtA32);
            this.GB3x3.Controls.Add(this.txtA31);
            this.GB3x3.Controls.Add(this.txtA23);
            this.GB3x3.Controls.Add(this.txtA13);
            this.GB3x3.Controls.Add(this.txtA22_3x3);
            this.GB3x3.Controls.Add(this.txtA21_3x3);
            this.GB3x3.Controls.Add(this.txtA12_3x3);
            this.GB3x3.Controls.Add(this.txtA11_3x3);
            this.GB3x3.Location = new System.Drawing.Point(172, 174);
            this.GB3x3.Name = "GB3x3";
            this.GB3x3.Size = new System.Drawing.Size(424, 232);
            this.GB3x3.TabIndex = 4;
            this.GB3x3.TabStop = false;
            this.GB3x3.Text = "Matriz 3x3";
            // 
            // txtA33
            // 
            this.txtA33.Location = new System.Drawing.Point(291, 145);
            this.txtA33.Name = "txtA33";
            this.txtA33.Size = new System.Drawing.Size(65, 22);
            this.txtA33.TabIndex = 8;
            // 
            // txtA32
            // 
            this.txtA32.Location = new System.Drawing.Point(197, 145);
            this.txtA32.Name = "txtA32";
            this.txtA32.Size = new System.Drawing.Size(65, 22);
            this.txtA32.TabIndex = 7;
            // 
            // txtA31
            // 
            this.txtA31.Location = new System.Drawing.Point(105, 145);
            this.txtA31.Name = "txtA31";
            this.txtA31.Size = new System.Drawing.Size(65, 22);
            this.txtA31.TabIndex = 6;
            // 
            // txtA23
            // 
            this.txtA23.Location = new System.Drawing.Point(291, 94);
            this.txtA23.Name = "txtA23";
            this.txtA23.Size = new System.Drawing.Size(65, 22);
            this.txtA23.TabIndex = 5;
            // 
            // txtA13
            // 
            this.txtA13.Location = new System.Drawing.Point(291, 44);
            this.txtA13.Name = "txtA13";
            this.txtA13.Size = new System.Drawing.Size(65, 22);
            this.txtA13.TabIndex = 4;
            // 
            // txtA22_3x3
            // 
            this.txtA22_3x3.Location = new System.Drawing.Point(197, 94);
            this.txtA22_3x3.Name = "txtA22_3x3";
            this.txtA22_3x3.Size = new System.Drawing.Size(65, 22);
            this.txtA22_3x3.TabIndex = 3;
            // 
            // txtA21_3x3
            // 
            this.txtA21_3x3.Location = new System.Drawing.Point(105, 94);
            this.txtA21_3x3.Name = "txtA21_3x3";
            this.txtA21_3x3.Size = new System.Drawing.Size(65, 22);
            this.txtA21_3x3.TabIndex = 2;
            // 
            // txtA12_3x3
            // 
            this.txtA12_3x3.Location = new System.Drawing.Point(197, 44);
            this.txtA12_3x3.Name = "txtA12_3x3";
            this.txtA12_3x3.Size = new System.Drawing.Size(65, 22);
            this.txtA12_3x3.TabIndex = 1;
            // 
            // txtA11_3x3
            // 
            this.txtA11_3x3.Location = new System.Drawing.Point(105, 44);
            this.txtA11_3x3.Name = "txtA11_3x3";
            this.txtA11_3x3.Size = new System.Drawing.Size(65, 22);
            this.txtA11_3x3.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(253, 412);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(359, 412);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCeros
            // 
            this.btnCeros.Location = new System.Drawing.Point(473, 412);
            this.btnCeros.Name = "btnCeros";
            this.btnCeros.Size = new System.Drawing.Size(152, 23);
            this.btnCeros.TabIndex = 6;
            this.btnCeros.Text = "Rellenar con ceros";
            this.btnCeros.UseVisualStyleBackColor = true;
            this.btnCeros.Click += new System.EventHandler(this.btnCeros_Click);
            // 
            // lblDet
            // 
            this.lblDet.AutoSize = true;
            this.lblDet.Location = new System.Drawing.Point(148, 163);
            this.lblDet.Name = "lblDet";
            this.lblDet.Size = new System.Drawing.Size(131, 16);
            this.lblDet.TabIndex = 7;
            this.lblDet.Text = "Matriz por cofactores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GB3x3);
            this.Controls.Add(this.btnCeros);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.GP2x2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rd3x3);
            this.Controls.Add(this.rd2x2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GP2x2.ResumeLayout(false);
            this.GP2x2.PerformLayout();
            this.GB3x3.ResumeLayout(false);
            this.GB3x3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd2x2;
        private System.Windows.Forms.RadioButton rd3x3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox GP2x2;
        private System.Windows.Forms.GroupBox GB3x3;
        private System.Windows.Forms.TextBox txtA33;
        private System.Windows.Forms.TextBox txtA32;
        private System.Windows.Forms.TextBox txtA31;
        private System.Windows.Forms.TextBox txtA23;
        private System.Windows.Forms.TextBox txtA13;
        private System.Windows.Forms.TextBox txtA22_3x3;
        private System.Windows.Forms.TextBox txtA21_3x3;
        private System.Windows.Forms.TextBox txtA12_3x3;
        private System.Windows.Forms.TextBox txtA11_3x3;
        private System.Windows.Forms.TextBox txtA22;
        private System.Windows.Forms.TextBox txtA21;
        private System.Windows.Forms.TextBox txtA12;
        private System.Windows.Forms.TextBox txtA11;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCeros;
        private System.Windows.Forms.Label lblDet;
    }
}

