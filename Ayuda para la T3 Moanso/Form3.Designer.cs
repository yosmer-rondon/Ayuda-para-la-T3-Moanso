namespace Ayuda_para_la_T3_Moanso
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.DESHABILITAR = new System.Windows.Forms.Button();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.LISTAR = new System.Windows.Forms.Button();
            this.AGREGAR = new System.Windows.Forms.Button();
            this.ID_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(366, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 268);
            this.dataGridView1.TabIndex = 31;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(19, 194);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(77, 30);
            this.dni.TabIndex = 29;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(19, 133);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(86, 30);
            this.nombre.TabIndex = 28;
            // 
            // DESHABILITAR
            // 
            this.DESHABILITAR.Location = new System.Drawing.Point(412, 394);
            this.DESHABILITAR.Name = "DESHABILITAR";
            this.DESHABILITAR.Size = new System.Drawing.Size(123, 42);
            this.DESHABILITAR.TabIndex = 27;
            this.DESHABILITAR.Text = "Deshabiliar";
            this.DESHABILITAR.UseVisualStyleBackColor = true;
            // 
            // BUSCAR
            // 
            this.BUSCAR.Location = new System.Drawing.Point(274, 394);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(123, 42);
            this.BUSCAR.TabIndex = 26;
            this.BUSCAR.Text = "Buscar";
            this.BUSCAR.UseVisualStyleBackColor = true;
            // 
            // LISTAR
            // 
            this.LISTAR.Location = new System.Drawing.Point(145, 394);
            this.LISTAR.Name = "LISTAR";
            this.LISTAR.Size = new System.Drawing.Size(123, 42);
            this.LISTAR.TabIndex = 25;
            this.LISTAR.Text = "Listar";
            this.LISTAR.UseVisualStyleBackColor = true;
            // 
            // AGREGAR
            // 
            this.AGREGAR.Location = new System.Drawing.Point(16, 394);
            this.AGREGAR.Name = "AGREGAR";
            this.AGREGAR.Size = new System.Drawing.Size(123, 42);
            this.AGREGAR.TabIndex = 24;
            this.AGREGAR.Text = "Agregar";
            this.AGREGAR.UseVisualStyleBackColor = true;
            // 
            // ID_cliente
            // 
            this.ID_cliente.Location = new System.Drawing.Point(19, 53);
            this.ID_cliente.Name = "ID_cliente";
            this.ID_cliente.Size = new System.Drawing.Size(62, 30);
            this.ID_cliente.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DESHABILITAR);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.BUSCAR);
            this.panel1.Controls.Add(this.ID_cliente);
            this.panel1.Controls.Add(this.LISTAR);
            this.panel1.Controls.Add(this.AGREGAR);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dni);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 445);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button DESHABILITAR;
        private System.Windows.Forms.Button BUSCAR;
        private System.Windows.Forms.Button LISTAR;
        private System.Windows.Forms.Button AGREGAR;
        private System.Windows.Forms.TextBox ID_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}