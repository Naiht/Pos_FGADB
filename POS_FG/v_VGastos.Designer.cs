namespace POS_FG
{
    partial class v_VGastos
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
            this.dtgv_vgastos = new System.Windows.Forms.DataGridView();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.rb_Descripcion = new System.Windows.Forms.RadioButton();
            this.rb_Rango = new System.Windows.Forms.RadioButton();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.dtp_finicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_ffinal = new System.Windows.Forms.DateTimePicker();
            this.rb_Todos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pan_Sup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_vgastos)).BeginInit();
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
            this.pan_Sup.Size = new System.Drawing.Size(742, 37);
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
            this.lbl_NombreV.Size = new System.Drawing.Size(74, 25);
            this.lbl_NombreV.TabIndex = 2;
            this.lbl_NombreV.Text = "Gastos";
            this.lbl_NombreV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_NombreV_MouseDown);
            // 
            // pb_Minimizar
            // 
            this.pb_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Minimizar.Image = global::POS_FG.Properties.Resources.minimizar;
            this.pb_Minimizar.Location = new System.Drawing.Point(674, 2);
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
            this.pb_Cerrar.Location = new System.Drawing.Point(710, 2);
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
            this.panel1.Size = new System.Drawing.Size(4, 408);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(734, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 408);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 441);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 4);
            this.panel3.TabIndex = 2;
            // 
            // dtgv_vgastos
            // 
            this.dtgv_vgastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_vgastos.Location = new System.Drawing.Point(185, 194);
            this.dtgv_vgastos.Name = "dtgv_vgastos";
            this.dtgv_vgastos.ReadOnly = true;
            this.dtgv_vgastos.Size = new System.Drawing.Size(385, 227);
            this.dtgv_vgastos.TabIndex = 4;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_buscar.Location = new System.Drawing.Point(51, 73);
            this.lbl_buscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(82, 17);
            this.lbl_buscar.TabIndex = 10;
            this.lbl_buscar.Text = "Descripcion";
            // 
            // rb_Descripcion
            // 
            this.rb_Descripcion.AutoSize = true;
            this.rb_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rb_Descripcion.Location = new System.Drawing.Point(400, 71);
            this.rb_Descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Descripcion.Name = "rb_Descripcion";
            this.rb_Descripcion.Size = new System.Drawing.Size(100, 21);
            this.rb_Descripcion.TabIndex = 9;
            this.rb_Descripcion.TabStop = true;
            this.rb_Descripcion.Text = "Descripcion";
            this.rb_Descripcion.UseVisualStyleBackColor = true;
            // 
            // rb_Rango
            // 
            this.rb_Rango.AutoSize = true;
            this.rb_Rango.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rb_Rango.Location = new System.Drawing.Point(400, 113);
            this.rb_Rango.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Rango.Name = "rb_Rango";
            this.rb_Rango.Size = new System.Drawing.Size(133, 21);
            this.rb_Rango.TabIndex = 8;
            this.rb_Rango.TabStop = true;
            this.rb_Rango.Text = "Rango De Fecha";
            this.rb_Rango.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.DimGray;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.Image = global::POS_FG.Properties.Resources.lupa;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.Location = new System.Drawing.Point(583, 107);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(114, 32);
            this.btn_Buscar.TabIndex = 7;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_descripcion.Location = new System.Drawing.Point(137, 67);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(203, 26);
            this.txt_descripcion.TabIndex = 6;
            this.txt_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_KeyPress);
            // 
            // dtp_finicial
            // 
            this.dtp_finicial.CustomFormat = "MM/DD/AAAA";
            this.dtp_finicial.Location = new System.Drawing.Point(145, 111);
            this.dtp_finicial.Name = "dtp_finicial";
            this.dtp_finicial.Size = new System.Drawing.Size(200, 20);
            this.dtp_finicial.TabIndex = 11;
            // 
            // dtp_ffinal
            // 
            this.dtp_ffinal.Location = new System.Drawing.Point(145, 154);
            this.dtp_ffinal.Name = "dtp_ffinal";
            this.dtp_ffinal.Size = new System.Drawing.Size(200, 20);
            this.dtp_ffinal.TabIndex = 12;
            // 
            // rb_Todos
            // 
            this.rb_Todos.AutoSize = true;
            this.rb_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rb_Todos.Location = new System.Drawing.Point(400, 153);
            this.rb_Todos.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Todos.Name = "rb_Todos";
            this.rb_Todos.Size = new System.Drawing.Size(66, 21);
            this.rb_Todos.TabIndex = 13;
            this.rb_Todos.TabStop = true;
            this.rb_Todos.Text = "Todos";
            this.rb_Todos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(51, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(51, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha Final";
            // 
            // v_VGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(742, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_Todos);
            this.Controls.Add(this.dtp_ffinal);
            this.Controls.Add(this.dtp_finicial);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.rb_Descripcion);
            this.Controls.Add(this.rb_Rango);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.dtgv_vgastos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pan_Sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "v_VGastos";
            this.Text = "v_Ventas";
            this.Load += new System.EventHandler(this.v_VGastos_Load);
            this.pan_Sup.ResumeLayout(false);
            this.pan_Sup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_vgastos)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgv_vgastos;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.RadioButton rb_Descripcion;
        private System.Windows.Forms.RadioButton rb_Rango;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.DateTimePicker dtp_finicial;
        private System.Windows.Forms.DateTimePicker dtp_ffinal;
        private System.Windows.Forms.RadioButton rb_Todos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}