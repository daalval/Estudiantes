namespace Estudiantes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAnyadir = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelRegistrosPorPagina = new System.Windows.Forms.Label();
            this.numericUpDownRegistros = new System.Windows.Forms.NumericUpDown();
            this.labelPaginas = new System.Windows.Forms.Label();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonUltimo = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonPrimero = new System.Windows.Forms.Button();
            this.dataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Cyan;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estudiantes.Properties.Resources.baseline_person_black_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de estudiantes";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.buttonCancelar);
            this.groupBox2.Controls.Add(this.buttonAnyadir);
            this.groupBox2.Controls.Add(this.labelEmail);
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(this.labelDNI);
            this.groupBox2.Controls.Add(this.textBoxDNI);
            this.groupBox2.Controls.Add(this.labelApellido);
            this.groupBox2.Controls.Add(this.textBoxApellido);
            this.groupBox2.Controls.Add(this.labelNombre);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 396);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.SlateGray;
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Image = global::Estudiantes.Properties.Resources.baseline_delete_white_18dp;
            this.buttonEliminar.Location = new System.Drawing.Point(154, 331);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 37);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.SlateGray;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Image = global::Estudiantes.Properties.Resources.baseline_cancel_white_18dp;
            this.buttonCancelar.Location = new System.Drawing.Point(271, 331);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 37);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAnyadir
            // 
            this.buttonAnyadir.BackColor = System.Drawing.Color.SlateGray;
            this.buttonAnyadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnyadir.FlatAppearance.BorderSize = 0;
            this.buttonAnyadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAnyadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttonAnyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnyadir.Image = global::Estudiantes.Properties.Resources.baseline_add_white_18dp;
            this.buttonAnyadir.Location = new System.Drawing.Point(37, 331);
            this.buttonAnyadir.Name = "buttonAnyadir";
            this.buttonAnyadir.Size = new System.Drawing.Size(94, 37);
            this.buttonAnyadir.TabIndex = 5;
            this.buttonAnyadir.UseVisualStyleBackColor = false;
            this.buttonAnyadir.Click += new System.EventHandler(this.buttonAnyadir_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(230, 263);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(233, 279);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(134, 27);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmail_KeyPress);
            // 
            // labelDNI
            // 
            this.labelDNI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(34, 203);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 7;
            this.labelDNI.Text = "DNI";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(37, 219);
            this.textBoxDNI.Multiline = true;
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(134, 27);
            this.textBoxDNI.TabIndex = 1;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            this.textBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNI_KeyPress);
            // 
            // labelApellido
            // 
            this.labelApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(34, 263);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 5;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(37, 279);
            this.textBoxApellido.Multiline = true;
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(134, 27);
            this.textBoxApellido.TabIndex = 3;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(230, 203);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(233, 219);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(134, 27);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.pictureBoxImage);
            this.groupBox5.Location = new System.Drawing.Point(101, 32);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 157);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImage.Image = global::Estudiantes.Properties.Resources.baseline_person_black_48dp;
            this.pictureBoxImage.Location = new System.Drawing.Point(27, 19);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(146, 123);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.pictureBoxImage_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Información del estudiante";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.labelRegistrosPorPagina);
            this.groupBox3.Controls.Add(this.numericUpDownRegistros);
            this.groupBox3.Controls.Add(this.labelPaginas);
            this.groupBox3.Controls.Add(this.buttonSiguiente);
            this.groupBox3.Controls.Add(this.buttonUltimo);
            this.groupBox3.Controls.Add(this.buttonAnterior);
            this.groupBox3.Controls.Add(this.buttonPrimero);
            this.groupBox3.Controls.Add(this.dataGridViewEstudiantes);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(420, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 396);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // labelRegistrosPorPagina
            // 
            this.labelRegistrosPorPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRegistrosPorPagina.AutoSize = true;
            this.labelRegistrosPorPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrosPorPagina.Location = new System.Drawing.Point(6, 284);
            this.labelRegistrosPorPagina.Name = "labelRegistrosPorPagina";
            this.labelRegistrosPorPagina.Size = new System.Drawing.Size(129, 16);
            this.labelRegistrosPorPagina.TabIndex = 12;
            this.labelRegistrosPorPagina.Text = "Registros/Página";
            // 
            // numericUpDownRegistros
            // 
            this.numericUpDownRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRegistros.Location = new System.Drawing.Point(141, 282);
            this.numericUpDownRegistros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRegistros.Name = "numericUpDownRegistros";
            this.numericUpDownRegistros.Size = new System.Drawing.Size(71, 21);
            this.numericUpDownRegistros.TabIndex = 11;
            this.numericUpDownRegistros.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownRegistros.ValueChanged += new System.EventHandler(this.numericUpDownRegistros_ValueChanged);
            // 
            // labelPaginas
            // 
            this.labelPaginas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPaginas.AutoSize = true;
            this.labelPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaginas.Location = new System.Drawing.Point(236, 312);
            this.labelPaginas.Name = "labelPaginas";
            this.labelPaginas.Size = new System.Drawing.Size(57, 16);
            this.labelPaginas.TabIndex = 10;
            this.labelPaginas.Text = "Página";
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSiguiente.BackColor = System.Drawing.Color.SlateGray;
            this.buttonSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSiguiente.FlatAppearance.BorderSize = 0;
            this.buttonSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttonSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSiguiente.Image = global::Estudiantes.Properties.Resources.baseline_arrow_right_white_18dp1;
            this.buttonSiguiente.Location = new System.Drawing.Point(277, 331);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(94, 37);
            this.buttonSiguiente.TabIndex = 9;
            this.buttonSiguiente.UseVisualStyleBackColor = false;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUltimo.BackColor = System.Drawing.Color.SlateGray;
            this.buttonUltimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUltimo.FlatAppearance.BorderSize = 0;
            this.buttonUltimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonUltimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttonUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUltimo.Image = global::Estudiantes.Properties.Resources.baseline_fast_forward_white_18dp1;
            this.buttonUltimo.Location = new System.Drawing.Point(377, 331);
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.Size = new System.Drawing.Size(94, 37);
            this.buttonUltimo.TabIndex = 8;
            this.buttonUltimo.UseVisualStyleBackColor = false;
            this.buttonUltimo.Click += new System.EventHandler(this.buttonUltimo_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAnterior.BackColor = System.Drawing.Color.SlateGray;
            this.buttonAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnterior.FlatAppearance.BorderSize = 0;
            this.buttonAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttonAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnterior.Image = global::Estudiantes.Properties.Resources.baseline_arrow_left_white_18dp1;
            this.buttonAnterior.Location = new System.Drawing.Point(177, 331);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(94, 37);
            this.buttonAnterior.TabIndex = 7;
            this.buttonAnterior.UseVisualStyleBackColor = false;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonPrimero
            // 
            this.buttonPrimero.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrimero.BackColor = System.Drawing.Color.SlateGray;
            this.buttonPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrimero.FlatAppearance.BorderSize = 0;
            this.buttonPrimero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPrimero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.buttonPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrimero.Image = global::Estudiantes.Properties.Resources.baseline_fast_rewind_white_18dp1;
            this.buttonPrimero.Location = new System.Drawing.Point(77, 331);
            this.buttonPrimero.Name = "buttonPrimero";
            this.buttonPrimero.Size = new System.Drawing.Size(94, 37);
            this.buttonPrimero.TabIndex = 6;
            this.buttonPrimero.UseVisualStyleBackColor = false;
            this.buttonPrimero.Click += new System.EventHandler(this.buttonPrimero_Click);
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEstudiantes.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(6, 39);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(551, 237);
            this.dataGridViewEstudiantes.TabIndex = 2;
            this.dataGridViewEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstudiantes_CellClick);
            this.dataGridViewEstudiantes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridViewEstudiantes_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lista de estudiantes";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxBuscar);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(971, 69);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estudiantes";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(576, 19);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(277, 27);
            this.textBoxBuscar.TabIndex = 8;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 566);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de estudiantes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonAnyadir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
        private System.Windows.Forms.Label labelPaginas;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonUltimo;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonPrimero;
        private System.Windows.Forms.NumericUpDown numericUpDownRegistros;
        private System.Windows.Forms.Label labelRegistrosPorPagina;
    }
}

