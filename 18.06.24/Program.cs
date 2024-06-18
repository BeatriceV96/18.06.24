using System.Text;
using System.Threading.Tasks;

namespace _18._06._24
{
    internal class Program
    {

            static void Main(string[] args)
            {
                Persona persona = new Persona();
                persona.Nome = "Giovanni";
                persona.Cognome = "Muciaccia";
                persona.Eta = 40;

                persona.Descrizione();
                persona.Descrizione(persona.Cognome);
                persona.Descrizione(persona.Eta);
                persona.Descrizione(persona.Nome, persona.Cognome, persona.Eta);
            }
        }

    }
