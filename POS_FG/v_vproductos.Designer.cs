
namespace POS_FG
{
    partial class v_vproductos
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
            this.pb_Minimizar = new System.Windows.Forms.PictureBox();
            this.pb_Cerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.rb_Nombre = new System.Windows.Forms.RadioButton();
            this.rb_Id = new System.Windows.Forms.RadioButton();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.dtgv_Productos = new System.Windows.Forms.DataGridView();
            this.btn_Informe = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pan_Sup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Productos)).BeginInit();
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
            this.pan_Sup.Margin = new System.Windows.Forms.Padding(2);
            this.pan_Sup.Name = "pan_Sup";
            this.pan_Sup.Size = new System.Drawing.Size(909, 37);
            this.pan_Sup.TabIndex = 0;
            this.pan_Sup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_Sup_MouseDown);
            // 
            // lbl_NombreV
            // 
            this.lbl_NombreV.AutoSize = true;
            this.lbl_NombreV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreV.ForeColor = System.Drawing.Color.White;
            this.lbl_NombreV.Location = new System.Drawing.Point(9, 6);
            this.lbl_NombreV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NombreV.Name = "lbl_NombreV";
            this.lbl_NombreV.Size = new System.Drawing.Size(100, 25);
            this.lbl_NombreV.TabIndex = 2;
            this.lbl_NombreV.Text = "Productos";
            this.lbl_NombreV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_NombreV_MouseDown);
            // 
            // pb_Minimizar
            // 
            this.pb_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Minimizar.Image = global::POS_FG.Properties.Resources.minimizar;
            this.pb_Minimizar.Location = new System.Drawing.Point(841, 2);
            this.pb_Minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Minimizar.Name = "pb_Minimizar";
            this.pb_Minimizar.Size = new System.Drawing.Size(23, 28);
            this.pb_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Minimizar.TabIndex = 1;
            this.pb_Minimizar.TabStop = false;
            this.pb_Minimizar.Click += new System.EventHandler(this.pb_Minimizar_Click);
            // 
            // pb_Cerrar
            // 
            this.pb_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Cerrar.Image = global::POS_FG.Properties.Resources.letra_x;
            this.pb_Cerrar.Location = new System.Drawing.Point(877, 2);
            this.pb_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Cerrar.Name = "pb_Cerrar";
            this.pb_Cerrar.Size = new System.Drawing.Size(23, 28);
            this.pb_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Cerrar.TabIndex = 0;
            this.pb_Cerrar.TabStop = false;
            this.pb_Cerrar.Click += new System.EventHandler(this.pb_Cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 545);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(901, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 545);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 578);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(897, 4);
            this.panel3.TabIndex = 2;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_buscar.Location = new System.Drawing.Point(296, 57);
            this.lbl_buscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(52, 17);
            this.lbl_buscar.TabIndex = 11;
            this.lbl_buscar.Text = "Buscar";
            // 
            // rb_Nombre
            // 
            this.rb_Nombre.AutoSize = true;
            this.rb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rb_Nombre.Location = new System.Drawing.Point(371, 83);
            this.rb_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Nombre.Name = "rb_Nombre";
            this.rb_Nombre.Size = new System.Drawing.Size(76, 21);
            this.rb_Nombre.TabIndex = 10;
            this.rb_Nombre.TabStop = true;
            this.rb_Nombre.Text = "Nombre";
            this.rb_Nombre.UseVisualStyleBackColor = true;
            // 
            // rb_Id
            // 
            this.rb_Id.AutoSize = true;
            this.rb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rb_Id.Location = new System.Drawing.Point(456, 83);
            this.rb_Id.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Id.Name = "rb_Id";
            this.rb_Id.Size = new System.Drawing.Size(37, 21);
            this.rb_Id.TabIndex = 9;
            this.rb_Id.TabStop = true;
            this.rb_Id.Text = "Id";
            this.rb_Id.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.DimGray;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Buscar.Image = global::POS_FG.Properties.Resources.lupa;
            this.btn_Buscar.Location = new System.Drawing.Point(525, 49);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(30, 32);
            this.btn_Buscar.TabIndex = 8;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Buscar.Location = new System.Drawing.Point(348, 53);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(174, 26);
            this.txt_Buscar.TabIndex = 7;
            // 
            // dtgv_Productos
            // 
            this.dtgv_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Productos.Location = new System.Drawing.Point(8, 107);
            this.dtgv_Productos.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_Productos.MultiSelect = false;
            this.dtgv_Productos.Name = "dtgv_Productos";
            this.dtgv_Productos.RowHeadersVisible = false;
            this.dtgv_Productos.RowHeadersWidth = 51;
            this.dtgv_Productos.RowTemplate.Height = 24;
            this.dtgv_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Productos.Size = new System.Drawing.Size(889, 464);
            this.dtgv_Productos.TabIndex = 6;
            this.dtgv_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Productos_CellClick);
            this.dtgv_Productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Productos_CellDoubleClick);
            // 
            // btn_Informe
            // 
            this.btn_Informe.BackColor = System.Drawing.Color.DimGray;
            this.btn_Informe.FlatAppearance.BorderSize = 0;
            this.btn_Informe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Informe.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Informe.Image = global::POS_FG.Properties.Resources.imprimir;
            this.btn_Informe.Location = new System.Drawing.Point(856, 71);
            this.btn_Informe.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Informe.Name = "btn_Informe";
            this.btn_Informe.Size = new System.Drawing.Size(40, 31);
            this.btn_Informe.TabIndex = 19;
            this.btn_Informe.UseVisualStyleBackColor = false;
            this.btn_Informe.Click += new System.EventHandler(this.btn_Informe_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Image = global::POS_FG.Properties.Resources.eliminar__1_;
            this.btn_Eliminar.Location = new System.Drawing.Point(812, 71);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(39, 30);
            this.btn_Eliminar.TabIndex = 29;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Activos",
            "Inactivos"});
            this.comboBox1.Location = new System.Drawing.Point(573, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::POS_FG.Properties.Resources.boton_marcado;
            this.button1.Location = new System.Drawing.Point(812, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 30);
            this.button1.TabIndex = 48;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // v_vproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(909, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Informe);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.rb_Nombre);
            this.Controls.Add(this.rb_Id);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.dtgv_Productos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pan_Sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "v_vproductos";
            this.Text = "v_Ventas";
            this.Load += new System.EventHandler(this.v_vproductos_Load);
            this.pan_Sup.ResumeLayout(false);
            this.pan_Sup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_Sup;
        private System.Windows.Forms.PictureBox pb_Cerrar;
        private System.Windows.Forms.PictureBox pb_Minimizar;
        private System.Windows.Forms.Label lbl_NombreV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.RadioButton rb_Nombre;
        private System.Windows.Forms.RadioButton rb_Id;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.DataGridView dtgv_Productos;
        private System.Windows.Forms.Button btn_Informe;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}