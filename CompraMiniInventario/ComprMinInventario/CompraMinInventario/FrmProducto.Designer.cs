
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
            this.txtbxTotal = new System.Windows.Forms.TextBox();
            this.txtbxPrecio = new System.Windows.Forms.TextBox();
            this.txtbxCantidad = new System.Windows.Forms.TextBox();
            this.txtbxDesc = new System.Windows.Forms.TextBox();
            this.txtbxCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnvia = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEnvia);
            this.panel1.Controls.Add(this.txtbxTotal);
            this.panel1.Controls.Add(this.txtbxPrecio);
            this.panel1.Controls.Add(this.txtbxCantidad);
            this.panel1.Controls.Add(this.txtbxDesc);
            this.panel1.Controls.Add(this.txtbxCodigo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 511);
            this.panel1.TabIndex = 0;
            // 
            // txtbxTotal
            // 
            this.txtbxTotal.Location = new System.Drawing.Point(240, 369);
            this.txtbxTotal.Name = "txtbxTotal";
            this.txtbxTotal.ReadOnly = true;
            this.txtbxTotal.Size = new System.Drawing.Size(199, 20);
            this.txtbxTotal.TabIndex = 11;
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
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total";
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 100);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            // 
            // btnEnvia
            // 
            this.btnEnvia.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvia.Location = new System.Drawing.Point(240, 429);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(199, 32);
            this.btnEnvia.TabIndex = 12;
            this.btnEnvia.Text = "Envia";
            this.btnEnvia.UseVisualStyleBackColor = true;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 511);
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
        private System.Windows.Forms.TextBox txtbxTotal;
        private System.Windows.Forms.TextBox txtbxPrecio;
        private System.Windows.Forms.TextBox txtbxCantidad;
        private System.Windows.Forms.TextBox txtbxDesc;
        private System.Windows.Forms.TextBox txtbxCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnvia;
    }
}