using MicroOndasBenner.Dominio.Interface;

namespace MicroOndasBenner.Dominio
{
    public class MicroOndasNegocio : ModelMicroOndas, IMicroOndas
    {
        public MicroOndasNegocio() { }

        public MicroOndasNegocio(int tempo, int potencia)
        {
            Tempo = tempo;
            Potencia = potencia;

            ValidacoesModel();
        }

        //Inicio rapido conforme paramentros 
        public MicroOndasNegocio InicioRapido()
        {
            return new MicroOndasNegocio(ParametroAquecimento.TempoCozimento, ParametroAquecimento.PotenciaCozimento);
        }

        public MicroOndasNegocio Ligar(int tempo, int potencia)
        {
            return new MicroOndasNegocio(tempo, potencia);
        }
    }
}
