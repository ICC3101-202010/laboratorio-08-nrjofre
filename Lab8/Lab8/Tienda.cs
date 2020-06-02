using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Tienda
    {
        public string nombre;
        public string dueño;
        public string id;
        public string horario;
        public string categorias;

        public Tienda(string nombre, string id, string dueño, string horario, string categorias)
        {
            this.nombre = nombre;
            this.dueño = dueño;
            this.id = id;
            this.horario = horario;
            this.categorias = categorias;
        }
    }
}
