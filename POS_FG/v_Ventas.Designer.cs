namespace POS_FG
{
    partial class v_Ventas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pan_Producto = new System.Windows.Forms.Panel();
            this.dtgv_ProductosV = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rb_Id = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.pb_Minimizar = new System.Windows.Forms.PictureBox();
            this.pb_Cerrar = new System.Windows.Forms.PictureBox();
            this.pan_Sup.SuspendLayout();
            this.pan_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ProductosV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Sup
            // 
            this.pan_Sup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.pan_Sup.Controls.Add(this.lbl_NombreV);
            this.pan_Sup.Controls.Add(this.pb_Minimizar);
            this.pan_Sup.Controls.Add(this.pb_Cerrar);
            this.pan_Sup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_Sup.Location = new System.Drawing.Point(0, 0);
            this.pan_Sup.Name = "pan_Sup";
            this.pan_Sup.Size = new System.Drawing.Size(909, 45);
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
            this.lbl_NombreV.Size = new System.Drawing.Size(92, 29);
            this.lbl_NombreV.TabIndex = 2;
            this.lbl_NombreV.Text = "Ventas";
            this.lbl_NombreV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_NombreV_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 716);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(904, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 716);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 756);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 5);
            this.panel3.TabIndex = 2;
            // 
            // pan_Producto
            // 
            this.pan_Producto.BackColor = System.Drawing.Color.LightGray;
            this.pan_Producto.Controls.Add(this.lbl_buscar);
            this.pan_Producto.Controls.Add(this.radioButton1);
            this.pan_Producto.Controls.Add(this.rb_Id);
            this.pan_Producto.Controls.Add(this.button1);
            this.pan_Producto.Controls.Add(this.textBox1);
            this.pan_Producto.Controls.Add(this.dtgv_ProductosV);
            this.pan_Producto.Dock = System.Windows.Forms.DockStyle.Right;
            this.pan_Producto.Location = new System.Drawing.Point(496, 45);
            this.pan_Producto.Name = "pan_Producto";
            this.pan_Producto.Size = new System.Drawing.Size(408, 711);
            this.pan_Producto.TabIndex = 3;
            // 
            // dtgv_ProductosV
            // 
            this.dtgv_ProductosV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_ProductosV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ProductosV.Location = new System.Drawing.Point(16, 123);
            this.dtgv_ProductosV.Name = "dtgv_ProductosV";
            this.dtgv_ProductosV.RowHeadersVisible = false;
            this.dtgv_ProductosV.RowHeadersWidth = 51;
            this.dtgv_ProductosV.RowTemplate.Height = 24;
            this.dtgv_ProductosV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ProductosV.Size = new System.Drawing.Size(377, 569);
            this.dtgv_ProductosV.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(90, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 30);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(339, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 30);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // rb_Id
            // 
            this.rb_Id.AutoSize = true;
            this.rb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rb_Id.Location = new System.Drawing.Point(125, 71);
            this.rb_Id.Name = "rb_Id";
            this.rb_Id.Size = new System.Drawing.Size(43, 24);
            this.rb_Id.TabIndex = 3;
            this.rb_Id.TabStop = true;
            this.rb_Id.Text = "Id";
            this.rb_Id.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton1.Location = new System.Drawing.Point(204, 71);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_buscar.Location = new System.Drawing.Point(21, 39);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(63, 20);
            this.lbl_buscar.TabIndex = 5;
            this.lbl_buscar.Text = "Buscar";
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Finalizar.FlatAppearance.BorderSize = 0;
            this.btn_Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finalizar.ForeColor = System.Drawing.Color.White;
            this.btn_Finalizar.Location = new System.Drawing.Point(281, 691);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(142, 40);
            this.btn_Finalizar.TabIndex = 6;
            this.btn_Finalizar.Text = "Finalizar";
            this.btn_Finalizar.UseVisualStyleBackColor = false;
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.Color.DimGray;
            this.btn_Remover.FlatAppearance.BorderSize = 0;
            this.btn_Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remover.ForeColor = System.Drawing.Color.White;
            this.btn_Remover.Location = new System.Drawing.Point(331, 64);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(142, 40);
            this.btn_Remover.TabIndex = 8;
            this.btn_Remover.Text = "Finalizar";
            this.btn_Remover.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Image = global::POS_FG.Properties.Resources.cerrar_el_simbolo_de_la_cruz_en_un_circulo;
            this.btn_Cancelar.Location = new System.Drawing.Point(68, 691);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(142, 40);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // pb_Minimizar
            // 
            this.pb_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Minimizar.Image = global::POS_FG.Properties.Resources.minimizar;
            this.pb_Minimizar.Location = new System.Drawing.Point(817, 3);
            this.pb_Minimizar.Name = "pb_Minimizar";
            this.pb_Minimizar.Size = new System.Drawing.Size(31, 35);
            this.pb_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Minimizar.TabIndex = 1;
            this.pb_Minimizar.TabStop = false;
            this.pb_Minimizar.Click += new System.EventHandler(this.pb_Minimizar_Click);
            // 
            // pb_Cerrar
            // 
            this.pb_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Cerrar.Image = global::POS_FG.Properties.Resources.letra_x;
            this.pb_Cerrar.Location = new System.Drawing.Point(866, 3);
            this.pb_Cerrar.Name = "pb_Cerrar";
            this.pb_Cerrar.Size = new System.Drawing.Size(31, 35);
            this.pb_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Cerrar.TabIndex = 0;
            this.pb_Cerrar.TabStop = false;
            this.pb_Cerrar.Click += new System.EventHandler(this.pb_Cerrar_Click);
            // 
            // v_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(909, 761);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.pan_Producto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pan_Sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "v_Ventas";
            this.Text = "v_Ventas";
            this.Load += new System.EventHandler(this.v_Ventas_Load);
            this.pan_Sup.ResumeLayout(false);
            this.pan_Sup.PerformLayout();
            this.pan_Producto.ResumeLayout(false);
            this.pan_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ProductosV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_Sup;
        private System.Windows.Forms.PictureBox pb_Cerrar;
        private System.Windows.Forms.PictureBox pb_Minimizar;
        private System.Windows.Forms.Label lbl_NombreV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pan_Producto;
        private System.Windows.Forms.DataGridView dtgv_ProductosV;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rb_Id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Finalizar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Remover;
    }
}