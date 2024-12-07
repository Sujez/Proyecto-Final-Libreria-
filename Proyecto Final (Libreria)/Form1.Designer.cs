namespace Proyecto_Final__Libreria_
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
            this.AGREGAR = new System.Windows.Forms.TabPage();
            this.lblEncabezado2daHoja = new System.Windows.Forms.Label();
            this.btnAsignarEditorial = new System.Windows.Forms.Button();
            this.lblHoja2_MensajeEditDisponibles = new System.Windows.Forms.Label();
            this.cmbEditorialesDisponibles = new System.Windows.Forms.ComboBox();
            this.lblHoja2_MensajeEditorial = new System.Windows.Forms.Label();
            this.cmbEditorialesAsignadas = new System.Windows.Forms.ComboBox();
            this.lblHoja2_MensajeNombre = new System.Windows.Forms.Label();
            this.cmbNombres_Consulta2 = new System.Windows.Forms.ComboBox();
            this.btnEliminarEditorial = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CONSULTAR = new System.Windows.Forms.TabPage();
            this.lblEncabezado1erHoja = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.calendarioB = new System.Windows.Forms.DateTimePicker();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.cmbExistencia = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblCantVen = new System.Windows.Forms.Label();
            this.txtCantVen = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblAnnPubli = new System.Windows.Forms.Label();
            this.txtAnnPubli = new System.Windows.Forms.TextBox();
            this.lblFechaAdd = new System.Windows.Forms.Label();
            this.lblCantidadDe = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.txtCantidadDe = new System.Windows.Forms.TextBox();
            this.cmbNombreLibros = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblEncabezado3erHoja = new System.Windows.Forms.Label();
            this.lblAddEditoriales = new System.Windows.Forms.Label();
            this.lblAddFormatos = new System.Windows.Forms.Label();
            this.lblAddGeneros = new System.Windows.Forms.Label();
            this.btnDelFormatos = new System.Windows.Forms.Button();
            this.btnAddFormatos = new System.Windows.Forms.Button();
            this.btnDelEditoriales = new System.Windows.Forms.Button();
            this.btnAddEditoriales = new System.Windows.Forms.Button();
            this.btnDelGeneros = new System.Windows.Forms.Button();
            this.btnAddGeneros = new System.Windows.Forms.Button();
            this.cmbAddFormatos = new System.Windows.Forms.ComboBox();
            this.cmbAddEditoriales = new System.Windows.Forms.ComboBox();
            this.cmbAddGeneros = new System.Windows.Forms.ComboBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.AGREGAR.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CONSULTAR.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AGREGAR
            // 
            this.AGREGAR.Controls.Add(this.lblEncabezado2daHoja);
            this.AGREGAR.Controls.Add(this.btnAsignarEditorial);
            this.AGREGAR.Controls.Add(this.lblHoja2_MensajeEditDisponibles);
            this.AGREGAR.Controls.Add(this.cmbEditorialesDisponibles);
            this.AGREGAR.Controls.Add(this.lblHoja2_MensajeEditorial);
            this.AGREGAR.Controls.Add(this.cmbEditorialesAsignadas);
            this.AGREGAR.Controls.Add(this.lblHoja2_MensajeNombre);
            this.AGREGAR.Controls.Add(this.cmbNombres_Consulta2);
            this.AGREGAR.Controls.Add(this.btnEliminarEditorial);
            this.AGREGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGREGAR.Location = new System.Drawing.Point(4, 25);
            this.AGREGAR.Name = "AGREGAR";
            this.AGREGAR.Padding = new System.Windows.Forms.Padding(3);
            this.AGREGAR.Size = new System.Drawing.Size(708, 475);
            this.AGREGAR.TabIndex = 0;
            this.AGREGAR.Text = "APARTADO DE EDITORIALES";
            this.AGREGAR.UseVisualStyleBackColor = true;
            // 
            // lblEncabezado2daHoja
            // 
            this.lblEncabezado2daHoja.AutoSize = true;
            this.lblEncabezado2daHoja.Location = new System.Drawing.Point(167, 14);
            this.lblEncabezado2daHoja.Name = "lblEncabezado2daHoja";
            this.lblEncabezado2daHoja.Size = new System.Drawing.Size(404, 16);
            this.lblEncabezado2daHoja.TabIndex = 9;
            this.lblEncabezado2daHoja.Text = "APARTADO PARA AGREGAR Y ELIMINAR EDITORIALES";
            // 
            // btnAsignarEditorial
            // 
            this.btnAsignarEditorial.Location = new System.Drawing.Point(405, 208);
            this.btnAsignarEditorial.Name = "btnAsignarEditorial";
            this.btnAsignarEditorial.Size = new System.Drawing.Size(149, 38);
            this.btnAsignarEditorial.TabIndex = 8;
            this.btnAsignarEditorial.Text = "Asignar Editorial";
            this.btnAsignarEditorial.UseVisualStyleBackColor = true;
            this.btnAsignarEditorial.Click += new System.EventHandler(this.btnAsignarEditorial_Click);
            // 
            // lblHoja2_MensajeEditDisponibles
            // 
            this.lblHoja2_MensajeEditDisponibles.AutoSize = true;
            this.lblHoja2_MensajeEditDisponibles.Location = new System.Drawing.Point(402, 151);
            this.lblHoja2_MensajeEditDisponibles.Name = "lblHoja2_MensajeEditDisponibles";
            this.lblHoja2_MensajeEditDisponibles.Size = new System.Drawing.Size(169, 16);
            this.lblHoja2_MensajeEditDisponibles.TabIndex = 7;
            this.lblHoja2_MensajeEditDisponibles.Text = "Editoriales Disponibles";
            // 
            // cmbEditorialesDisponibles
            // 
            this.cmbEditorialesDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditorialesDisponibles.FormattingEnabled = true;
            this.cmbEditorialesDisponibles.Location = new System.Drawing.Point(405, 170);
            this.cmbEditorialesDisponibles.Name = "cmbEditorialesDisponibles";
            this.cmbEditorialesDisponibles.Size = new System.Drawing.Size(163, 24);
            this.cmbEditorialesDisponibles.TabIndex = 6;
            this.cmbEditorialesDisponibles.SelectedIndexChanged += new System.EventHandler(this.cmbEditorialesDisponibles_SelectedIndexChanged_1);
            // 
            // lblHoja2_MensajeEditorial
            // 
            this.lblHoja2_MensajeEditorial.AutoSize = true;
            this.lblHoja2_MensajeEditorial.Location = new System.Drawing.Point(135, 151);
            this.lblHoja2_MensajeEditorial.Name = "lblHoja2_MensajeEditorial";
            this.lblHoja2_MensajeEditorial.Size = new System.Drawing.Size(208, 16);
            this.lblHoja2_MensajeEditorial.TabIndex = 5;
            this.lblHoja2_MensajeEditorial.Text = "Editoriales Asingadas a libro";
            // 
            // cmbEditorialesAsignadas
            // 
            this.cmbEditorialesAsignadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditorialesAsignadas.FormattingEnabled = true;
            this.cmbEditorialesAsignadas.Location = new System.Drawing.Point(155, 170);
            this.cmbEditorialesAsignadas.Name = "cmbEditorialesAsignadas";
            this.cmbEditorialesAsignadas.Size = new System.Drawing.Size(163, 24);
            this.cmbEditorialesAsignadas.TabIndex = 4;
            this.cmbEditorialesAsignadas.SelectedIndexChanged += new System.EventHandler(this.cmbEditorialesAsignadas_SelectedIndexChanged);
            // 
            // lblHoja2_MensajeNombre
            // 
            this.lblHoja2_MensajeNombre.AutoSize = true;
            this.lblHoja2_MensajeNombre.Location = new System.Drawing.Point(266, 57);
            this.lblHoja2_MensajeNombre.Name = "lblHoja2_MensajeNombre";
            this.lblHoja2_MensajeNombre.Size = new System.Drawing.Size(203, 16);
            this.lblHoja2_MensajeNombre.TabIndex = 3;
            this.lblHoja2_MensajeNombre.Text = "Nombre del libro a consultar";
            // 
            // cmbNombres_Consulta2
            // 
            this.cmbNombres_Consulta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombres_Consulta2.FormattingEnabled = true;
            this.cmbNombres_Consulta2.Location = new System.Drawing.Point(220, 76);
            this.cmbNombres_Consulta2.Name = "cmbNombres_Consulta2";
            this.cmbNombres_Consulta2.Size = new System.Drawing.Size(284, 24);
            this.cmbNombres_Consulta2.TabIndex = 2;
            this.cmbNombres_Consulta2.SelectedIndexChanged += new System.EventHandler(this.cmbNombres_Consulta2_SelectedIndexChanged);
            // 
            // btnEliminarEditorial
            // 
            this.btnEliminarEditorial.Location = new System.Drawing.Point(165, 208);
            this.btnEliminarEditorial.Name = "btnEliminarEditorial";
            this.btnEliminarEditorial.Size = new System.Drawing.Size(149, 38);
            this.btnEliminarEditorial.TabIndex = 0;
            this.btnEliminarEditorial.Text = "Eliminar Relacion";
            this.btnEliminarEditorial.UseVisualStyleBackColor = true;
            this.btnEliminarEditorial.Click += new System.EventHandler(this.btnEliminarEditorial_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CONSULTAR);
            this.tabControl1.Controls.Add(this.AGREGAR);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 504);
            this.tabControl1.TabIndex = 1;
            // 
            // CONSULTAR
            // 
            this.CONSULTAR.Controls.Add(this.lblEncabezado1erHoja);
            this.CONSULTAR.Controls.Add(this.btnInsertar);
            this.CONSULTAR.Controls.Add(this.btnEliminar);
            this.CONSULTAR.Controls.Add(this.calendarioB);
            this.CONSULTAR.Controls.Add(this.btnModificar);
            this.CONSULTAR.Controls.Add(this.btnInicio);
            this.CONSULTAR.Controls.Add(this.btnFinal);
            this.CONSULTAR.Controls.Add(this.btnAnterior);
            this.CONSULTAR.Controls.Add(this.BtnSiguiente);
            this.CONSULTAR.Controls.Add(this.cmbFormato);
            this.CONSULTAR.Controls.Add(this.lblFormato);
            this.CONSULTAR.Controls.Add(this.cmbSeccion);
            this.CONSULTAR.Controls.Add(this.cmbExistencia);
            this.CONSULTAR.Controls.Add(this.cmbGenero);
            this.CONSULTAR.Controls.Add(this.lblSeccion);
            this.CONSULTAR.Controls.Add(this.lblExistencia);
            this.CONSULTAR.Controls.Add(this.lblGen);
            this.CONSULTAR.Controls.Add(this.lblCantVen);
            this.CONSULTAR.Controls.Add(this.txtCantVen);
            this.CONSULTAR.Controls.Add(this.lblAutor);
            this.CONSULTAR.Controls.Add(this.txtAutor);
            this.CONSULTAR.Controls.Add(this.lblPrecio);
            this.CONSULTAR.Controls.Add(this.txtPrecio);
            this.CONSULTAR.Controls.Add(this.lblAnnPubli);
            this.CONSULTAR.Controls.Add(this.txtAnnPubli);
            this.CONSULTAR.Controls.Add(this.lblFechaAdd);
            this.CONSULTAR.Controls.Add(this.lblCantidadDe);
            this.CONSULTAR.Controls.Add(this.lblNombreLibro);
            this.CONSULTAR.Controls.Add(this.txtCantidadDe);
            this.CONSULTAR.Controls.Add(this.cmbNombreLibros);
            this.CONSULTAR.Location = new System.Drawing.Point(4, 25);
            this.CONSULTAR.Name = "CONSULTAR";
            this.CONSULTAR.Padding = new System.Windows.Forms.Padding(3);
            this.CONSULTAR.Size = new System.Drawing.Size(708, 475);
            this.CONSULTAR.TabIndex = 1;
            this.CONSULTAR.Text = "CONSULTA Y MANIPULACION";
            this.CONSULTAR.UseVisualStyleBackColor = true;
            // 
            // lblEncabezado1erHoja
            // 
            this.lblEncabezado1erHoja.AutoSize = true;
            this.lblEncabezado1erHoja.Location = new System.Drawing.Point(144, 3);
            this.lblEncabezado1erHoja.Name = "lblEncabezado1erHoja";
            this.lblEncabezado1erHoja.Size = new System.Drawing.Size(367, 16);
            this.lblEncabezado1erHoja.TabIndex = 36;
            this.lblEncabezado1erHoja.Text = "APARTADO DE CONSULTA Y MANIPULACION DE DATOS";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(548, 259);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(130, 41);
            this.btnInsertar.TabIndex = 35;
            this.btnInsertar.Text = "Insertar Registro";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(548, 182);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 41);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar Registro";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // calendarioB
            // 
            this.calendarioB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendarioB.Location = new System.Drawing.Point(39, 162);
            this.calendarioB.Name = "calendarioB";
            this.calendarioB.Size = new System.Drawing.Size(107, 22);
            this.calendarioB.TabIndex = 33;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(548, 107);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 52);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar Registro";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(61, 422);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(91, 33);
            this.btnInicio.TabIndex = 31;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(420, 422);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(91, 33);
            this.btnFinal.TabIndex = 30;
            this.btnFinal.Text = "Final";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(179, 422);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(91, 33);
            this.btnAnterior.TabIndex = 29;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Location = new System.Drawing.Point(311, 422);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(91, 33);
            this.BtnSiguiente.TabIndex = 27;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // cmbFormato
            // 
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(337, 354);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(174, 24);
            this.cmbFormato.TabIndex = 26;
            this.cmbFormato.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(334, 337);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(57, 16);
            this.lblFormato.TabIndex = 25;
            this.lblFormato.Text = "Formato";
            this.lblFormato.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(337, 287);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(174, 24);
            this.cmbSeccion.TabIndex = 24;
            this.cmbSeccion.SelectedIndexChanged += new System.EventHandler(this.cmbSeccion_SelectedIndexChanged);
            // 
            // cmbExistencia
            // 
            this.cmbExistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExistencia.FormattingEnabled = true;
            this.cmbExistencia.Location = new System.Drawing.Point(337, 222);
            this.cmbExistencia.Name = "cmbExistencia";
            this.cmbExistencia.Size = new System.Drawing.Size(174, 24);
            this.cmbExistencia.TabIndex = 23;
            this.cmbExistencia.SelectedIndexChanged += new System.EventHandler(this.cmbExistencia_SelectedIndexChanged);
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(337, 160);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(174, 24);
            this.cmbGenero.TabIndex = 22;
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGenero_SelectedIndexChanged);
            this.cmbGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbGenero_KeyPress);
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Location = new System.Drawing.Point(334, 270);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(56, 16);
            this.lblSeccion.TabIndex = 21;
            this.lblSeccion.Text = "Seccion";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(334, 205);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(68, 16);
            this.lblExistencia.TabIndex = 19;
            this.lblExistencia.Text = "Existencia";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(334, 143);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(52, 16);
            this.lblGen.TabIndex = 17;
            this.lblGen.Text = "Genero";
            // 
            // lblCantVen
            // 
            this.lblCantVen.AutoSize = true;
            this.lblCantVen.Location = new System.Drawing.Point(334, 83);
            this.lblCantVen.Name = "lblCantVen";
            this.lblCantVen.Size = new System.Drawing.Size(134, 16);
            this.lblCantVen.TabIndex = 15;
            this.lblCantVen.Text = "Cantidad de Vendida";
            // 
            // txtCantVen
            // 
            this.txtCantVen.Location = new System.Drawing.Point(337, 102);
            this.txtCantVen.Name = "txtCantVen";
            this.txtCantVen.Size = new System.Drawing.Size(80, 22);
            this.txtCantVen.TabIndex = 14;
            this.txtCantVen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantVen_KeyPress);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(36, 337);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(38, 16);
            this.lblAutor.TabIndex = 13;
            this.lblAutor.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(39, 356);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(231, 22);
            this.txtAutor.TabIndex = 12;
            this.txtAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutor_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(36, 270);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(39, 289);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(87, 22);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblAnnPubli
            // 
            this.lblAnnPubli.AutoSize = true;
            this.lblAnnPubli.Location = new System.Drawing.Point(36, 205);
            this.lblAnnPubli.Name = "lblAnnPubli";
            this.lblAnnPubli.Size = new System.Drawing.Size(122, 16);
            this.lblAnnPubli.TabIndex = 9;
            this.lblAnnPubli.Text = "Año de publicacion";
            // 
            // txtAnnPubli
            // 
            this.txtAnnPubli.Location = new System.Drawing.Point(39, 224);
            this.txtAnnPubli.Name = "txtAnnPubli";
            this.txtAnnPubli.Size = new System.Drawing.Size(87, 22);
            this.txtAnnPubli.TabIndex = 8;
            this.txtAnnPubli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnnPubli_KeyPress);
            // 
            // lblFechaAdd
            // 
            this.lblFechaAdd.AutoSize = true;
            this.lblFechaAdd.Location = new System.Drawing.Point(36, 143);
            this.lblFechaAdd.Name = "lblFechaAdd";
            this.lblFechaAdd.Size = new System.Drawing.Size(111, 16);
            this.lblFechaAdd.TabIndex = 7;
            this.lblFechaAdd.Text = "Fecha de adicion";
            // 
            // lblCantidadDe
            // 
            this.lblCantidadDe.AutoSize = true;
            this.lblCantidadDe.Location = new System.Drawing.Point(36, 83);
            this.lblCantidadDe.Name = "lblCantidadDe";
            this.lblCantidadDe.Size = new System.Drawing.Size(116, 16);
            this.lblCantidadDe.TabIndex = 5;
            this.lblCantidadDe.Text = "Cantidad de libros";
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Location = new System.Drawing.Point(36, 24);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(107, 16);
            this.lblNombreLibro.TabIndex = 4;
            this.lblNombreLibro.Text = "Nombre del libro";
            // 
            // txtCantidadDe
            // 
            this.txtCantidadDe.Location = new System.Drawing.Point(39, 102);
            this.txtCantidadDe.Name = "txtCantidadDe";
            this.txtCantidadDe.Size = new System.Drawing.Size(87, 22);
            this.txtCantidadDe.TabIndex = 3;
            this.txtCantidadDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadDe_KeyPress);
            // 
            // cmbNombreLibros
            // 
            this.cmbNombreLibros.FormattingEnabled = true;
            this.cmbNombreLibros.Location = new System.Drawing.Point(39, 43);
            this.cmbNombreLibros.Name = "cmbNombreLibros";
            this.cmbNombreLibros.Size = new System.Drawing.Size(472, 24);
            this.cmbNombreLibros.TabIndex = 2;
            this.cmbNombreLibros.SelectedIndexChanged += new System.EventHandler(this.NombreLibros_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblEncabezado3erHoja);
            this.tabPage1.Controls.Add(this.lblAddEditoriales);
            this.tabPage1.Controls.Add(this.lblAddFormatos);
            this.tabPage1.Controls.Add(this.lblAddGeneros);
            this.tabPage1.Controls.Add(this.btnDelFormatos);
            this.tabPage1.Controls.Add(this.btnAddFormatos);
            this.tabPage1.Controls.Add(this.btnDelEditoriales);
            this.tabPage1.Controls.Add(this.btnAddEditoriales);
            this.tabPage1.Controls.Add(this.btnDelGeneros);
            this.tabPage1.Controls.Add(this.btnAddGeneros);
            this.tabPage1.Controls.Add(this.cmbAddFormatos);
            this.tabPage1.Controls.Add(this.cmbAddEditoriales);
            this.tabPage1.Controls.Add(this.cmbAddGeneros);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(708, 475);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "AGREGAR ELEMENTOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblEncabezado3erHoja
            // 
            this.lblEncabezado3erHoja.AutoSize = true;
            this.lblEncabezado3erHoja.Location = new System.Drawing.Point(122, 13);
            this.lblEncabezado3erHoja.Name = "lblEncabezado3erHoja";
            this.lblEncabezado3erHoja.Size = new System.Drawing.Size(446, 16);
            this.lblEncabezado3erHoja.TabIndex = 15;
            this.lblEncabezado3erHoja.Text = "APARTADO PARA AGREGAR Y ELIMINAR ELEMENTOS DISPONIBLES";
            this.lblEncabezado3erHoja.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblAddEditoriales
            // 
            this.lblAddEditoriales.AutoSize = true;
            this.lblAddEditoriales.Location = new System.Drawing.Point(297, 261);
            this.lblAddEditoriales.Name = "lblAddEditoriales";
            this.lblAddEditoriales.Size = new System.Drawing.Size(71, 16);
            this.lblAddEditoriales.TabIndex = 14;
            this.lblAddEditoriales.Text = "Editoriales";
            // 
            // lblAddFormatos
            // 
            this.lblAddFormatos.AutoSize = true;
            this.lblAddFormatos.Location = new System.Drawing.Point(495, 43);
            this.lblAddFormatos.Name = "lblAddFormatos";
            this.lblAddFormatos.Size = new System.Drawing.Size(64, 16);
            this.lblAddFormatos.TabIndex = 13;
            this.lblAddFormatos.Text = "Formatos";
            // 
            // lblAddGeneros
            // 
            this.lblAddGeneros.AutoSize = true;
            this.lblAddGeneros.Location = new System.Drawing.Point(139, 43);
            this.lblAddGeneros.Name = "lblAddGeneros";
            this.lblAddGeneros.Size = new System.Drawing.Size(59, 16);
            this.lblAddGeneros.TabIndex = 12;
            this.lblAddGeneros.Text = "Generos";
            // 
            // btnDelFormatos
            // 
            this.btnDelFormatos.Location = new System.Drawing.Point(453, 172);
            this.btnDelFormatos.Name = "btnDelFormatos";
            this.btnDelFormatos.Size = new System.Drawing.Size(134, 39);
            this.btnDelFormatos.TabIndex = 8;
            this.btnDelFormatos.Text = "Eliminar";
            this.btnDelFormatos.UseVisualStyleBackColor = true;
            this.btnDelFormatos.Click += new System.EventHandler(this.btnDelFormatos_Click);
            // 
            // btnAddFormatos
            // 
            this.btnAddFormatos.Location = new System.Drawing.Point(453, 111);
            this.btnAddFormatos.Name = "btnAddFormatos";
            this.btnAddFormatos.Size = new System.Drawing.Size(134, 39);
            this.btnAddFormatos.TabIndex = 7;
            this.btnAddFormatos.Text = "Añadir";
            this.btnAddFormatos.UseVisualStyleBackColor = true;
            this.btnAddFormatos.Click += new System.EventHandler(this.btnAddFormatos_Click);
            // 
            // btnDelEditoriales
            // 
            this.btnDelEditoriales.Location = new System.Drawing.Point(264, 390);
            this.btnDelEditoriales.Name = "btnDelEditoriales";
            this.btnDelEditoriales.Size = new System.Drawing.Size(134, 39);
            this.btnDelEditoriales.TabIndex = 6;
            this.btnDelEditoriales.Text = "Eliminar";
            this.btnDelEditoriales.UseVisualStyleBackColor = true;
            this.btnDelEditoriales.Click += new System.EventHandler(this.btnDelEditoriales_Click);
            // 
            // btnAddEditoriales
            // 
            this.btnAddEditoriales.Location = new System.Drawing.Point(264, 329);
            this.btnAddEditoriales.Name = "btnAddEditoriales";
            this.btnAddEditoriales.Size = new System.Drawing.Size(134, 39);
            this.btnAddEditoriales.TabIndex = 5;
            this.btnAddEditoriales.Text = "Añadir";
            this.btnAddEditoriales.UseVisualStyleBackColor = true;
            this.btnAddEditoriales.Click += new System.EventHandler(this.btnAddEditoriales_Click);
            // 
            // btnDelGeneros
            // 
            this.btnDelGeneros.Location = new System.Drawing.Point(101, 172);
            this.btnDelGeneros.Name = "btnDelGeneros";
            this.btnDelGeneros.Size = new System.Drawing.Size(134, 39);
            this.btnDelGeneros.TabIndex = 4;
            this.btnDelGeneros.Text = "Eliminar";
            this.btnDelGeneros.UseVisualStyleBackColor = true;
            this.btnDelGeneros.Click += new System.EventHandler(this.btnDelGeneros_Click);
            // 
            // btnAddGeneros
            // 
            this.btnAddGeneros.Location = new System.Drawing.Point(101, 111);
            this.btnAddGeneros.Name = "btnAddGeneros";
            this.btnAddGeneros.Size = new System.Drawing.Size(134, 39);
            this.btnAddGeneros.TabIndex = 3;
            this.btnAddGeneros.Text = "Añadir";
            this.btnAddGeneros.UseVisualStyleBackColor = true;
            this.btnAddGeneros.Click += new System.EventHandler(this.btnAddGeneros_Click);
            // 
            // cmbAddFormatos
            // 
            this.cmbAddFormatos.FormattingEnabled = true;
            this.cmbAddFormatos.Location = new System.Drawing.Point(429, 62);
            this.cmbAddFormatos.Name = "cmbAddFormatos";
            this.cmbAddFormatos.Size = new System.Drawing.Size(182, 24);
            this.cmbAddFormatos.TabIndex = 2;
            this.cmbAddFormatos.SelectedIndexChanged += new System.EventHandler(this.cmbAddFormatos_SelectedIndexChanged);
            this.cmbAddFormatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAddFormatos_KeyPress);
            // 
            // cmbAddEditoriales
            // 
            this.cmbAddEditoriales.FormattingEnabled = true;
            this.cmbAddEditoriales.Location = new System.Drawing.Point(244, 280);
            this.cmbAddEditoriales.Name = "cmbAddEditoriales";
            this.cmbAddEditoriales.Size = new System.Drawing.Size(182, 24);
            this.cmbAddEditoriales.TabIndex = 1;
            this.cmbAddEditoriales.SelectedIndexChanged += new System.EventHandler(this.cmbAddEditoriales_SelectedIndexChanged);
            this.cmbAddEditoriales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAddEditoriales_KeyPress);
            // 
            // cmbAddGeneros
            // 
            this.cmbAddGeneros.FormattingEnabled = true;
            this.cmbAddGeneros.Location = new System.Drawing.Point(76, 62);
            this.cmbAddGeneros.Name = "cmbAddGeneros";
            this.cmbAddGeneros.Size = new System.Drawing.Size(182, 24);
            this.cmbAddGeneros.TabIndex = 0;
            this.cmbAddGeneros.SelectedIndexChanged += new System.EventHandler(this.cmbAddGeneros_SelectedIndexChanged);
            this.cmbAddGeneros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAddGeneros_KeyPress);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(739, 449);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(91, 67);
            this.btnRefrescar.TabIndex = 36;
            this.btnRefrescar.Text = "Refrescar datos";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 528);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AGREGAR.ResumeLayout(false);
            this.AGREGAR.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.CONSULTAR.ResumeLayout(false);
            this.CONSULTAR.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage AGREGAR;
        private System.Windows.Forms.ComboBox cmbNombres_Consulta2;
        private System.Windows.Forms.Button btnEliminarEditorial;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CONSULTAR;
        private System.Windows.Forms.ComboBox cmbFormato;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.ComboBox cmbExistencia;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblCantVen;
        private System.Windows.Forms.TextBox txtCantVen;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblAnnPubli;
        private System.Windows.Forms.TextBox txtAnnPubli;
        private System.Windows.Forms.Label lblFechaAdd;
        private System.Windows.Forms.Label lblCantidadDe;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.TextBox txtCantidadDe;
        private System.Windows.Forms.ComboBox cmbNombreLibros;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker calendarioB;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbAddFormatos;
        private System.Windows.Forms.ComboBox cmbAddEditoriales;
        private System.Windows.Forms.ComboBox cmbAddGeneros;
        private System.Windows.Forms.Label lblAddEditoriales;
        private System.Windows.Forms.Label lblAddFormatos;
        private System.Windows.Forms.Label lblAddGeneros;
        private System.Windows.Forms.Button btnDelFormatos;
        private System.Windows.Forms.Button btnAddFormatos;
        private System.Windows.Forms.Button btnDelEditoriales;
        private System.Windows.Forms.Button btnAddEditoriales;
        private System.Windows.Forms.Button btnDelGeneros;
        private System.Windows.Forms.Button btnAddGeneros;
        private System.Windows.Forms.Label lblHoja2_MensajeNombre;
        private System.Windows.Forms.Label lblHoja2_MensajeEditDisponibles;
        private System.Windows.Forms.ComboBox cmbEditorialesDisponibles;
        private System.Windows.Forms.Label lblHoja2_MensajeEditorial;
        private System.Windows.Forms.ComboBox cmbEditorialesAsignadas;
        private System.Windows.Forms.Button btnAsignarEditorial;
        private System.Windows.Forms.Label lblEncabezado1erHoja;
        private System.Windows.Forms.Label lblEncabezado2daHoja;
        private System.Windows.Forms.Label lblEncabezado3erHoja;
    }
}

