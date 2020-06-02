using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Cine
    {
        public string nombre;
        public string dueño;
        public string id;
        public string horario;
        public string nSalas;

        public Cine(string nombre, string id, string dueño, string horario, string nSalas)
        {
            this.nombre = nombre;
            this.dueño = dueño;
            this.id = id;
            this.horario = horario;
            this.nSalas = nSalas;
        }
    }
}
