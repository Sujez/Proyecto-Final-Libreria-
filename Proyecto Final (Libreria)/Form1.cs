using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final__Libreria_
{
    public partial class Form1 : Form
    {
        //Declaracion de variables globales de id para posteriores procesos
        public static int idExistencia = 0, idgenero = 0, idSeccion = 0, idExistenciaB = 0,idFormato = 0,idLibro = 0;
        public static int idEditoriales = 0, idAddGeneros = 0, idAddFormato = 0;
        public static int idEditorialDisponible = 0, idNombresConsulta2 = 0,idEditorialesAsignadas = 0;

        //Declaracion de diccionarios
        Dictionary<int, string> datosGenero = new Dictionary<int, string>();
        Dictionary<int, int> datosSeccion = new Dictionary<int, int>();
        Dictionary<int, string> datosExistenciaB = new Dictionary<int, string>();
        Dictionary<int, string> datosFormato = new Dictionary<int, string>();
        Dictionary<int, string> datosLibro = new Dictionary<int, string>();
        Dictionary<int, string> datosEditoriales = new Dictionary<int, string>();

        //CAMBIAR EL DATA SOURCE PARA QUE LA BASE DE DATOS SE CONECTE A LA BD DE LA COMPU
        string connectionString = "Data Source=DESKTOP-BF3NJMJ;Initial Catalog=BD_LIBRERIA; Integrated Security=True";

        public Form1()
        {
            //LLENADO AUTIMATICO DE COMBOBOXES
            InitializeComponent();
            try
            {
                CargarExistenciaB();
                CargarLibros();
                CargarGeneros();
                CargarSeccion();
                CargarFormato();
                CargarEditoriales();
            }
            catch
            {
                MessageBox.Show("No hay elementos agregados, favor de añadir elementos");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Comando para que los combobox aparezcan vacios al iniciar el programa
            cmbNombreLibros.SelectedIndex = -1;
            cmbSeccion.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            cmbFormato.SelectedIndex = -1;
            cmbExistencia.SelectedIndex = -1;
            cmbAddEditoriales.SelectedIndex = -1;
        }





        //METODOS PARA CARGAR AUTMATICAMENTE LOS COMBOBOX
        //========================================================================================================
        
        public void CargarExistenciaB()
        {     

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener los datos
                    string query = "SELECT ID_Existencia, Existencia FROM Existencia";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);         // Primera columna: Id
                        string nombre = reader.GetString(1); // Segunda columna: Nombre
                        datosExistenciaB.Add(id, nombre);
                    }

                    // Asignar los datos al ComboBox
                    cmbExistencia.DataSource = new BindingSource(datosExistenciaB, null);
                    cmbExistencia.DisplayMember = "Value"; // Lo que se muestra al usuario
                    cmbExistencia.ValueMember = "Key";    // La ID asociada
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void CargarLibros()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener los datos
                    string query = "SELECT ID_Libro, Nombre_Libro FROM INVENTARIO where visible = 1";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Diccionario para almacenar los datos (ID, Nombre)
                    //NOTA: CAMBIAR EL NOMBRE DEL OBJETO

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);         // Primera columna: Id
                        string nombre = reader.GetString(1); // Segunda columna: Nombre
                        
                        //NOTA: CAMBIAR EL NOMBRE DEL OBJETO
                        datosLibro.Add(id, nombre);
                    }

                    /*
                     * UTILIZANDO LA PROPIEDAD DATA SOURCE se impide poder actualizar los datos
                    // Asignar los datos al ComboBox
                    //NOTA: CAMBIAR EL NOMBRE DE LOS COMBOBOX
                    cmbNombreLibros.DataSource = new BindingSource(datosLibro, null);
                    cmbNombreLibros.DisplayMember = "Value"; // Lo que se muestra al usuario
                    cmbNombreLibros.ValueMember = "Key";    // La ID asociada
                    */
                    
                    // Llena el ComboBox manualmente sin usar DataSource
                    cmbNombreLibros.Items.Clear(); // Limpia el ComboBox antes de llenarlo
                    cmbNombres_Consulta2.Items.Clear();

                    foreach (var item in datosLibro)
                    {
                        cmbNombreLibros.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
                        cmbNombres_Consulta2.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
                    }

                    // Configura cómo mostrar los datos en el ComboBox
                    cmbNombreLibros.DisplayMember = "Value"; // Lo que se mostrará en la lista (nombre)
                    cmbNombreLibros.ValueMember = "Key";    // Lo que se usará como valor asociado (ID)

                    cmbNombres_Consulta2.DisplayMember = "Value";
                    cmbNombres_Consulta2.ValueMember = "Key"; 

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void CargarGeneros()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener los datos
                    string query = "SELECT ID_Genero, Genero FROM Genero where visible = 1";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Diccionario para almacenar los datos (ID, Nombre)
                    //NOTA: CAMBIAR EL NOMBRE DEL OBJETO
                    

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);         // Primera columna: Id
                        string nombre = reader.GetString(1); // Segunda columna: Nombre

                        //NOTA: CAMBIAR EL NOMBRE DEL OBJETO
                        datosGenero.Add(id, nombre);
                    }


                    // Llena el ComboBox manualmente sin usar DataSource
                    cmbGenero.Items.Clear(); // Limpia el ComboBox antes de llenarlo
                    cmbAddGeneros.Items.Clear();

                    foreach (var item in datosGenero)
                    {
                        cmbGenero.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
                        cmbAddGeneros.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
                    }

                    // Configura cómo mostrar los datos en el ComboBox
                    cmbGenero.DisplayMember = "Value"; // Lo que se mostrará en la lista (nombre)
                    cmbGenero.ValueMember = "Key";    // Lo que se usará como valor asociado (ID)

                    cmbAddGeneros.DisplayMember = "Value";
                    cmbAddGeneros.ValueMember = "Key";   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void CargarSeccion()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener los datos
                    string query = "SELECT ID_Seccion, Seccion FROM Seccion";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);         // Primera columna: Id
                        int secc = reader.GetInt32(1); // Segunda columna: Nombre

                        //NOTA: CAMBIAR EL NOMBRE DEL OBJETO
                        datosSeccion.Add(id, secc);
                    }

                    // Asignar los datos al ComboBox
                    //NOTA: CAMBIAR EL NOMBRE DE LOS COMBOBOX
                    cmbSeccion.DataSource = new BindingSource(datosSeccion, null);
                    cmbSeccion.DisplayMember = "Value"; // Lo que se muestra al usuario
                    cmbSeccion.ValueMember = "Key";    // La ID asociada
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void CargarFormato()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener los datos
                    string query = "SELECT ID_Formato, Formato FROM Formato where visible = 1";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);         // Primera columna: Id
                        string nombre = reader.GetString(1); // Segunda columna: Nombre

                        //NOTA: CAMBIAR EL NOMBRE DEL OBJETO
                        datosFormato.Add(id, nombre);
                    }

                    // Llena el ComboBox manualmente sin usar DataSource
                    cmbFormato.Items.Clear(); // Limpia el ComboBox antes de llenarlo
                    cmbAddFormatos.Items.Clear();

                    foreach (var item in datosFormato)
                    {
                        cmbFormato.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
                        cmbAddFormatos.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
                    }

                    // Configura cómo mostrar los datos en el ComboBox
                    cmbFormato.DisplayMember = "Value"; // Lo que se mostrará en la lista (nombre)
                    cmbFormato.ValueMember = "Key";    // Lo que se usará como valor asociado (ID)

                    cmbAddFormatos.DisplayMember = "Value";
                    cmbAddFormatos.ValueMember = "Key";    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void CargarEditoriales()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener los datos
                    string query = "SELECT ID_Editorial, Editorial FROM Editorial where Visible = 1";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);         // Primera columna: Id
                        string nombre = reader.GetString(1); // Segunda columna: Nombre

                        //NOTA: CAMBIAR EL NOMBRE DEL OBJETO
                        datosEditoriales.Add(id, nombre);
                    }

                    // Llena el ComboBox manualmente sin usar DataSource
                    cmbAddEditoriales.Items.Clear(); // Limpia el ComboBox antes de llenarlo
                    cmbEditorialesDisponibles.Items.Clear();

                    foreach (var item in datosEditoriales)
                    {
                        cmbAddEditoriales.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
                        cmbEditorialesDisponibles.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
                    }

                    // Configura cómo mostrar los datos en el ComboBox
                    cmbAddEditoriales.DisplayMember = "Value"; // Lo que se mostrará en la lista (nombre)
                    cmbAddEditoriales.ValueMember = "Key";    // Lo que se usará como valor asociado (ID)

                    cmbEditorialesDisponibles.DisplayMember = "Value"; // Lo que se mostrará en la lista (nombre)
                    cmbEditorialesDisponibles.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //========================================================================================================




        //EVENTO PARA GUARDAR LA ID EN SU RESPECTIVA VARIABLE GLOBAL
        //========================================================================================================
        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la ID del registro seleccionado
            if (cmbGenero.SelectedItem != null)
            {
                var seleccion = (KeyValuePair<int, string>)cmbGenero.SelectedItem;
                //CAMBIAR ESTA VARIABLE POR UNA VARIABLE GLOBAL
                //ME EQUIVOQUE EN EL NONMBRE DE LAS VARIABLES
                idgenero = seleccion.Key;
                string nombreSeleccionado = seleccion.Value;
            }
        }
        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la ID del registro seleccionado
            if (cmbSeccion.SelectedItem != null)
            {
                var seleccion = (KeyValuePair<int, int>)cmbSeccion.SelectedItem;
                //CAMBIAR ESTA VARIABLE POR UNA VARIABLE GLOBAL
                idSeccion = seleccion.Key;
                int nombreSeleccionado = seleccion.Value;
            }
        }
        private void cmbExistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la ID del registro seleccionado
            if (cmbExistencia.SelectedItem != null)
            {
                var seleccion = (KeyValuePair<int, string>)cmbExistencia.SelectedItem;
                //CAMBIAR ESTA VARIABLE POR UNA VARIABLE GLOBAL
                idExistenciaB = seleccion.Key;
                string nombreSeleccionado = seleccion.Value;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la ID del registro seleccionado
            if (cmbFormato.SelectedItem != null)
            {
                var seleccion = (KeyValuePair<int, string>)cmbFormato.SelectedItem;
                //CAMBIAR ESTA VARIABLE POR UNA VARIABLE GLOBAL
                idFormato = seleccion.Key;
                string nombreSeleccionado = seleccion.Value;
            }

        }
        private void cmbAddEditoriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la ID del registro seleccionado
            if (cmbAddEditoriales.SelectedItem != null)
            {
                var seleccion = (KeyValuePair<int, string>)cmbAddEditoriales.SelectedItem;
                //CAMBIAR ESTA VARIABLE POR UNA VARIABLE GLOBAL
                idEditoriales = seleccion.Key;
                string nombreSeleccionado = seleccion.Value;
            }
        }
        private void cmbAddGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la ID del registro seleccionado
            if (cmbAddGeneros.SelectedItem != null)
            {
                var seleccion = (KeyValuePair<int, string>)cmbAddGeneros.SelectedItem;
                //CAMBIAR ESTA VARIABLE POR UNA VARIABLE GLOBAL
                idAddGeneros = seleccion.Key;
                string nombreSeleccionado = seleccion.Value;
            }
        }
        private void cmbAddFormatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la ID del registro seleccionado
            if (cmbAddFormatos.SelectedItem != null)
            {
                var seleccion = (KeyValuePair<int, string>)cmbAddFormatos.SelectedItem;
                //CAMBIAR ESTA VARIABLE POR UNA VARIABLE GLOBAL
                idAddFormato = seleccion.Key;
                string nombreSeleccionado = seleccion.Value;
            }
        }
        private void cmbEditorialesDisponibles_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Obtener la ID del registro seleccionado
            if (cmbEditorialesDisponibles.SelectedItem != null)
            {
                var seleccion = (KeyValuePair<int, string>)cmbEditorialesDisponibles.SelectedItem;
                //CAMBIAR ESTA VARIABLE POR UNA VARIABLE GLOBAL
                idEditorialDisponible = seleccion.Key;
                string nombreSeleccionado = seleccion.Value;
            }
        }
        private void cmbNombres_Consulta2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEditorialesAsignadas.Items.Clear();
            // Obtener la ID del registro seleccionado
            if (cmbNombres_Consulta2.SelectedItem != null)
            {
                var seleccion = (KeyValuePair<int, string>)cmbNombres_Consulta2.SelectedItem;
                //CAMBIAR ESTA VARIABLE POR UNA VARIABLE GLOBAL
                idNombresConsulta2 = seleccion.Key;
                string nombreSeleccionado = seleccion.Value;
            }

            // Abrir la conexión
            cargarEditorialesAsignadas();


        }


        private void cargarEditorialesAsignadas()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();

            try
            {
                // Comando para obtener los registros correspondientes al ID de Libro
                SqlCommand cm = new SqlCommand("SELECT * FROM Libro_Editorial WHERE ID_Libro = @idLibro", conexion);
                cm.Parameters.AddWithValue("@idLibro", idNombresConsulta2); // Parámetro para evitar inyección SQL

                SqlDataReader dr = cm.ExecuteReader();

                // Limpiar el ComboBox antes de agregar datos nuevos
                cmbEditorialesAsignadas.Items.Clear();

                // Utilizar un HashSet para evitar duplicados
                HashSet<string> valoresUnicos = new HashSet<string>();

                // Procesar los datos obtenidos de la consulta
                while (dr.Read())
                {
                    // Extraer el valor de la columna "ID_Editorial"
                    string edit = dr["ID_Editorial"].ToString();
                    int editNum = int.Parse(edit);

                    // Verificar si el ID está en el diccionario (o lista) datosEditoriales
                    if (datosEditoriales.ContainsKey(editNum)) // Aseguramos que el registro existe
                    {
                        string valoreditorial = datosEditoriales[editNum];

                        // Evitar agregar valores duplicados
                        if (!valoresUnicos.Contains(valoreditorial))
                        {
                            valoresUnicos.Add(valoreditorial); // Agregar al HashSet
                            cmbEditorialesAsignadas.Items.Add(valoreditorial); // Agregar al ComboBox
                        }
                    }
                }

                dr.Close(); // Cerrar el DataReader
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error en la operacion");
            }
            finally
            {
                conexion.Close();
            }
        }

        private void cmbEditorialesAsignadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorBuscado = cmbEditorialesAsignadas.Text;

            // Buscar la clave correspondiente al valor
            int? claveEncontrada = null;

            foreach (var clave in datosEditoriales)
            {
                if (clave.Value == valorBuscado)
                {
                    claveEncontrada = clave.Key;
                    break; // Detener el bucle una vez encontrado
                }
            }
            idEditorialesAsignadas = claveEncontrada.Value;
        }
        //========================================================================================================

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //ESTRUCTURA DE LOS BOTONES PARA SIGUIENTE, ATRAS, INICIO Y FINAL
        //====================================================================================================================
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            // Si hay elementos en el ComboBox
            if (cmbNombreLibros.Items.Count > 0)
            {
                // Obtener el índice actual
                int indiceActual = cmbNombreLibros.SelectedIndex;

                // Calcular el índice del siguiente elemento
                int siguienteIndice = (indiceActual + 1) % cmbNombreLibros.Items.Count;

                // Seleccionar el siguiente elemento
                cmbNombreLibros.SelectedIndex = siguienteIndice;
            }
            else
            {
                MessageBox.Show("El ComboBox está vacío.");
            }
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // Si hay elementos en el ComboBox
            if (cmbNombreLibros.Items.Count > 0)
            {
                // Obtener el índice actual
                int indiceActual = cmbNombreLibros.SelectedIndex;

                // Calcular el índice del siguiente elemento
                int anteriorIndice = (indiceActual - 1 + cmbNombreLibros.Items.Count) % cmbNombreLibros.Items.Count;

                // Seleccionar el siguiente elemento
                cmbNombreLibros.SelectedIndex = anteriorIndice;
            }
            else
            {
                MessageBox.Show("El ComboBox está vacío.");
            }
        }
        private void btnFinal_Click(object sender, EventArgs e)
        {
            // Si hay elementos en el ComboBox
            if (cmbNombreLibros.Items.Count > 0)
            {
                // Obtener el índice actual
                int indiceActual = cmbNombreLibros.Items.Count - 1;

                // Seleccionar el siguiente elemento
                cmbNombreLibros.SelectedIndex = indiceActual;
            }
            else
            {
                MessageBox.Show("El ComboBox está vacío.");
            }
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Si hay elementos en el ComboBox
            if (cmbNombreLibros.Items.Count > 0)
            {
                // Obtener el índice actual
                int indiceActual = 0;

                // Seleccionar el siguiente elemento
                cmbNombreLibros.SelectedIndex = indiceActual;
            }
            else
            {
                MessageBox.Show("El ComboBox está vacío.");
            }
        }       

        //====================================================================================================================


        //BOTONES PARA MANIPULAR REGISTROS DE LA PRIMER HOJA
        //====================================================================================================================
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();

                //PROCESO PARA CAMBIAR EL FORMATO DE LA FECHA Y PODER ENVIARLO A LA BASE DE DATOS

                string fechaOriginal = calendarioB.Text;

                // Convertir la cadena a un objeto DateTime
                DateTime fechaConvertida = DateTime.ParseExact(fechaOriginal, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // Formatear la fecha al nuevo formato "yyyy-MM-dd"
                string fechaNueva = fechaConvertida.ToString("yyyy-MM-dd");

                //Query para modificar datos (Se mofidifica todo de golpe)
                SqlCommand cmd = new SqlCommand("UPDATE INVENTARIO SET Nombre_Libro='" + this.cmbNombreLibros.Text + "',Cantidad_Libros="
                    + Convert.ToInt32(this.txtCantidadDe.Text) + ",Fecha_Adicion='" + fechaNueva + "',Ann_Publicacion=" + Convert.ToInt32(this.txtAnnPubli.Text)
                    + ",Precio=" + Convert.ToDecimal(this.txtPrecio.Text) + ",Autor='" + this.txtAutor.Text + "',Cantidad_Vendida="
                    + Convert.ToInt32(this.txtCantVen.Text) + ",ID_Genero=" + idgenero + ",ID_Existencia=" + idExistenciaB
                    + ",ID_Seccion=" + idSeccion + ",ID_Formato=" + idFormato + " WHERE ID_Libro=" + idLibro + "", conexion);

                cmd.ExecuteNonQuery();

                //Mensaje en caso de exito
                MessageBox.Show("Registro modificado exitosamente, refresque el programa para reflejarlo");

                conexion.Close();
                limpiarCampos();
            }
            catch
            {
                MessageBox.Show("Hubo un error, favor de verificar todos los campos");
            }
                
            
            
        }       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();

                //Comando para eliminar un registro
                SqlCommand cmd = new SqlCommand("update INVENTARIO set Visible = 0 where ID_Libro = " + idLibro, conexion);
                cmd.ExecuteNonQuery();

                //Mensaje de exito
                MessageBox.Show("Registro modificado exitosamente, refresque el programa para reflejarlo");

                //Se actualiza el combobox

                conexion.Close();
              
                limpiarCampos();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
                
        }      
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();
                string nombre = cmbNombreLibros.Text;

                // Consulta SQL para verificar si el dato existe
                string query = "SELECT COUNT(*) FROM INVENTARIO WHERE Nombre_Libro = @nombre";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nombre", nombre);

                // Ejecutar la consulta
                int count = (int)command.ExecuteScalar();

                if (count == 0)
                {
                    //PROCESO PARA CAMBIAR EL FORMATO DE LA FECHA Y PODER ENVIARLO A LA BASE DE DATOS

                    string fechaOriginal = calendarioB.Text;

                    // Convertir la cadena a un objeto DateTime
                    DateTime fechaConvertida = DateTime.ParseExact(fechaOriginal, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    // Formatear la fecha al nuevo formato "yyyy-MM-dd"
                    string fechaNueva = fechaConvertida.ToString("yyyy-MM-dd");

                    //Comando para insertar un registro
                    SqlCommand cmd = new SqlCommand("insert into INVENTARIO([Nombre_Libro], [Cantidad_Libros], [Fecha_Adicion], " +
                        "[Ann_Publicacion], [Precio], [Autor], [Cantidad_Vendida], [ID_Genero], [ID_Existencia],[ID_Seccion], " +
                        "[ID_Formato],[Visible]) values('" + this.cmbNombreLibros.Text + "', " + Convert.ToInt32(this.txtCantidadDe.Text) +
                        ", '" + fechaNueva + "', " + Convert.ToInt32(this.txtAnnPubli.Text) + ", " + Convert.ToDecimal(this.txtPrecio.Text) + ", '" +
                        this.txtAutor.Text + "', " + Convert.ToInt32(this.txtCantVen.Text) + ", " + idgenero + ", " + idExistenciaB +
                        ", " + idSeccion + ", " + idFormato + ", " + 1 + ")", conexion);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro modificado exitosamente, refresque el programa para reflejarlo");
                }
                else
                {
                    MessageBox.Show("El nombre del libro ingresado ya existe o existio, favor de ingresar otro");
                }
                conexion.Close();

                limpiarCampos();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema, revise los campos llenados");
            }
                       
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            //ReiniciarAplicacion(); <------------- (Obviamente era una idea nada optima XDDDDD)

            try
            {
                datosLibro = new Dictionary<int, string>();
                datosGenero = new Dictionary<int, string>();
                datosFormato = new Dictionary<int, string>();
                datosEditoriales = new Dictionary<int, string>();
                cmbEditorialesAsignadas.Items.Clear();
                cmbEditorialesDisponibles.Text = "";
                cmbEditorialesAsignadas.Text = "";
                cmbNombres_Consulta2.Text = "";

                CargarLibros();
                CargarGeneros();
                CargarFormato();
                CargarEditoriales();
                cargarEditorialesAsignadas();
                limpiarCampos();
            }
            catch
            {
                MessageBox.Show("Llamen a dios D:");
            }
            
        }


        //BOTONES PARA MANIPULAR REGISTROS DE LA SEGUNDA HOJA
        //====================================================================================================================
        private void btnEliminarEditorial_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();

                //Comando para eliminar un registro
                SqlCommand cmd = new SqlCommand("DELETE FROM Libro_Editorial where ID_Libro = " + idNombresConsulta2 +" AND ID_Editorial = "+ idEditorialesAsignadas, conexion);
                cmd.ExecuteNonQuery();

                //Mensaje de exito
                MessageBox.Show("Se realizo la eliminacion correctamente, refresque para reflejar cambio");

                //Se actualiza el combobox

                conexion.Close();

                cmbEditorialesAsignadas.Text = "";
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //EVENTOS PARA LIMITAR LOS CARACTERES QUE ACEPTA CADA CAMPO
        //====================================================================================================================
        private void txtAnnPubli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admiten numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantidadDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admiten numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantVen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admiten numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admiten letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void cmbGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        //Esta excepcion particularmente acepta tambien puntos, para poder enviar decimales
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admiten numeros y decimales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void cmbAddGeneros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admiten letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void cmbAddFormatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admiten letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void cmbAddEditoriales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admiten letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CONSULTAR_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Si hay elementos en el ComboBox
            if (cmbNombreLibros.Items.Count > 0)
            {
                // Obtener el índice actual
                int indiceActual = 0;

                // Seleccionar el siguiente elemento
                cmbNombreLibros.SelectedIndex = indiceActual;
            }
            else
            {
                MessageBox.Show("El ComboBox está vacío.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Si hay elementos en el ComboBox
            if (cmbNombreLibros.Items.Count > 0)
            {
                // Obtener el índice actual
                int indiceActual = cmbNombreLibros.SelectedIndex;

                // Calcular el índice del siguiente elemento
                int anteriorIndice = (indiceActual - 1 + cmbNombreLibros.Items.Count) % cmbNombreLibros.Items.Count;

                // Seleccionar el siguiente elemento
                cmbNombreLibros.SelectedIndex = anteriorIndice;
            }
            else
            {
                MessageBox.Show("El ComboBox está vacío.");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Si hay elementos en el ComboBox
            if (cmbNombreLibros.Items.Count > 0)
            {
                // Obtener el índice actual
                int indiceActual = cmbNombreLibros.SelectedIndex;

                // Calcular el índice del siguiente elemento
                int siguienteIndice = (indiceActual + 1) % cmbNombreLibros.Items.Count;

                // Seleccionar el siguiente elemento
                cmbNombreLibros.SelectedIndex = siguienteIndice;
            }
            else
            {
                MessageBox.Show("El ComboBox está vacío.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Si hay elementos en el ComboBox
            if (cmbNombreLibros.Items.Count > 0)
            {
                // Obtener el índice actual
                int indiceActual = cmbNombreLibros.Items.Count - 1;

                // Seleccionar el siguiente elemento
                cmbNombreLibros.SelectedIndex = indiceActual;
            }
            else
            {
                MessageBox.Show("El ComboBox está vacío.");
            }
        }

        //====================================================================================================================

        private void btnAsignarEditorial_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();

                //Comando para insertar un registro
                SqlCommand cmd = new SqlCommand("insert into Libro_Editorial values(" + idNombresConsulta2 + "," + idEditorialDisponible + ")", conexion);
                cmd.ExecuteNonQuery();

                MessageBox.Show("El registro se ha agregado exitosamente, refresque reflejarlo");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
            //Se limpia el combobox
            cmbEditorialesDisponibles.Text = "";
        }
        //====================================================================================================================

        //BOTONES PARA MANIPULAR REGISTROS DE LA TERCER HOJA
        //====================================================================================================================
        private void btnAddEditoriales_Click(object sender, EventArgs e)
        {
            try 
            { 
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();

                //Comando para eliminar un registro
                SqlCommand cmd = new SqlCommand("insert into Editorial values ('"+ this.cmbAddEditoriales.Text +"', "+ 1 +")", conexion);
                cmd.ExecuteNonQuery();

                MessageBox.Show("El registro se ha agregado exitosamente, refresque para reflejar cambios");
                conexion.Close();

                //Se limpia ese campo en especifico
                cmbAddEditoriales.Text = "";
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema, revise los campos llenados");
            }

        }
        private void btnDelEditoriales_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();

                //Comando para eliminar un registro
                SqlCommand cmd = new SqlCommand("update Editorial set Visible = 0 where ID_Editorial = " + idEditoriales, conexion);
                cmd.ExecuteNonQuery();

                //Mensaje de exito
                MessageBox.Show("Se realizo la eliminacion correctamente, refresque los datos");

                //Se actualiza el combobox

                conexion.Close();

                cmbAddEditoriales.Text = "";
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }
        private void btnAddGeneros_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();

                //Comando para eliminar un registro
                SqlCommand cmd = new SqlCommand("insert into Genero values ('" + this.cmbAddGeneros.Text + "', " + 1 + ")", conexion);
                cmd.ExecuteNonQuery();

                MessageBox.Show("El registro se ha agregado exitosamente, refresque para reflejar cambios");
                conexion.Close();

                //Se limpia ese campo en especifico
                cmbAddGeneros.Text = "";
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema, revise los campos llenados");
            }
        }
        private void btnDelGeneros_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();

                //Comando para eliminar un registro
                SqlCommand cmd = new SqlCommand("update Genero set Visible = 0 where ID_Genero = " + idAddGeneros, conexion);
                cmd.ExecuteNonQuery();

                //Mensaje de exito
                MessageBox.Show("Se realizo la eliminacion correctamente, refresque los datos");

                //Se actualiza el combobox

                conexion.Close();

                cmbAddGeneros.Text = "";
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }
        private void btnAddFormatos_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();

                //Comando para eliminar un registro
                SqlCommand cmd = new SqlCommand("insert into Formato values ('" + this.cmbAddFormatos.Text + "', " + 1 + ")", conexion);
                cmd.ExecuteNonQuery();

                MessageBox.Show("El registro se ha agregado exitosamente, refresque para reflejar cambios");
                conexion.Close();

                //Se limpia ese campo en especifico
                cmbAddFormatos.Text = "";
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema, revise los campos llenados");
            }
        }
        private void btnDelFormatos_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();

                //Comando para eliminar un registro
                SqlCommand cmd = new SqlCommand("update Formato set Visible = 0 where ID_Formato = " + idAddFormato, conexion);
                cmd.ExecuteNonQuery();

                //Mensaje de exito
                MessageBox.Show("Se realizo la eliminacion correctamente, refresque los datos");

                //Se actualiza el combobox

                conexion.Close();

                cmbAddFormatos.Text = "";
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        //====================================================================================================================

        public void limpiarCampos()
        {
            cmbNombreLibros.Text = "";
            txtAnnPubli.Text = "";
            txtAutor.Text = "";
            txtCantidadDe.Text = "";
            calendarioB.Text = "";
            txtPrecio.Text = "";
            txtCantVen.Text = "";
            cmbGenero.SelectedIndex = -1;
            cmbExistencia.SelectedIndex = -1;
            cmbSeccion.SelectedIndex = -1;
            cmbFormato.SelectedIndex = -1;
        } 

        //PROCESO PARA ACTUALIZAR LOS DATOS AUTOMATICAMENTE AL CAMBIAR DE ELEMENTO EN LA SECCION DE CONSULTA
        private void NombreLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            SqlCommand cm = new SqlCommand("select*from INVENTARIO where Nombre_Libro='" + cmbNombreLibros.Text + "'", conexion);
            SqlDataReader dr = cm.ExecuteReader();
            try
            {
                try
                {
                    // Obtener la ID del registro seleccionado
                    if (cmbNombreLibros.SelectedItem != null)
                    {
                        var seleccion = (KeyValuePair<int, string>)cmbNombreLibros.SelectedItem;
                        //CAMBIAR ESTA VARIABLE POR UNA VARIABLE GLOBAL
                        idLibro = seleccion.Key;
                        string nombreSeleccionado = seleccion.Value;

                        //SI HAY ALGUN ELEMENTO SELECCIONADO, AUTOMATICAMENTE SE RELLENAN LOS CAMPOS
                        if (dr.Read() == true)
                        {
                            txtCantidadDe.Text = dr["Cantidad_Libros"].ToString();
                            //txtFechaAdd.Text = dr["Fecha_Adicion"].ToString();
                            calendarioB.Text = dr["Fecha_Adicion"].ToString();

                            txtAnnPubli.Text = dr["Ann_Publicacion"].ToString();
                            txtPrecio.Text = dr["Precio"].ToString();
                            txtAutor.Text = dr["Autor"].ToString();
                            txtCantVen.Text = dr["Cantidad_Vendida"].ToString();

                            //ESTE BLOQUESITO DE CODIGO + EL METODO PARA CARGAR DATOS AUTOMATICAMENTE
                            //PERMITEN ACTUALIZAR LA CONSULTA DE ESTE CAMPO
                            //NO OLVIDAR QUE EL DICCIONARIO SE DECLARA COMO VARIABLE GLOBAL
                            string gen = dr["ID_Genero"].ToString();
                            int genNum = int.Parse(gen);
                            string valorGenero = datosGenero[genNum];
                            cmbGenero.Text = valorGenero;

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Selecciono un libro con un elemento invalido, dicho recuadro aparecera en blanco");
                    cmbGenero.Text = "";
                }
                finally
                {
                    //===================================================================
                    string sec = dr["ID_Seccion"].ToString();
                    int secNum = int.Parse(sec);
                    int valorSeccion = datosSeccion[secNum];
                    cmbSeccion.Text = valorSeccion.ToString();
                    //===================================================================
                    string exis = dr["ID_Existencia"].ToString();
                    int secExis = int.Parse(exis);
                    string valorExistencia = datosExistenciaB[secExis];
                    cmbExistencia.Text = valorExistencia;
                    //===================================================================
                    string formato = dr["ID_Formato"].ToString();
                    int secFormato = int.Parse(formato);
                    string valorFormato = datosFormato[secFormato];
                    cmbFormato.Text = valorFormato;
                    //===================================================================
                    conexion.Close();
                }
            }
            catch
            {
                MessageBox.Show("No hay elementos para cargar, favor de ingresar algunos");
            }
            
        }
    }
}
