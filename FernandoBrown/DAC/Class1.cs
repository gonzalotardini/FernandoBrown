using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAC
{
    public class Producto
    {
        public string nombre;
        public int id; //int como id (?
        public string imagen; //url de la imagen
        public string descripcion;
        public string categoria; //Esto debería ser un enum? No más bien un arbol, o un composite idk
        public float precio;
    }
}
