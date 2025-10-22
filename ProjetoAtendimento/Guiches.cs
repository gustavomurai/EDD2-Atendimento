using System.Collections.Generic;
using System.Linq;

namespace ProjetoAtendimento
{
    public class Guiches
    {
        public List<Guiche> ListaGuiches { get; private set; }

        public Guiches()
        {
            ListaGuiches = new List<Guiche>();
        }

        public void Adicionar(Guiche g)
        {
            if (g != null)
                ListaGuiches.Add(g);
        }

        public Guiche ObterPorId(int id)
        {
            return ListaGuiches.FirstOrDefault(x => x.Id == id);
        }

        public int Quantidade()
        {
            return ListaGuiches.Count;
        }
    }
}
