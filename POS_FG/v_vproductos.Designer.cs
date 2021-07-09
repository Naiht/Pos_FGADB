
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
            this.pan_Sup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_Sup.Name = "pan_Sup";
            this.pan_Sup.Size = new System.Drawing.Size(1212, 46);
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
            this.lbl_NombreV.Size = new System.Drawing.Size(127, 29);
            this.lbl_NombreV.TabIndex = 2;
            this.lbl_NombreV.Text = "Productos";
            this.lbl_NombreV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_NombreV_MouseDown);
            // 
            // pb_Minimizar
            // 
            this.pb_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Minimizar.Image = global::POS_FG.Properties.Resources.minimizar;
            this.pb_Minimizar.Location = new System.Drawing.Point(1121, 2);
            this.pb_Minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Minimizar.Name = "pb_Minimizar";
            this.pb_Minimizar.Size = new System.Drawing.Size(31, 34);
            this.pb_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Minimizar.TabIndex = 1;
            this.pb_Minimizar.TabStop = false;
            this.pb_Minimizar.Click += new System.EventHandler(this.pb_Minimizar_Click);
            // 
            // pb_Cerrar
            // 
            this.pb_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Cerrar.Image = global::POS_FG.Properties.Resources.letra_x;
            this.pb_Cerrar.Location = new System.Drawing.Point(1169, 2);
            this.pb_Cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Cerrar.Name = "pb_Cerrar";
            this.pb_Cerrar.Size = new System.Drawing.Size(31, 34);
            this.pb_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Cerrar.TabIndex = 0;
            this.pb_Cerrar.TabStop = false;
            this.pb_Cerrar.Click += new System.EventHandler(this.pb_Cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 670);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1201, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 670);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 711);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1196, 5);
            this.panel3.TabIndex = 2;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_buscar.Location = new System.Drawing.Point(395, 70);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(63, 20);
            this.lbl_buscar.TabIndex = 11;
            this.lbl_buscar.Text = "Buscar";
            // 
            // rb_Nombre
            // 
            this.rb_Nombre.AutoSize = true;
            this.rb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rb_Nombre.Location = new System.Drawing.Point(495, 102);
            this.rb_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Nombre.Name = "rb_Nombre";
            this.rb_Nombre.Size = new System.Drawing.Size(89, 24);
            this.rb_Nombre.TabIndex = 10;
            this.rb_Nombre.TabStop = true;
            this.rb_Nombre.Text = "Nombre";
            this.rb_Nombre.UseVisualStyleBackColor = true;
            // 
            // rb_Id
            // 
            this.rb_Id.AutoSize = true;
            this.rb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rb_Id.Location = new System.Drawing.Point(608, 102);
            this.rb_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Id.Name = "rb_Id";
            this.rb_Id.Size = new System.Drawing.Size(43, 24);
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
            this.btn_Buscar.Location = new System.Drawing.Point(700, 60);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(40, 39);
            this.btn_Buscar.TabIndex = 8;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Buscar.Location = new System.Drawing.Point(464, 65);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(231, 30);
            this.txt_Buscar.TabIndex = 7;
            // 
            // dtgv_Productos
            // 
            this.dtgv_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Productos.Location = new System.Drawing.Point(11, 132);
            this.dtgv_Productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_Productos.MultiSelect = false;
            this.dtgv_Productos.Name = "dtgv_Productos";
            this.dtgv_Productos.RowHeadersVisible = false;
            this.dtgv_Productos.RowHeadersWidth = 51;
            this.dtgv_Productos.RowTemplate.Height = 24;
            this.dtgv_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Productos.Size = new System.Drawing.Size(1185, 571);
            this.dtgv_Productos.TabIndex = 6;
            this.dtgv_Productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Productos_CellDoubleClick);
            // 
            // btn_Informe
            // 
            this.btn_Informe.BackColor = System.Drawing.Color.DimGray;
            this.btn_Informe.FlatAppearance.BorderSize = 0;
            this.btn_Informe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Informe.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Informe.Image = global::POS_FG.Properties.Resources.imprimir;
            this.btn_Informe.Location = new System.Drawing.Point(1142, 96);
            this.btn_Informe.Name = "btn_Informe";
            this.btn_Informe.Size = new System.Drawing.Size(53, 30);
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
            this.btn_Eliminar.Location = new System.Drawing.Point(1083, 95);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(52, 30);
            this.btn_Eliminar.TabIndex = 29;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // v_vproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1212, 716);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}