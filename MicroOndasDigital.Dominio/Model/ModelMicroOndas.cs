namespace MicroOndasBenner.Dominio
{
    public class ModelMicroOndas
    {
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public bool EhValido { get; protected set; }
        public string Mensagem { get; protected set; }
        public int Id { get; set; }
        public string Nome { get; set; }

        protected void ValidacoesModel()
        {
            if (Tempo < 1 || Tempo > 120)
            {
                Mensagem = Mensagens.MsgValidacaoTempo;
                return;
            }

            if (Potencia < 1 || Potencia > 10)
            {
                Mensagem = Mensagens.MsgValidacaoPotencia;
                return;
            }

            EhValido = true;
        }
    }
}
