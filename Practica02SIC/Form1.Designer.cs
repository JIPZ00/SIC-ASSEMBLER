namespace Practica02SIC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridTablaS = new System.Windows.Forms.DataGridView();
            this.Simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionTabS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridArchInter = new System.Windows.Forms.DataGridView();
            this.NumLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instruccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxErrores = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoCodigoObj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAnalizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbLineas = new System.Windows.Forms.PictureBox();
            this.textBoxEditor = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTablaS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArchInter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1342, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Editor";
            // 
            // dataGridTablaS
            // 
            this.dataGridTablaS.AllowUserToAddRows = false;
            this.dataGridTablaS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTablaS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Simbolo,
            this.DireccionTabS,
            this.Tipo});
            this.dataGridTablaS.Location = new System.Drawing.Point(725, 52);
            this.dataGridTablaS.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridTablaS.Name = "dataGridTablaS";
            this.dataGridTablaS.RowTemplate.Height = 24;
            this.dataGridTablaS.Size = new System.Drawing.Size(309, 289);
            this.dataGridTablaS.TabIndex = 4;
            // 
            // Simbolo
            // 
            this.Simbolo.HeaderText = "Simbolo";
            this.Simbolo.Name = "Simbolo";
            this.Simbolo.ReadOnly = true;
            this.Simbolo.Width = 80;
            // 
            // DireccionTabS
            // 
            this.DireccionTabS.HeaderText = "Direccion";
            this.DireccionTabS.Name = "DireccionTabS";
            this.DireccionTabS.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tabla de Simbolos";
            // 
            // dataGridArchInter
            // 
            this.dataGridArchInter.AllowUserToAddRows = false;
            this.dataGridArchInter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArchInter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumLinea,
            this.CP,
            this.Etiqueta,
            this.Instruccion,
            this.Direccion,
            this.CodigoObjeto,
            this.Error});
            this.dataGridArchInter.Location = new System.Drawing.Point(272, 52);
            this.dataGridArchInter.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridArchInter.Name = "dataGridArchInter";
            this.dataGridArchInter.RowTemplate.Height = 24;
            this.dataGridArchInter.Size = new System.Drawing.Size(440, 475);
            this.dataGridArchInter.TabIndex = 6;
            this.dataGridArchInter.MouseEnter += new System.EventHandler(this.dataGridArchInter_MouseEnter);
            this.dataGridArchInter.MouseLeave += new System.EventHandler(this.dataGridArchInter_MouseLeave);
            // 
            // NumLinea
            // 
            this.NumLinea.HeaderText = "NumLinea";
            this.NumLinea.Name = "NumLinea";
            this.NumLinea.Width = 80;
            // 
            // CP
            // 
            this.CP.HeaderText = "CP";
            this.CP.Name = "CP";
            // 
            // Etiqueta
            // 
            this.Etiqueta.HeaderText = "Etiqueta";
            this.Etiqueta.Name = "Etiqueta";
            // 
            // Instruccion
            // 
            this.Instruccion.HeaderText = "Instruccion";
            this.Instruccion.Name = "Instruccion";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // CodigoObjeto
            // 
            this.CodigoObjeto.HeaderText = "CodigoObjeto";
            this.CodigoObjeto.Name = "CodigoObjeto";
            // 
            // Error
            // 
            this.Error.HeaderText = "Error";
            this.Error.Name = "Error";
            this.Error.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Archivo Intermedio";
            // 
            // textBoxErrores
            // 
            this.textBoxErrores.AcceptsReturn = true;
            this.textBoxErrores.AcceptsTab = true;
            this.textBoxErrores.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxErrores.ForeColor = System.Drawing.Color.Red;
            this.textBoxErrores.Location = new System.Drawing.Point(1047, 52);
            this.textBoxErrores.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxErrores.Multiline = true;
            this.textBoxErrores.Name = "textBoxErrores";
            this.textBoxErrores.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxErrores.Size = new System.Drawing.Size(277, 289);
            this.textBoxErrores.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1044, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Errores";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoCodigoObj
            // 
            this.textBoCodigoObj.Location = new System.Drawing.Point(725, 368);
            this.textBoCodigoObj.Margin = new System.Windows.Forms.Padding(2);
            this.textBoCodigoObj.Multiline = true;
            this.textBoCodigoObj.Name = "textBoCodigoObj";
            this.textBoCodigoObj.Size = new System.Drawing.Size(491, 159);
            this.textBoCodigoObj.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Código Objeto";
            // 
            // buttonAnalizar
            // 
            this.buttonAnalizar.Location = new System.Drawing.Point(1220, 419);
            this.buttonAnalizar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnalizar.Name = "buttonAnalizar";
            this.buttonAnalizar.Size = new System.Drawing.Size(104, 49);
            this.buttonAnalizar.TabIndex = 12;
            this.buttonAnalizar.Text = "ENSAMBLAR";
            this.buttonAnalizar.UseVisualStyleBackColor = true;
            this.buttonAnalizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tamaño del programa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 18;
            // 
            // pbLineas
            // 
            this.pbLineas.Location = new System.Drawing.Point(9, 52);
            this.pbLineas.Margin = new System.Windows.Forms.Padding(2);
            this.pbLineas.Name = "pbLineas";
            this.pbLineas.Size = new System.Drawing.Size(36, 466);
            this.pbLineas.TabIndex = 19;
            this.pbLineas.TabStop = false;
            this.pbLineas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLineas_Paint);
            // 
            // textBoxEditor
            // 
            this.textBoxEditor.AcceptsTab = true;
            this.textBoxEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditor.Location = new System.Drawing.Point(50, 52);
            this.textBoxEditor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEditor.Name = "textBoxEditor";
            this.textBoxEditor.Size = new System.Drawing.Size(218, 467);
            this.textBoxEditor.TabIndex = 6;
            this.textBoxEditor.Text = "";
            this.textBoxEditor.WordWrap = false;
            this.textBoxEditor.SelectionChanged += new System.EventHandler(this.textBoxEditor_SelectionChanged);
            this.textBoxEditor.VScroll += new System.EventHandler(this.textBoxEditor_VScroll);
            this.textBoxEditor.TextChanged += new System.EventHandler(this.textBoxEditor_TextChanged_1);
            this.textBoxEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxEditor_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1342, 551);
            this.Controls.Add(this.textBoxEditor);
            this.Controls.Add(this.pbLineas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAnalizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoCodigoObj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxErrores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridArchInter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridTablaS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTablaS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArchInter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridTablaS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridArchInter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxErrores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoCodigoObj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAnalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instruccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoObjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Error;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbLineas;
        private System.Windows.Forms.RichTextBox textBoxEditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionTabS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}

