using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Direccion
    {
        public int Id { get; set; }

        public string Calle { get; set; }

        public int Altura { get; set; }

    }

    public class DireccionNegocio
    {
        public List<Direccion> listar()
        {
            List<Direccion> lista = new List<Direccion>();
            lista.Add(new Direccion());
            lista.Add(new Direccion());
            lista.Add(new Direccion());
            lista.Add(new Direccion());

            lista[0].Id = 1;
            lista[0].Calle = "Av. 9 de Julio";
            lista[0].Altura = 1043;

            lista[1].Id = 2;
            lista[1].Calle = "Av. Corrientes";
            lista[1].Altura = 1368;

            lista[2].Id = 3;
            lista[2].Calle = "Tucumán";
            lista[2].Altura = 1171;

            lista[3].Id = 4;
            lista[3].Calle = "Macacha Guemes";
            lista[3].Altura = 351;

            return lista;
        }
    }
}
