using System.Collections.Generic;

namespace ProjetoAtendimento
{
    public class Guiche
    {
        public int Id { get; private set; }
        public Queue<Senha> Atendimentos { get; private set; }

        public Guiche(int id)
        {
            Id = id;
            Atendimentos = new Queue<Senha>();
        }

        // Tenta chamar próxima senha da fila global e colocar neste guichê
        // Retorna true se conseguiu chamar (havia senha)
        public bool Chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas == null || filaSenhas.Count == 0)
                return false;

            var s = filaSenhas.Dequeue();
            s.RegistrarAtendimento();
            Atendimentos.Enqueue(s);
            return true;
        }

        public override string ToString()
        {
            return $"Guichê {Id}";
        }
    }
}
