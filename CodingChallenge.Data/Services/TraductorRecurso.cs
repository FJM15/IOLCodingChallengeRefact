using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Services
{
    public class TraductorRecurso : ITraductor
    {
        // Creacion del ResourceManager para la lectura de recursos por cultura
        private ResourceManager rm = new ResourceManager("CodingChallenge.Data.Resources.Language", Assembly.GetExecutingAssembly());

        private string _cultura;

        // En este caso la cultura no es necesaria, pero lo sera para futuras implementaciones de Traduccion, por ejemplo para captura en DB
        public TraductorRecurso(string cultura)
        {
            _cultura = cultura;
        }

        public string GetTraduccion(string llave)
        {
            try
            {
                // Se captura el recurso siempre y cuando exista
                string traduccion = rm.GetString(llave);
                return traduccion;
            }
            catch (Exception)
            {
                // De ocurrir un error se retorna vacio
                return "";
            }

        }
    }
}
