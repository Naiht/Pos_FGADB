namespace POS_FG
{
    partial class v_EditProv
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID_Proveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NomProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.dtgv_proveedores = new System.Windows.Forms.DataGridView();
            this.rb_id = new System.Windows.Forms.RadioButton();
            this.rb_nombre = new System.Windows.Forms.RadioButton();
            this.txt_Busqueda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dtgv_Telefonos = new System.Windows.Forms.DataGridView();
            this.dtgv_eliminar = new System.Windows.Forms.DataGridView();
            this.dtgv_agregar = new System.Windows.Forms.DataGridView();
            this.pan_Sup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Telefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_agregar)).BeginInit();
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
            this.pan_Sup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pan_Sup.Name = "pan_Sup";
            this.pan_Sup.Size = new System.Drawing.Size(784, 37);
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
            this.lbl_NombreV.Size = new System.Drawing.Size(157, 25);
            this.lbl_NombreV.TabIndex = 2;
            this.lbl_NombreV.Text = "Editar Proveedor";
            this.lbl_NombreV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_NombreV_MouseDown);
            // 
            // pb_Minimizar
            // 
            this.pb_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Minimizar.Image = global::POS_FG.Properties.Resources.minimizar;
            this.pb_Minimizar.Location = new System.Drawing.Point(716, 2);
            this.pb_Minimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.pb_Cerrar.Location = new System.Drawing.Point(752, 2);
            this.pb_Cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 466);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(780, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 466);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 499);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 4);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "RUC";
            // 
            // txt_ID_Proveedor
            // 
            this.txt_ID_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_Proveedor.Location = new System.Drawing.Point(183, 74);
            this.txt_ID_Proveedor.Name = "txt_ID_Proveedor";
            this.txt_ID_Proveedor.Size = new System.Drawing.Size(100, 23);
            this.txt_ID_Proveedor.TabIndex = 4;
            this.txt_ID_Proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_Proveedor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre del Proveedor";
            // 
            // txt_NomProveedor
            // 
            this.txt_NomProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomProveedor.Location = new System.Drawing.Point(183, 119);
            this.txt_NomProveedor.MaxLength = 35;
            this.txt_NomProveedor.Name = "txt_NomProveedor";
            this.txt_NomProveedor.Size = new System.Drawing.Size(186, 23);
            this.txt_NomProveedor.TabIndex = 23;
            this.txt_NomProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NomProveedor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Telefono";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(183, 165);
            this.txt_Telefono.MaxLength = 8;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 23);
            this.txt_Telefono.TabIndex = 26;
            this.txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_KeyPress);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Image = global::POS_FG.Properties.Resources.cerrar_el_simbolo_de_la_cruz_en_un_circulo;
            this.btn_Cancelar.Location = new System.Drawing.Point(134, 461);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(118, 32);
            this.btn_Cancelar.TabIndex = 28;
            this.btn_Cancelar.Text = "Cancelar ";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.DimGray;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.Image = global::POS_FG.Properties.Resources.telefono;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.Location = new System.Drawing.Point(59, 206);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(118, 32);
            this.btn_Agregar.TabIndex = 27;
            this.btn_Agregar.Text = "Agregar ";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Image = global::POS_FG.Properties.Resources.boton_marcado;
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Modificar.Location = new System.Drawing.Point(499, 461);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(118, 32);
            this.btn_Modificar.TabIndex = 21;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Remover.FlatAppearance.BorderSize = 0;
            this.btn_Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remover.ForeColor = System.Drawing.Color.White;
            this.btn_Remover.Image = global::POS_FG.Properties.Resources.telefono;
            this.btn_Remover.Location = new System.Drawing.Point(59, 254);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(118, 32);
            this.btn_Remover.TabIndex = 29;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // dtgv_proveedores
            // 
            this.dtgv_proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_proveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_proveedores.Location = new System.Drawing.Point(432, 119);
            this.dtgv_proveedores.Name = "dtgv_proveedores";
            this.dtgv_proveedores.RowHeadersVisible = false;
            this.dtgv_proveedores.RowHeadersWidth = 51;
            this.dtgv_proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_proveedores.Size = new System.Drawing.Size(324, 320);
            this.dtgv_proveedores.TabIndex = 30;
            this.dtgv_proveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_proveedores_CellClick);
            // 
            // rb_id
            // 
            this.rb_id.AutoSize = true;
            this.rb_id.Location = new System.Drawing.Point(538, 96);
            this.rb_id.Name = "rb_id";
            this.rb_id.Size = new System.Drawing.Size(48, 17);
            this.rb_id.TabIndex = 31;
            this.rb_id.TabStop = true;
            this.rb_id.Text = "RUC";
            this.rb_id.UseVisualStyleBackColor = true;
            // 
            // rb_nombre
            // 
            this.rb_nombre.AutoSize = true;
            this.rb_nombre.Location = new System.Drawing.Point(606, 96);
            this.rb_nombre.Name = "rb_nombre";
            this.rb_nombre.Size = new System.Drawing.Size(62, 17);
            this.rb_nombre.TabIndex = 32;
            this.rb_nombre.TabStop = true;
            this.rb_nombre.Text = "Nombre";
            this.rb_nombre.UseVisualStyleBackColor = true;
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Busqueda.Location = new System.Drawing.Point(499, 67);
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Size = new System.Drawing.Size(190, 23);
            this.txt_Busqueda.TabIndex = 33;
            this.txt_Busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Busqueda_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Buscar";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.DimGray;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Image = global::POS_FG.Properties.Resources.lupa;
            this.btn_Buscar.Location = new System.Drawing.Point(695, 64);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(29, 29);
            this.btn_Buscar.TabIndex = 35;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dtgv_Telefonos
            // 
            this.dtgv_Telefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Telefonos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Telefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Telefonos.Location = new System.Drawing.Point(183, 207);
            this.dtgv_Telefonos.Name = "dtgv_Telefonos";
            this.dtgv_Telefonos.RowHeadersVisible = false;
            this.dtgv_Telefonos.RowHeadersWidth = 51;
            this.dtgv_Telefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Telefonos.Size = new System.Drawing.Size(100, 150);
            this.dtgv_Telefonos.TabIndex = 24;
            this.dtgv_Telefonos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Telefonos_CellClick);
            this.dtgv_Telefonos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Telefonos_CellDoubleClick);
            // 
            // dtgv_eliminar
            // 
            this.dtgv_eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_eliminar.Location = new System.Drawing.Point(59, 305);
            this.dtgv_eliminar.Name = "dtgv_eliminar";
            this.dtgv_eliminar.RowHeadersVisible = false;
            this.dtgv_eliminar.RowHeadersWidth = 51;
            this.dtgv_eliminar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_eliminar.Size = new System.Drawing.Size(100, 150);
            this.dtgv_eliminar.TabIndex = 24;
            // 
            // dtgv_agregar
            // 
            this.dtgv_agregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_agregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_agregar.Location = new System.Drawing.Point(302, 305);
            this.dtgv_agregar.Name = "dtgv_agregar";
            this.dtgv_agregar.RowHeadersVisible = false;
            this.dtgv_agregar.RowHeadersWidth = 51;
            this.dtgv_agregar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_agregar.Size = new System.Drawing.Size(100, 150);
            this.dtgv_agregar.TabIndex = 24;
            // 
            // v_EditProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 503);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Busqueda);
            this.Controls.Add(this.rb_nombre);
            this.Controls.Add(this.rb_id);
            this.Controls.Add(this.dtgv_proveedores);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgv_agregar);
            this.Controls.Add(this.dtgv_eliminar);
            this.Controls.Add(this.dtgv_Telefonos);
            this.Controls.Add(this.txt_NomProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.txt_ID_Proveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pan_Sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "v_EditProv";
            this.Text = "v_Ventas";
            this.Load += new System.EventHandler(this.v_proveedor_Load);
            this.pan_Sup.ResumeLayout(false);
            this.pan_Sup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Telefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_agregar)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox txt_ID_Proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NomProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.DataGridView dtgv_proveedores;
        private System.Windows.Forms.RadioButton rb_id;
        private System.Windows.Forms.RadioButton rb_nombre;
        private System.Windows.Forms.TextBox txt_Busqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dtgv_Telefonos;
        private System.Windows.Forms.DataGridView dtgv_eliminar;
        private System.Windows.Forms.DataGridView dtgv_agregar;
    }
}