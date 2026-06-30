El siguiente sistema que utiliza las tecnologías de C#, Sql Server y Balsamiq Mockups, fue desarrollado de 09-2017 a 09-2018, para una Parroquia en Acapulco, Gro.
El objetivo es la generación y gestión de Boletas de Bautismo, Confirmación, Primera Comunión y Matrimonios.

A continuación se detalla su funcionamiento:

<b>Inicio de Sesión</b><br>
En el Escritorio, en el acceso directo, hacemos doble clic sobre “Boletas San Cristóbal”, nos aparecerá la siguiente ventana de inicio de sesión:<br>
<img width="348" height="219" alt="image" src="https://github.com/user-attachments/assets/a5ebe248-b7c3-47e4-8857-c1b34c3bc50f" />

Luego de esto, hacemos clic en “Iniciar Sesión”. Esto hará que se abra la interfaz del programa, la cual se muestra a continuación:

<img width="842" height="602" alt="image" src="https://github.com/user-attachments/assets/940eb152-c85f-466a-b25f-97a705d03586" />

A continuación conoceremos los módulos que conforman al sistema, los cuales son:<br>
• Administrar. Dedicado a la generación de boletas y creación de respaldos de la base de datos.<br>
• Catálogo. Contiene registros de los empleados (uno ya incluido por default), catequistas, párroco, ministros, y estados (ya precargados).<br>
• Configuración. Para la creación de nuevos usuarios (a partir de empleados), e información en general de la parroquia.<br>
• Ayuda. Información en general acerca del programa, y contacto a soporte técnico.<br>

La estructura de cada módulo de boleta es como el siguiente:<br>

<b>Módulos de Boletas</b><br>
La gestión de la boleta de bautizos nos permite crear, editar, consultar y eliminar información de los bautizados, el requisito previo antes de crear un nuevo registro es al menos, que exista un ministro registrado (se puede registrar en el módulo de Configuración).
<img width="842" height="602" alt="image" src="https://github.com/user-attachments/assets/ce0abb61-43de-4775-a6ed-b3c7b5d2b9f8" /><br>
Al hacer clic en el “Botón de Crear”, aparece la siguiente ventana modal, que nos solicita recabar los datos para la creación del nuevo bautizado; es condición que para crear al menos un registro, esté dado de alta por lo menos un “Ministro” y un “Estado” (en el módulo “Catálogos” es donde se pueden
dar de alta los ministros y estados), ya que estos son datos obligatorios y que el formulario extrae de la base de datos:

<img width="1366" height="671" alt="image" src="https://github.com/user-attachments/assets/58b4d19c-a334-482f-95d2-d7501264ecc2" /><br>

Cuando ya tengan llenos los campos obligatorios, hacemos clic en “Guardar”, en caso contrario, hacemos clic en “Regresar”.
Al tener nuestro primer registro, este aparecerá en la “tabla de datos” mencionada algunos párrafos atrás:
<img width="1366" height="668" alt="image" src="https://github.com/user-attachments/assets/2692cb2b-2773-4a90-afe6-517e5f4b8749" /><br>
Si queremos consultar los datos completos, seleccionamos el registro que queramos, como en la imagen anterior, y después hacemos clic el “Botón de Consulta”, de esta manera se nos mostrará la información del registro como se muestra a continuación:<br>
<img width="645" height="649" alt="image" src="https://github.com/user-attachments/assets/ca8c7bdc-6ad7-4fc1-8721-660a1524ca66" /><br>
Si queremos modificar la información del registro, seleccionamos el registro del bautizado que nos interese de la “tabla de datos”, y seleccionamos el “Botón de Editar”. A continuación nos aparecerá la siguiente información del bautizado con la posibilidad de cambiar lo que queramos:<br>
<img width="645" height="655" alt="image" src="https://github.com/user-attachments/assets/b9596c01-20cc-4d84-86b6-067c2a14084d" /><br>
Para eliminar un registro, de la misma forma, seleccionamos el registro del bautizado que queramos, y hacemos clic en el “Botón de Eliminar”, nos aparecerá la siguiente ventana, preguntándonos si queremos eliminar el registro seleccionado:<br>
<img width="645" height="652" alt="image" src="https://github.com/user-attachments/assets/743599b0-949d-43de-b28e-9a1f63060b0b" /><br>
Si queremos generar una boleta con los datos registrados, seleccionamos el registro, y después hacemos clic en el botón "Generar Boleta", hecho esto se generará la siguiente ventana que nos avisará que la boleta ha sido generada satisfactoriamente:<br>
<img width="645" height="669" alt="image" src="https://github.com/user-attachments/assets/1bd26937-0eb1-484c-b00f-79f534ddb13b" />

<b>Respaldos</b><br>
El sistema también permite realizar respaldos y cargarlos en el sistema:<br>
<img width="336" height="133" alt="image" src="https://github.com/user-attachments/assets/11d3b061-4222-43cd-8e35-7b934217a55e" /><br>
Al hacer clic en “Respaldar” se abre la siguiente ventana, que nos indica que debemos seleccionar una ruta en el equipo donde se va a almacenar el respaldo: <br>
<img width="1350" height="655" alt="image" src="https://github.com/user-attachments/assets/b7b80ff5-d0ae-4894-83c6-ca263cd3bb06" /><br>
Una vez terminado, aparecerá la siguiente ventana que nos indica que el respaldo se ha creado satisfactoriamente, caso contrario, aparecerá una ventana que indica que hubo un error al respaldar. Finalmente hacemos clic en “Aceptar”:<br>
<img width="398" height="162" alt="image" src="https://github.com/user-attachments/assets/1813ee29-99dc-4662-b237-2960fe527ce4" />

<b>Empleados</b><br>
Se gestionan de manera similar a las personas que se registran en los Módulos de Boleta, se refiere al personal que labora en la parroquia:<br>
<img width="842" height="602" alt="image" src="https://github.com/user-attachments/assets/9d710bf0-a4cc-4170-ae00-561794f0a9e0" /><br>
Al registrar un nuevo empleado, aparecerá una ventana como la siguiente; los datos obligatorios son los que aparecen en la imagen.<br>
<img width="1352" height="658" alt="image" src="https://github.com/user-attachments/assets/36a9284b-c8e9-44c8-8d7a-1880b92d85c5" /> <br>




