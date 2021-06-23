namespace POS_FG
{
    partial class v_EditProducto
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
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dtgv_Producos = new System.Windows.Forms.DataGridView();
            this.txt_Precio_Venta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Precio_Compra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Inv_min = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Inv_Max = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NomProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Busqueda = new System.Windows.Forms.TextBox();
            this.rb_nombre = new System.Windows.Forms.RadioButton();
            this.rb_id = new System.Windows.Forms.RadioButton();
            this.pan_Sup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Producos)).BeginInit();
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
            this.pan_Sup.Size = new System.Drawing.Size(989, 46);
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
            this.lbl_NombreV.Size = new System.Drawing.Size(187, 29);
            this.lbl_NombreV.TabIndex = 2;
            this.lbl_NombreV.Text = "Editar Producto";
            this.lbl_NombreV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_NombreV_MouseDown);
            // 
            // pb_Minimizar
            // 
            this.pb_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Minimizar.Image = global::POS_FG.Properties.Resources.minimizar;
            this.pb_Minimizar.Location = new System.Drawing.Point(899, 2);
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
            this.pb_Cerrar.Location = new System.Drawing.Point(947, 2);
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
            this.panel1.Size = new System.Drawing.Size(5, 585);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(978, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 585);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 626);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 5);
            this.panel3.TabIndex = 2;
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
            this.btn_Modificar.Location = new System.Drawing.Point(237, 377);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(157, 39);
            this.btn_Modificar.TabIndex = 55;
            this.btn_Modificar.Text = "Modificar   ";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Image = global::POS_FG.Properties.Resources.cerrar_el_simbolo_de_la_cruz_en_un_circulo;
            this.btn_Cancelar.Location = new System.Drawing.Point(72, 377);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(157, 39);
            this.btn_Cancelar.TabIndex = 54;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // dtgv_Producos
            // 
            this.dtgv_Producos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Producos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Producos.Location = new System.Drawing.Point(448, 159);
            this.dtgv_Producos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgv_Producos.Name = "dtgv_Producos";
            this.dtgv_Producos.RowHeadersVisible = false;
            this.dtgv_Producos.RowHeadersWidth = 51;
            this.dtgv_Producos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Producos.Size = new System.Drawing.Size(481, 398);
            this.dtgv_Producos.TabIndex = 53;
            this.dtgv_Producos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Producos_CellClick);
            // 
            // txt_Precio_Venta
            // 
            this.txt_Precio_Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio_Venta.Location = new System.Drawing.Point(261, 327);
            this.txt_Precio_Venta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Precio_Venta.Name = "txt_Precio_Venta";
            this.txt_Precio_Venta.Size = new System.Drawing.Size(132, 26);
            this.txt_Precio_Venta.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 331);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Precio Venta";
            // 
            // txt_Precio_Compra
            // 
            this.txt_Precio_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio_Compra.Location = new System.Drawing.Point(261, 286);
            this.txt_Precio_Compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Precio_Compra.Name = "txt_Precio_Compra";
            this.txt_Precio_Compra.Size = new System.Drawing.Size(132, 26);
            this.txt_Precio_Compra.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Precio Compra";
            // 
            // txt_Inv_min
            // 
            this.txt_Inv_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inv_min.Location = new System.Drawing.Point(261, 250);
            this.txt_Inv_min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Inv_min.Name = "txt_Inv_min";
            this.txt_Inv_min.Size = new System.Drawing.Size(132, 26);
            this.txt_Inv_min.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Inventario Min";
            // 
            // txt_Inv_Max
            // 
            this.txt_Inv_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inv_Max.Location = new System.Drawing.Point(261, 204);
            this.txt_Inv_Max.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Inv_Max.Name = "txt_Inv_Max";
            this.txt_Inv_Max.Size = new System.Drawing.Size(132, 26);
            this.txt_Inv_Max.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Inventario Max";
            // 
            // txt_NomProducto
            // 
            this.txt_NomProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomProducto.Location = new System.Drawing.Point(261, 159);
            this.txt_NomProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NomProducto.Name = "txt_NomProducto";
            this.txt_NomProducto.Size = new System.Drawing.Size(132, 26);
            this.txt_NomProducto.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre del Producto";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.DimGray;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Image = global::POS_FG.Properties.Resources.lupa;
            this.btn_Buscar.Location = new System.Drawing.Point(817, 92);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(33, 28);
            this.btn_Buscar.TabIndex = 60;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "Buscar";
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Busqueda.Location = new System.Drawing.Point(557, 94);
            this.txt_Busqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Size = new System.Drawing.Size(252, 26);
            this.txt_Busqueda.TabIndex = 58;
            // 
            // rb_nombre
            // 
            this.rb_nombre.AutoSize = true;
            this.rb_nombre.Location = new System.Drawing.Point(697, 128);
            this.rb_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_nombre.Name = "rb_nombre";
            this.rb_nombre.Size = new System.Drawing.Size(79, 21);
            this.rb_nombre.TabIndex = 57;
            this.rb_nombre.TabStop = true;
            this.rb_nombre.Text = "Nombre";
            this.rb_nombre.UseVisualStyleBackColor = true;
            // 
            // rb_id
            // 
            this.rb_id.AutoSize = true;
            this.rb_id.Location = new System.Drawing.Point(611, 129);
            this.rb_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_id.Name = "rb_id";
            this.rb_id.Size = new System.Drawing.Size(42, 21);
            this.rb_id.TabIndex = 56;
            this.rb_id.TabStop = true;
            this.rb_id.Text = "ID";
            this.rb_id.UseVisualStyleBackColor = true;
            // 
            // v_EditProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(989, 631);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Busqueda);
            this.Controls.Add(this.rb_nombre);
            this.Controls.Add(this.rb_id);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.dtgv_Producos);
            this.Controls.Add(this.txt_Precio_Venta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Precio_Compra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Inv_min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Inv_Max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NomProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pan_Sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "v_EditProducto";
            this.Text = "v_Ventas";
            this.Load += new System.EventHandler(this.v_EditProducto_Load);
            this.pan_Sup.ResumeLayout(false);
            this.pan_Sup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Producos)).EndInit();
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
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridView dtgv_Producos;
        private System.Windows.Forms.TextBox txt_Precio_Venta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Precio_Compra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Inv_min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Inv_Max;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NomProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Busqueda;
        private System.Windows.Forms.RadioButton rb_nombre;
        private System.Windows.Forms.RadioButton rb_id;
    }
}