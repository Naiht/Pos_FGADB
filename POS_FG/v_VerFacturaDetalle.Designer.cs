namespace POS_FG
{
    partial class v_VerFacturaDetalle
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
            this.pan_Sup = new System.Windows.Forms.Panel();
            this.lbl_NombreV = new System.Windows.Forms.Label();
            this.pb_Cerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_FacturaD = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.pan_Sup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_FacturaD)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Sup
            // 
            this.pan_Sup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.pan_Sup.Controls.Add(this.lbl_NombreV);
            this.pan_Sup.Controls.Add(this.pb_Cerrar);
            this.pan_Sup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_Sup.Location = new System.Drawing.Point(0, 0);
            this.pan_Sup.Name = "pan_Sup";
            this.pan_Sup.Size = new System.Drawing.Size(545, 45);
            this.pan_Sup.TabIndex = 0;
            this.pan_Sup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_Sup_MouseDown);
            // 
            // lbl_NombreV
            // 
            this.lbl_NombreV.AutoSize = true;
            this.lbl_NombreV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreV.ForeColor = System.Drawing.Color.White;
            this.lbl_NombreV.Location = new System.Drawing.Point(12, 7);
            this.lbl_NombreV.Name = "lbl_NombreV";
            this.lbl_NombreV.Size = new System.Drawing.Size(211, 29);
            this.lbl_NombreV.TabIndex = 2;
            this.lbl_NombreV.Text = "Detalle de factura";
            this.lbl_NombreV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_NombreV_MouseDown);
            // 
            // pb_Cerrar
            // 
            this.pb_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Cerrar.Image = global::POS_FG.Properties.Resources.letra_x;
            this.pb_Cerrar.Location = new System.Drawing.Point(502, 3);
            this.pb_Cerrar.Name = "pb_Cerrar";
            this.pb_Cerrar.Size = new System.Drawing.Size(31, 35);
            this.pb_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Cerrar.TabIndex = 0;
            this.pb_Cerrar.TabStop = false;
            this.pb_Cerrar.Click += new System.EventHandler(this.pb_Cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 472);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(535, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 472);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 512);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 5);
            this.panel3.TabIndex = 2;
            // 
            // dtgv_FacturaD
            // 
            this.dtgv_FacturaD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_FacturaD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_FacturaD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_FacturaD.Location = new System.Drawing.Point(17, 102);
            this.dtgv_FacturaD.Name = "dtgv_FacturaD";
            this.dtgv_FacturaD.RowHeadersVisible = false;
            this.dtgv_FacturaD.RowHeadersWidth = 51;
            this.dtgv_FacturaD.RowTemplate.Height = 24;
            this.dtgv_FacturaD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_FacturaD.Size = new System.Drawing.Size(504, 396);
            this.dtgv_FacturaD.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Image = global::POS_FG.Properties.Resources.imprimir;
            this.button1.Location = new System.Drawing.Point(468, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 30);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Image = global::POS_FG.Properties.Resources.eliminar__1_;
            this.btn_Eliminar.Location = new System.Drawing.Point(409, 65);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(52, 30);
            this.btn_Eliminar.TabIndex = 30;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // v_VerFacturaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(545, 517);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgv_FacturaD);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pan_Sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "v_VerFacturaDetalle";
            this.Text = "v_Ventas";
            this.Load += new System.EventHandler(this.v_VerFacturaDetalle_Load);
            this.pan_Sup.ResumeLayout(false);
            this.pan_Sup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_FacturaD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_Sup;
        private System.Windows.Forms.PictureBox pb_Cerrar;
        private System.Windows.Forms.Label lbl_NombreV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgv_FacturaD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}