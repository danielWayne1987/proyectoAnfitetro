namespace Anfiteatro_inventario
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.data_anfi = new System.Windows.Forms.DataGridView();
            this.txt_cantidad_min = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.btn_ingresa = new System.Windows.Forms.Button();
            this.btn_actualiza = new System.Windows.Forms.Button();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.txt_cantidad_actual = new System.Windows.Forms.TextBox();
            this.lbl_cantidad_actual = new System.Windows.Forms.Label();
            this.lbl_fecha_ingreso = new System.Windows.Forms.Label();
            this.lbl_nombre_producto = new System.Windows.Forms.Label();
            this.lbl_id_producto = new System.Windows.Forms.Label();
            this.txt_id_producto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_anfi)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.data_anfi);
            this.splitContainer1.Panel2.Controls.Add(this.txt_cantidad_min);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txt_fecha_ingreso);
            this.splitContainer1.Panel2.Controls.Add(this.btn_ingresa);
            this.splitContainer1.Panel2.Controls.Add(this.btn_actualiza);
            this.splitContainer1.Panel2.Controls.Add(this.txt_nombre_producto);
            this.splitContainer1.Panel2.Controls.Add(this.txt_cantidad_actual);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_cantidad_actual);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_fecha_ingreso);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_nombre_producto);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_id_producto);
            this.splitContainer1.Panel2.Controls.Add(this.txt_id_producto);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(774, 388);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 0;
            // 
            // data_anfi
            // 
            this.data_anfi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_anfi.Location = new System.Drawing.Point(3, 195);
            this.data_anfi.Name = "data_anfi";
            this.data_anfi.Size = new System.Drawing.Size(506, 190);
            this.data_anfi.TabIndex = 15;
            // 
            // txt_cantidad_min
            // 
            this.txt_cantidad_min.Location = new System.Drawing.Point(127, 122);
            this.txt_cantidad_min.Name = "txt_cantidad_min";
            this.txt_cantidad_min.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad_min.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cantidad minima";
            // 
            // txt_fecha_ingreso
            // 
            this.txt_fecha_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha_ingreso.Location = new System.Drawing.Point(128, 68);
            this.txt_fecha_ingreso.Name = "txt_fecha_ingreso";
            this.txt_fecha_ingreso.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_ingreso.TabIndex = 12;
            // 
            // btn_ingresa
            // 
            this.btn_ingresa.Location = new System.Drawing.Point(394, 164);
            this.btn_ingresa.Name = "btn_ingresa";
            this.btn_ingresa.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresa.TabIndex = 11;
            this.btn_ingresa.Text = "Ingresar";
            this.btn_ingresa.UseVisualStyleBackColor = true;
            this.btn_ingresa.Click += new System.EventHandler(this.btn_ingresa_Click);
            // 
            // btn_actualiza
            // 
            this.btn_actualiza.Location = new System.Drawing.Point(46, 164);
            this.btn_actualiza.Name = "btn_actualiza";
            this.btn_actualiza.Size = new System.Drawing.Size(75, 23);
            this.btn_actualiza.TabIndex = 10;
            this.btn_actualiza.Text = "Actualizar";
            this.btn_actualiza.UseVisualStyleBackColor = true;
            this.btn_actualiza.Click += new System.EventHandler(this.btn_actualiza_Click);
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.Location = new System.Drawing.Point(128, 40);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_producto.TabIndex = 9;
            // 
            // txt_cantidad_actual
            // 
            this.txt_cantidad_actual.Location = new System.Drawing.Point(128, 94);
            this.txt_cantidad_actual.Name = "txt_cantidad_actual";
            this.txt_cantidad_actual.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad_actual.TabIndex = 8;
            this.txt_cantidad_actual.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_cantidad_actual
            // 
            this.lbl_cantidad_actual.AutoSize = true;
            this.lbl_cantidad_actual.Location = new System.Drawing.Point(53, 97);
            this.lbl_cantidad_actual.Name = "lbl_cantidad_actual";
            this.lbl_cantidad_actual.Size = new System.Drawing.Size(49, 13);
            this.lbl_cantidad_actual.TabIndex = 6;
            this.lbl_cantidad_actual.Text = "Cantidad";
            this.lbl_cantidad_actual.Click += new System.EventHandler(this.lbl_cantidad_actual_Click);
            // 
            // lbl_fecha_ingreso
            // 
            this.lbl_fecha_ingreso.AutoSize = true;
            this.lbl_fecha_ingreso.Location = new System.Drawing.Point(13, 68);
            this.lbl_fecha_ingreso.Name = "lbl_fecha_ingreso";
            this.lbl_fecha_ingreso.Size = new System.Drawing.Size(89, 13);
            this.lbl_fecha_ingreso.TabIndex = 5;
            this.lbl_fecha_ingreso.Text = "Fecha de ingreso";
            // 
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;
            this.lbl_nombre_producto.Location = new System.Drawing.Point(52, 43);
            this.lbl_nombre_producto.Name = "lbl_nombre_producto";
            this.lbl_nombre_producto.Size = new System.Drawing.Size(50, 13);
            this.lbl_nombre_producto.TabIndex = 4;
            this.lbl_nombre_producto.Text = "Producto";
            // 
            // lbl_id_producto
            // 
            this.lbl_id_producto.AutoSize = true;
            this.lbl_id_producto.Location = new System.Drawing.Point(74, 17);
            this.lbl_id_producto.Name = "lbl_id_producto";
            this.lbl_id_producto.Size = new System.Drawing.Size(18, 13);
            this.lbl_id_producto.TabIndex = 3;
            this.lbl_id_producto.Text = "ID";
            // 
            // txt_id_producto
            // 
            this.txt_id_producto.Location = new System.Drawing.Point(128, 10);
            this.txt_id_producto.Name = "txt_id_producto";
            this.txt_id_producto.Size = new System.Drawing.Size(100, 20);
            this.txt_id_producto.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 388);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_anfi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_nombre_producto;
        private System.Windows.Forms.TextBox txt_cantidad_actual;
        private System.Windows.Forms.Label lbl_cantidad_actual;
        private System.Windows.Forms.Label lbl_fecha_ingreso;
        private System.Windows.Forms.Label lbl_nombre_producto;
        private System.Windows.Forms.Label lbl_id_producto;
        private System.Windows.Forms.TextBox txt_id_producto;
        private System.Windows.Forms.Button btn_actualiza;
        private System.Windows.Forms.Button btn_ingresa;
        private System.Windows.Forms.DateTimePicker txt_fecha_ingreso;
        private System.Windows.Forms.TextBox txt_cantidad_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_anfi;
    }
}