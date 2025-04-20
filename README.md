## Extracción de contactos guía telefónica CNT

* **Entregables**
  * Flujo a nivel macro: [Flujo_Bizagi](https://1drv.ms/u/c/74c6f7f1eeafec65/ESzD3fu6zJJJlQzNSkqq1GsBGqSiW8whqdf0zmJfKaK3Ew?e=FeFHzU)
  * Proyecto cargado en GitHub

* **Instrucciones del ejercicio**
  * Ingresar a la pagina de CNT [Guía CNT](https://micnt.com.ec/cntapp/guia104/php/guia_cntat.php?hflagsubmit=0&cmbcriterio=3&cmbprov2=17&txtusuarioapellido=&txtusuarionombre=&captchaSelection=)
  * El robot debe ser capaz de buscar en la guía de telefónica los contactos por criterio de búsqueda por nombre y colocar el apellido en la casilla correspondiente.
  * El robot debe ser capaz de resolver el captcha.
  * El robot debe ser capaz de extraer los datos de la tabla paginada de por al menos 20 páginas.
  * El robot debe ser capaz de ordenar por ciudad, de mayor a menor en un archivo de Excel.
  * El robot debe almacenar el archivo con los contactos encontrados y enviar por mail al correo ingresado.

* **Instrucciones de instalación**
  * Clonar repositorio en la carpeta de su preferencia
    ```
    git clone https://github.com/Jaela-C/RPA_UiPath_JaelaCarlosama.git
    ```
  * Abrir el archivo llamado **ME_MainDirectoryCNT.xaml**.
  * Ejecutar el proceso.
 
* **Instrucciones de uso**
  * Al ejecutar el proceso el bot pedirá que ingrese un apellido, una provincia en mayúsculas y un correo electrónico, si todos los datos son correctos el bot realizará la consulta, caso contrario, finalizará la ejecución.

