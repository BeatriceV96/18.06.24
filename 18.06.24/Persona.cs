using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._06._24
{
    internal class Persona
    {
        string nome = "";
        string cognome = "";
        byte eta;

        public string Nome { get { return nome; } set { nome = value; } }
        public string Cognome { get { return cognome; } set { cognome = value; } }
        public byte Eta { get { return eta; } set { eta = value; } }

        public void Descrizione()
        {
            Console.WriteLine(" Nome: " + nome);
        }
        public void Descrizione(string cognome)
        {
            Console.WriteLine(" Cognome: " + cognome);
        }
        public void Descrizione(byte eta)
        {
            Console.WriteLine(" Anni: : " + eta);
        }
        public void Descrizione(string nome, string cognome, byte eta)
        {
            Console.WriteLine(" Descizione: " + nome + " " + cognome + " " + eta);
        }
    }
}

