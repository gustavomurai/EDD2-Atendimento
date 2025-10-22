using System.Collections.Generic;

namespace ProjetoAtendimento
{
    public class Senhas
    {
        public int ProximoAtendimento { get; private set; }
        public Queue<Senha> FilaSenhas { get; private set; }

        public Senhas()
        {
            ProximoAtendimento = 1;
            FilaSenhas = new Queue<Senha>();
        }

        public Senha Gerar()
        {
            var s = new Senha(ProximoAtendimento);
            FilaSenhas.Enqueue(s);
            ProximoAtendimento++;
            return s;
        }
    }
}
