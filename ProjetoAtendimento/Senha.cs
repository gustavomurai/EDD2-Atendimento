using System;

namespace ProjetoAtendimento
{
    public class Senha
    {
        public int Id { get; private set; }
        public DateTime DataGerac { get; private set; }
        public DateTime? DataAtend { get; private set; }

        public Senha(int id)
        {
            Id = id;
            DataGerac = DateTime.Now;
            DataAtend = null;
        }

        public void RegistrarAtendimento()
        {
            DataAtend = DateTime.Now;
        }

        public string DadosParciais()
        {
            return $"{Id} - {DataGerac:dd/MM/yyyy} - {DataGerac:HH:mm:ss}";
        }

        public string DadosCompletos()
        {
            if (DataAtend.HasValue)
            {
                return $"{Id} - Gerada: {DataGerac:dd/MM/yyyy HH:mm:ss} - Atendida: {DataAtend:dd/MM/yyyy HH:mm:ss}";
            }
            else
            {
                return $"{Id} - Gerada: {DataGerac:dd/MM/yyyy HH:mm:ss} - Não atendida";
            }
        }

        public override string ToString()
        {
            return DadosParciais();
        }
    }
}
