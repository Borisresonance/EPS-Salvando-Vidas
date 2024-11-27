using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPS_Salvando_Vidas
{
    public class Paciente
    {
        // Properties of the Paciente class
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Estrato { get; set; }
        public string TipoAtencion { get; set; }
        public decimal Copago { get; set; }

        // Constructor (optional, you can create one if you prefer)
        public Paciente(int id, string nombre, int edad, int estrato, string tipoAtencion, decimal copago)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Estrato = estrato;
            TipoAtencion = tipoAtencion;
            Copago = copago;
        }

        // Default constructor if needed
        public Paciente() { }

        // You can also override ToString() for easy debugging or displaying in a list
        public override string ToString()
        {
            return $"{Nombre} ({Id}), Edad: {Edad}, Estrato: {Estrato}, Tipo de Atención: {TipoAtencion}, Copago: {Copago:C}";
        }
    }
}
