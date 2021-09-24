using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMANA_9__CLASES___SMIS069221
{
    class Municipio
    {
        static void Main(string[] args)
        {
            //Asignamos los valores a la clase
            ClassMunicipio municipio = new ClassMunicipio(1102, "Berlín", "2,000", "13.5", "-88.5333 13° 30' 0 Norte, 88° 31' 60 Oeste");

            //Mostramos el resultado en un mensaje
            MessageBox.Show("ID del municipio: " + municipio.id_Municipio + "\r\n"+  " Nombre del municipio: " + municipio.nombre + "\r\n"
              +  "Población del municipio: " + municipio.población + "\r\n" + "Latitud del municipio: " + municipio.latitud + "\r\n" 
               + "Longitud del municipio: " + municipio.longitud,"Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}