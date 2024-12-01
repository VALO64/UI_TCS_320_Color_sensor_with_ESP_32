using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

/*
This code was made by: Oscar Alberto Valles Limas 
*/
namespace UI_TCS_320_with_ESP_32
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent(); //Llama a la funcion para inicializar el componente
            configuracionInicial(); //Llama a la funcion configuracion inical 
        }
        private void configuracionInicial() //Funcion configuracion inicial
        {
            //Incializamos el puerto serial:
            serialPort = new SerialPort();
            //serialPort.DataReceived += SerialPort_DataReceived;

            CargarPuertosDisponibles(); //Llama a la funcion para mostrar los puertos disponibles 

            CargarBaudRate(); //Llama a la funcion para mostrar el Baud Rate

            btnDesconectar.Enabled = false; //Se configura el boton de desconectar como desabilitado 

            //Configuracion inicial de las imagenes de la UI:
            pictureazul.Visible = false; //Se configura la imagen del boton azul como invisible 
            picturerojo.Visible = false; //Se configura la imagen del boton rojo como invisible 
            pictureverde.Visible = false; //Se configura la imagen del boton verde como invisible 
            picturepistonactivado.Visible = false; //Se configura la imagen del piston activado como invisible 
            picturepistondesactivado.Visible = true; //Se configura la imagen del piston activado como visible

        }

        private void CargarPuertosDisponibles() //Funcion para cargar los puertos disponibles 
        {
            COM.Items.Clear(); //Los items del com limpios 
            string[] puertos = SerialPort.GetPortNames(); //Se tiene un arreglo para obtener los nombres de los puertos 
            if (puertos.Length > 0) //Si el tamaño de los puertos es mayor a 0 
            {
                COM.Items.AddRange(puertos); //Se agrega el rango de los puertos 
                COM.SelectedIndex = 0; //Seleccion de puertos 
            }
            else //Cuando esto no pasa
            {
                //Se muestra un mensaje de que no se encontró ningun puerto disponible
                MessageBox.Show("No se encontraron puertos COM disponibles",
                "Advertencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
        private void CargarBaudRate() //Funcion para cargar el Baud Rate 
        {
            BaudRate.Items.Clear(); //Los items del Baud Rate estan limpios
            int[] velocidades = new int[] { 9600, 19200, 38400, 57600, 115200 }; //Se crea un arreglo con los Baud Rates mas comunes para su sellecion 
            foreach (int velocidad in velocidades) //Se obtienen las velocidades del arreglo 
            {
                BaudRate.Items.Add(velocidad); //Se selecciona la velocidad 
            }
            BaudRate.SelectedIndex = 0;
        }

        private void btnConectar_Click(object sender, EventArgs e) //Evento del click conectar 
        {
            if (COM.SelectedItem == null) //Si no se selecciona un puerto COM 
            {
                //Se muestra un mensaje que debe ser seleccionado
                MessageBox.Show("Por favor seleccione un puerto COM",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return; //Regresa a la funcion principal para que se seleccione un puerto COM 
            }
            try //Se hace un try (Intento)
            {
                if (!serialPort.IsOpen) //Si el puerto serial está abierto 
                {
                    serialPort.PortName = COM.SelectedItem.ToString(); //Se obtiene el nombre del puerto del combo box llamado COM 
                    serialPort.BaudRate = Convert.ToInt32(BaudRate.SelectedItem); //Se obtiene el Bad Rate seleccionado 
                    serialPort.Open(); //Abre el puerto serial (COM)

                    // Cambiar estado de los controles
                    btnConectar.Enabled = false; //Se desabilita el boton conectar para que ya no se utilice 
                    btnDesconectar.Enabled = true; //Se habilita el boton desconectar 
                    COM.Enabled = false; //Se desabilita el combo box COM
                    BaudRate.Enabled = false; //Se desabilita el combo box Baud Rate  

                    //Se muesta el mensaje de que la conexion se establecio correctamente
                    MessageBox.Show("Conexión establecida correctamente",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) //En caso de que la conexion falle
            {
                //Muestra un mensaje de error
                MessageBox.Show($"Error en la conexión: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void btnDesconectar_Click(object sender, EventArgs e) //Evento del click desconectar
        {
            try //Intenta 
            {
                if (serialPort.IsOpen) //Condicional si el puerto serial esta abierto 
                {
                    serialPort.Close(); //Cierra la conexion con el puerto serial

                    // Restaurar estado de los controles
                    btnConectar.Enabled = true; //Habilita el boton conectar
                    btnDesconectar.Enabled = false; //Desabilita el boton desconectar 
                    COM.Enabled = true; //Habilita la seleccion de los puertos COM del combo box 
                    BaudRate.Enabled = true; //Habilita la seleccion del Baud rate del combo box 

                    // Ocultar todas las imágenes al desconectar
                    pictureazul.Visible = false; //Oculta la imagen de azul 
                    picturerojo.Visible = false; //Oculta la imagen de rojo 
                    pictureverde.Visible = false; //Oculta la imagen de verde 
                    picturepistonactivado.Visible = false; //Oculta la imagen del piston activado 
                    picturepistondesactivado.Visible = true; //Muesta la imagen del pisto desactivado

                    //Muestra un mensaje que la conexion se desactivo correctamente
                    MessageBox.Show("Dispositivo desconectado correctamente",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            //En caso de que suceda algun error 
            catch (Exception ex)
            {
                //Muestra un mensaje de error
                MessageBox.Show($"Error al desconectar: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnRojo_Click(object sender, EventArgs e) //Evento del click al boton rojo 
        {
            try //Intenta 
            {
                if (serialPort.IsOpen) //Si el puerto serial esta abierto 
                {
                    serialPort.WriteLine("r"); //Va a escribir la siguiente linea en el puerto serial 
                }
                else //Si no es asi 
                {
                    //Se muestra el mensaje de que el puerto aun no esta abierto
                    MessageBox.Show("El puerto serial no está abierto",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            //En caso de que falle
            catch (Exception ex)
            {
                //Manda un mensaje de error
                MessageBox.Show($"Error al enviar comando de deteccion Rojo: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnVerde_Click(object sender, EventArgs e) //Evento del click al boton verde
        {
            try //Intenta 
            {
                if (serialPort.IsOpen) //Si el puerto serial esta abierto 
                {
                    serialPort.WriteLine("v"); //Va a escribir la siguiente linea en el puerto serial 
                }
                else //Si no es asi 
                {
                    //Se muestra el mensaje de que el puerto aun no esta abierto
                    MessageBox.Show("El puerto serial no está abierto",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            //En caso de que falle
            catch (Exception ex)
            {
                //Manda un mensaje de error
                MessageBox.Show($"Error al enviar comando de deteccion Verde: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnAzul_Click(object sender, EventArgs e)  //Evento del click al boton azul
        {
            try //Intenta 
            {
                if (serialPort.IsOpen) //Si el puerto serial esta abierto 
                {
                    serialPort.WriteLine("a"); //Va a escribir la siguiente linea en el puerto serial 
                }
                else //Si no es asi 
                {
                    //Se muestra el mensaje de que el puerto aun no esta abierto
                    MessageBox.Show("El puerto serial no está abierto",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            //En caso de que falle
            catch (Exception ex)
            {
                //Manda un mensaje de error
                MessageBox.Show($"Error al enviar comando de deteccion Azul: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
