namespace EPS_Salvando_Vidas
{
    partial class FormUserData
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
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label12 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            groupBox2 = new GroupBox();
            rbExamenLaboratorio = new RadioButton();
            rbMedicinaGeneral = new RadioButton();
            numEdad = new TextBox();
            label9 = new Label();
            txtNumeroIdentificacion = new TextBox();
            label8 = new Label();
            cmbEstructura = new ComboBox();
            label7 = new Label();
            txtCopago = new TextBox();
            label6 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            cmbEstrato = new ComboBox();
            label4 = new Label();
            cmbTipoID = new ComboBox();
            label1 = new Label();
            dgvPila = new DataGridView();
            TipodeID = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Estrato = new DataGridViewTextBoxColumn();
            TipodeAtencion = new DataGridViewTextBoxColumn();
            Valordelcopago = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            pilaTab = new TabPage();
            colaTab = new TabPage();
            dgvCola = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            listaTab = new TabPage();
            dgvLista = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPila).BeginInit();
            tabControl1.SuspendLayout();
            pilaTab.SuspendLayout();
            colaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCola).BeginInit();
            listaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(350, 48);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 8;
            label3.Text = "EPS Salvando vidas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(251, 22);
            label2.Name = "label2";
            label2.Size = new Size(312, 17);
            label2.TabIndex = 7;
            label2.Text = "SISTEMA DE REGISTRO DE USUARIOS EN CENTRO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(numEdad);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtNumeroIdentificacion);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbEstructura);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCopago);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbEstrato);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbTipoID);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(19, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(757, 313);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del usuario";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(419, 285);
            label12.Name = "label12";
            label12.Size = new Size(258, 15);
            label12.TabIndex = 31;
            label12.Text = "Los campos marcados con (*) son obligatorios.";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(171, 265);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(142, 23);
            textBox5.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 273);
            label11.Name = "label11";
            label11.Size = new Size(106, 15);
            label11.TabIndex = 29;
            label11.Text = "Reporte de datos:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(615, 236);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 28);
            btnSalir.TabIndex = 28;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button3_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(489, 236);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(107, 28);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button2_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(347, 236);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(107, 28);
            btnRegistrar.TabIndex = 26;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(512, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(123, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(347, 183);
            label10.Name = "label10";
            label10.Size = new Size(107, 15);
            label10.TabIndex = 24;
            label10.Text = "* Fecha de acceso:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbExamenLaboratorio);
            groupBox2.Controls.Add(rbMedicinaGeneral);
            groupBox2.Location = new Point(354, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(311, 50);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de atencion";
            // 
            // rbExamenLaboratorio
            // 
            rbExamenLaboratorio.AutoSize = true;
            rbExamenLaboratorio.Location = new Point(155, 18);
            rbExamenLaboratorio.Name = "rbExamenLaboratorio";
            rbExamenLaboratorio.Size = new Size(150, 19);
            rbExamenLaboratorio.TabIndex = 1;
            rbExamenLaboratorio.TabStop = true;
            rbExamenLaboratorio.Text = "Examen de laboratorio";
            rbExamenLaboratorio.UseVisualStyleBackColor = true;
            rbExamenLaboratorio.CheckedChanged += rbExamenLaboratorio_CheckedChanged;
            // 
            // rbMedicinaGeneral
            // 
            rbMedicinaGeneral.AutoSize = true;
            rbMedicinaGeneral.Location = new Point(6, 18);
            rbMedicinaGeneral.Name = "rbMedicinaGeneral";
            rbMedicinaGeneral.Size = new Size(120, 19);
            rbMedicinaGeneral.TabIndex = 0;
            rbMedicinaGeneral.TabStop = true;
            rbMedicinaGeneral.Text = "Medicina general";
            rbMedicinaGeneral.UseVisualStyleBackColor = true;
            rbMedicinaGeneral.CheckedChanged += rbMedicinaGeneral_CheckedChanged;
            // 
            // numEdad
            // 
            numEdad.Location = new Point(512, 65);
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(118, 23);
            numEdad.TabIndex = 22;
            numEdad.KeyPress += numEdad_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(347, 68);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 21;
            label9.Text = "* Edad:";
            // 
            // txtNumeroIdentificacion
            // 
            txtNumeroIdentificacion.Location = new Point(512, 26);
            txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            txtNumeroIdentificacion.Size = new Size(118, 23);
            txtNumeroIdentificacion.TabIndex = 20;
            txtNumeroIdentificacion.KeyPress += txtNumeroIdentificacion_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(347, 29);
            label8.Name = "label8";
            label8.Size = new Size(134, 15);
            label8.TabIndex = 19;
            label8.Text = "* Nro de identificacion:";
            label8.Click += label8_Click;
            // 
            // cmbEstructura
            // 
            cmbEstructura.FormattingEnabled = true;
            cmbEstructura.Items.AddRange(new object[] { "Pila", "Cola", "Lista" });
            cmbEstructura.Location = new Point(171, 221);
            cmbEstructura.Name = "cmbEstructura";
            cmbEstructura.Size = new Size(142, 23);
            cmbEstructura.TabIndex = 18;
            cmbEstructura.SelectedIndexChanged += cmbEstructura_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 224);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 17;
            label7.Text = "* Tipo de estructura:";
            // 
            // txtCopago
            // 
            txtCopago.Location = new Point(171, 180);
            txtCopago.Name = "txtCopago";
            txtCopago.Size = new Size(142, 23);
            txtCopago.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 183);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 15;
            label6.Text = "Valor del copago";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(171, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(142, 23);
            txtNombre.TabIndex = 14;
            txtNombre.KeyPress += txtNombreCompleto_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 68);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 13;
            label5.Text = "* Nombre completo:";
            // 
            // cmbEstrato
            // 
            cmbEstrato.FormattingEnabled = true;
            cmbEstrato.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cmbEstrato.Location = new Point(171, 104);
            cmbEstrato.Name = "cmbEstrato";
            cmbEstrato.Size = new Size(142, 23);
            cmbEstrato.TabIndex = 12;
            cmbEstrato.SelectedIndexChanged += cmbEstrato_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(142, 15);
            label4.TabIndex = 11;
            label4.Text = "* Estrato socieconomico:";
            label4.Click += label4_Click;
            // 
            // cmbTipoID
            // 
            cmbTipoID.FormattingEnabled = true;
            cmbTipoID.Items.AddRange(new object[] { "CC", "CE", "NUIP", "PAS" });
            cmbTipoID.Location = new Point(171, 26);
            cmbTipoID.Name = "cmbTipoID";
            cmbTipoID.Size = new Size(142, 23);
            cmbTipoID.TabIndex = 10;
            cmbTipoID.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 9;
            label1.Text = "* Tipo de identificacion:";
            // 
            // dgvPila
            // 
            dgvPila.AllowUserToOrderColumns = true;
            dgvPila.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPila.Columns.AddRange(new DataGridViewColumn[] { TipodeID, NombreCompleto, Edad, Estrato, TipodeAtencion, Valordelcopago });
            dgvPila.Dock = DockStyle.Left;
            dgvPila.Location = new Point(3, 3);
            dgvPila.Name = "dgvPila";
            dgvPila.Size = new Size(690, 88);
            dgvPila.TabIndex = 10;
            // 
            // TipodeID
            // 
            TipodeID.DataPropertyName = "Id";
            TipodeID.HeaderText = "ID";
            TipodeID.Name = "TipodeID";
            // 
            // NombreCompleto
            // 
            NombreCompleto.DataPropertyName = "Nombre";
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            // 
            // Edad
            // 
            Edad.DataPropertyName = "Edad";
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            // 
            // Estrato
            // 
            Estrato.DataPropertyName = "Estrato";
            Estrato.HeaderText = "Estrato";
            Estrato.Name = "Estrato";
            // 
            // TipodeAtencion
            // 
            TipodeAtencion.DataPropertyName = "TipoAtencion";
            TipodeAtencion.HeaderText = "Tipo de Atencion";
            TipodeAtencion.Name = "TipodeAtencion";
            // 
            // Valordelcopago
            // 
            Valordelcopago.DataPropertyName = "Copago";
            Valordelcopago.HeaderText = "Valor del copago";
            Valordelcopago.Name = "Valordelcopago";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pilaTab);
            tabControl1.Controls.Add(colaTab);
            tabControl1.Controls.Add(listaTab);
            tabControl1.Location = new Point(19, 411);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 122);
            tabControl1.TabIndex = 10;
            tabControl1.Tag = "what";
            // 
            // pilaTab
            // 
            pilaTab.Controls.Add(dgvPila);
            pilaTab.Location = new Point(4, 24);
            pilaTab.Name = "pilaTab";
            pilaTab.Padding = new Padding(3);
            pilaTab.Size = new Size(794, 94);
            pilaTab.TabIndex = 0;
            pilaTab.Text = "Pila";
            pilaTab.UseVisualStyleBackColor = true;
            pilaTab.Click += pilaTab_Click;
            // 
            // colaTab
            // 
            colaTab.Controls.Add(dgvCola);
            colaTab.Location = new Point(4, 24);
            colaTab.Name = "colaTab";
            colaTab.Padding = new Padding(3);
            colaTab.Size = new Size(794, 94);
            colaTab.TabIndex = 1;
            colaTab.Text = "Cola";
            colaTab.UseVisualStyleBackColor = true;
            // 
            // dgvCola
            // 
            dgvCola.AllowUserToOrderColumns = true;
            dgvCola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCola.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn6 });
            dgvCola.Dock = DockStyle.Left;
            dgvCola.Location = new Point(3, 3);
            dgvCola.Name = "dgvCola";
            dgvCola.Size = new Size(651, 88);
            dgvCola.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn2.HeaderText = "Nombre Completo";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Edad";
            dataGridViewTextBoxColumn5.HeaderText = "Edad";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Estrato";
            dataGridViewTextBoxColumn3.HeaderText = "Estrato";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "TipoAtencion";
            dataGridViewTextBoxColumn4.HeaderText = "Tipo de atencion";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Copago";
            dataGridViewTextBoxColumn6.HeaderText = "Valor del copago";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // listaTab
            // 
            listaTab.Controls.Add(dgvLista);
            listaTab.Location = new Point(4, 24);
            listaTab.Name = "listaTab";
            listaTab.Size = new Size(794, 94);
            listaTab.TabIndex = 2;
            listaTab.Text = "Lista";
            listaTab.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToOrderColumns = true;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn12 });
            dgvLista.Dock = DockStyle.Left;
            dgvLista.Location = new Point(0, 0);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(690, 94);
            dgvLista.TabIndex = 11;
            dgvLista.CellContentClick += dgvLista_CellContentClick;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Tipo de ID";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Nombre Completo";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Edad";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Estrato";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Tipo de atencion";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Valor del copago";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // FormUserData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 545);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormUserData";
            Text = "FormUserData";
            Load += FormUserData_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPila).EndInit();
            tabControl1.ResumeLayout(false);
            pilaTab.ResumeLayout(false);
            colaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCola).EndInit();
            listaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private ComboBox cmbEstrato;
        private Label label4;
        private ComboBox cmbTipoID;
        private Label label1;
        private TextBox txtNombre;
        private ComboBox cmbEstructura;
        private Label label7;
        private TextBox txtCopago;
        private Label label6;
        private TextBox txtNumeroIdentificacion;
        private Label label8;
        private TextBox numEdad;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private GroupBox groupBox2;
        private RadioButton rbExamenLaboratorio;
        private RadioButton rbMedicinaGeneral;
        private Label label12;
        private TextBox textBox5;
        private Label label11;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private DataGridView dgvPila;
        private TabControl tabControl1;
        private TabPage pilaTab;
        private TabPage colaTab;
        private TabPage listaTab;
        private DataGridView dgvCola;
        private DataGridView dgvLista;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn TipodeID;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Estrato;
        private DataGridViewTextBoxColumn TipodeAtencion;
        private DataGridViewTextBoxColumn Valordelcopago;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}