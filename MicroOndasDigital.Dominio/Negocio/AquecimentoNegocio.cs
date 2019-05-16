using MicroOndasBenner.Dominio.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

namespace MicroOndasBenner.Dominio
{
    public class AquecimentoNegocio : ModelMicroOndas, ITipoAquecimento
    {
        public AquecimentoNegocio() { }
        readonly ObjectCache cache = MemoryCache.Default;
        private IList<AquecimentoNegocio> tipoAquecimentos = new List<AquecimentoNegocio>();

        public AquecimentoNegocio(int id, string nome, int potencia, int tempo)
        {
            Id = id;
            Tempo = tempo;
            Potencia = potencia;
            Nome = nome;

            ValidarNomeProgramaEmBranco();
        }

        public int Id { get; set; }

        public string Nome { get; }

        public AquecimentoNegocio BuscarPorPrograma(int idPrograma)
        {
            return ListarTodosTipodeAquecimento().Where(x => x.Id == idPrograma).FirstOrDefault();
        }

        public IList<AquecimentoNegocio> ListarTodosTipodeAquecimento()
        {
            return new TipoAquecimentoPreDefinidoNegocio().RetornaTipoAquecimento();
        }

        public AquecimentoNegocio IncluirPrograma(AquecimentoNegocio tipoAquecimento)
        {
            return new TipoAquecimentoPreDefinidoNegocio().AdicionarNovoPrograma(tipoAquecimento);
        }

        private void ValidarNomeProgramaEmBranco()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                Mensagem = Mensagens.MsgProgramaembranco;
                EhValido = false;
                return;
            }

            ValidacoesModel();
        }

    }
}
