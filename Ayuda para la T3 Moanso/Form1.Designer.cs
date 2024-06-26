namespace Ayuda_para_la_T3_Moanso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.conectar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moveramanhabi = new System.Windows.Forms.Button();
            this.moveramancli = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.moveramancli);
            this.panel1.Controls.Add(this.moveramanhabi);
            this.panel1.Controls.Add(this.conectar);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 593);
            this.panel1.TabIndex = 0;
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(240, 43);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(135, 33);
            this.conectar.TabIndex = 4;
            this.conectar.Text = "CONECTAR";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "DESKTOP-NM28KG4\\MSSQLSERVER01"});
            this.comboBox2.Location = new System.Drawing.Point(17, 107);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 33);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "T3_Moanso"});
            this.comboBox1.Location = new System.Drawing.Point(17, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "base de datos";
            // 
            // moveramanhabi
            // 
            this.moveramanhabi.Location = new System.Drawing.Point(653, 9);
            this.moveramanhabi.Name = "moveramanhabi";
            this.moveramanhabi.Size = new System.Drawing.Size(135, 61);
            this.moveramanhabi.TabIndex = 5;
            this.moveramanhabi.Text = "Man habitacion";
            this.moveramanhabi.UseVisualStyleBackColor = true;
            this.moveramanhabi.Click += new System.EventHandler(this.moveramanhabi_Click);
            // 
            // moveramancli
            // 
            this.moveramancli.Location = new System.Drawing.Point(524, 9);
            this.moveramancli.Name = "moveramancli";
            this.moveramancli.Size = new System.Drawing.Size(123, 61);
            this.moveramancli.TabIndex = 6;
            this.moveramancli.Text = "Man Cliente";
            this.moveramancli.UseVisualStyleBackColor = true;
            this.moveramancli.Click += new System.EventHandler(this.moveramancli_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button moveramancli;
        private System.Windows.Forms.Button moveramanhabi;
    }
}

