using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

namespace MicroOndasBenner.Dominio
{
    //Classe para apresentar e armazenar os dados de Tipo de Aquecimento pré definidos.
    public class TipoAquecimentoPreDefinidoNegocio
    {
        readonly ObjectCache cache = MemoryCache.Default;
        private IList<AquecimentoNegocio> tipoAquecimentos = new List<AquecimentoNegocio>();

        //Buscar os tipos de aquecimento
        public IList<AquecimentoNegocio> RetornaTipoAquecimento()
        {
            var cacheEmMemoria = new CacheItemPolicy();

            if (!cache.Contains("tipoAquecimentos"))
            {
                tipoAquecimentos = ListarTiposAquecimento();

                cache.Add("tipoAquecimentos", tipoAquecimentos, cacheEmMemoria);
            }
            else
            {
                tipoAquecimentos = (List<AquecimentoNegocio>)cache.Get("tipoAquecimentos");
            }

            return tipoAquecimentos;
        }

        //Adicionar novo tipo de aquecimento
        public AquecimentoNegocio AdicionarNovoPrograma(AquecimentoNegocio tipoAquecimento)
        {
            tipoAquecimentos = (List<AquecimentoNegocio>)cache.Get("tipoAquecimentos");

            var idTipoAquecimento = tipoAquecimentos.OrderByDescending(x => x.Id).First().Id + 1;

            tipoAquecimento.Id = idTipoAquecimento;

            if (tipoAquecimento.EhValido)
                tipoAquecimentos.Add(tipoAquecimento);

            return tipoAquecimento;
        }

        //Dados de tipo de aquecimento
        private IList<AquecimentoNegocio> ListarTiposAquecimento()
        {
            var tiposAquecimento = new List<AquecimentoNegocio>
            {
                new AquecimentoNegocio (1, "Carne de Porco",  2,  5 ),
                new AquecimentoNegocio (2, "Filé",  2, 7 ),
                new AquecimentoNegocio (3, "Lasanha",  7,  8 ),
                new AquecimentoNegocio (4, "Frango",  2,  3 ),
                new AquecimentoNegocio (5, "Bolo",  7,  1 )
            };

            return tiposAquecimento;
        }
    }
}
