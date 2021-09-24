using System;
using System.Collections.Generic;
using System.Text;

namespace SEMANA_9__CLASES___SMIS069221
{
    class ClassMunicipio
    {
        //Definimos los miembros de la clase
        public int id_Municipio;
        public string nombre;
        public string población;
        public string latitud;
        public string longitud;


        public ClassMunicipio(int id_Municipio, string nombre, string población, string latitud, string longitud)
        {
            //Hacemos referencia a los atributos
            this.id_Municipio = id_Municipio;
            this.nombre = nombre;
            this.población = población;
            this.latitud = latitud;
            this.longitud = longitud;

        }
    }
}
