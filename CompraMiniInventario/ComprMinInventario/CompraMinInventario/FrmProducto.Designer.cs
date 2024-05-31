
namespace CompraMinInventario
{
    partial class FrmProducto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbxGarantia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEnvia = new System.Windows.Forms.Button();
            this.txtbxPrecio = new System.Windows.Forms.TextBox();
            this.txtbxCantidad = new System.Windows.Forms.TextBox();
            this.txtbxDesc = new System.Windows.Forms.TextBox();
            this.txtbxCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtbxGarantia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnEnvia);
            this.panel1.Controls.Add(this.txtbxPrecio);
            this.panel1.Controls.Add(this.txtbxCantidad);
            this.panel1.Controls.Add(this.txtbxDesc);
            this.panel1.Controls.Add(this.txtbxCodigo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 605);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CompraMinInventario.Properties.Resources.lupa16;
            this.button1.Location = new System.Drawing.Point(455, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbxGarantia
            // 
            this.txtbxGarantia.Location = new System.Drawing.Point(240, 373);
            this.txtbxGarantia.Name = "txtbxGarantia";
            this.txtbxGarantia.ReadOnly = true;
            this.txtbxGarantia.Size = new System.Drawing.Size(199, 20);
            this.txtbxGarantia.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Garantia";
            // 
            // btnEnvia
            // 
            this.btnEnvia.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvia.Location = new System.Drawing.Point(201, 448);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(199, 32);
            this.btnEnvia.TabIndex = 12;
            this.btnEnvia.Text = "Envia";
            this.btnEnvia.UseVisualStyleBackColor = true;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // txtbxPrecio
            // 
            this.txtbxPrecio.Location = new System.Drawing.Point(240, 315);
            this.txtbxPrecio.Name = "txtbxPrecio";
            this.txtbxPrecio.ReadOnly = true;
            this.txtbxPrecio.Size = new System.Drawing.Size(199, 20);
            this.txtbxPrecio.TabIndex = 10;
            // 
            // txtbxCantidad
            // 
            this.txtbxCantidad.Location = new System.Drawing.Point(240, 260);
            this.txtbxCantidad.Name = "txtbxCantidad";
            this.txtbxCantidad.Size = new System.Drawing.Size(199, 20);
            this.txtbxCantidad.TabIndex = 9;
            // 
            // txtbxDesc
            // 
            this.txtbxDesc.Location = new System.Drawing.Point(240, 202);
            this.txtbxDesc.Name = "txtbxDesc";
            this.txtbxDesc.ReadOnly = true;
            this.txtbxDesc.Size = new System.Drawing.Size(199, 20);
            this.txtbxDesc.TabIndex = 8;
            // 
            // txtbxCodigo
            // 
            this.txtbxCodigo.Location = new System.Drawing.Point(240, 151);
            this.txtbxCodigo.Name = "txtbxCodigo";
            this.txtbxCodigo.Size = new System.Drawing.Size(199, 20);
            this.txtbxCodigo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Costo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtbxid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 100);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            // 
            // txtbxid
            // 
            this.txtbxid.Location = new System.Drawing.Point(557, 33);
            this.txtbxid.Name = "txtbxid";
            this.txtbxid.ReadOnly = true;
            this.txtbxid.Size = new System.Drawing.Size(25, 20);
            this.txtbxid.TabIndex = 16;
            this.txtbxid.Text = "0";
            this.txtbxid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 605);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbxPrecio;
        private System.Windows.Forms.TextBox txtbxCantidad;
        private System.Windows.Forms.TextBox txtbxDesc;
        private System.Windows.Forms.TextBox txtbxCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnvia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbxGarantia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxid;
    }
}