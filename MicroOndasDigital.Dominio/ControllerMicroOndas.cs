using System.Collections.Generic;
using System.Linq;
using MicroOndasBenner.Dominio.Interface;
using MicroOndasBenner.Servico.Dtos;
using MicroOndasBenner.Servico.Interface;

namespace MicroOndasBenner.Servico
{
    public class ControllerMicroOndas : IServico
    {
        private readonly ITipoAquecimento _tipoAquecimento;
        private readonly IMicroOndas _microOndas;

        public ControllerMicroOndas()
        {
            _tipoAquecimento = new Dominio.AquecimentoNegocio();
            _microOndas = new Dominio.MicroOndasNegocio();
        }

        public DTOMicroOndas InicioRapido()
        {
            var microOndas = _microOndas.InicioRapido();
            return TransformarObjetoParaDto(microOndas);
        }

        public DTOMicroOndas IniciarMicroOndas(int tempo, int potencia)
        {
            var microOndas = _microOndas.Ligar(tempo, potencia);
            return TransformarObjetoParaDto(microOndas);
        }

        public DTOTipoAquecimento BuscarTipoAquecimento(int idPrograma)
        {
            var microOndas = _tipoAquecimento.BuscarPorPrograma(idPrograma);
            return TransformarObjetoParaDto(microOndas);
        }

        public IList<DTOTipoAquecimento> ListarTiposAquecimento()
        {
            var microOndas = _tipoAquecimento.ListarTodosTipodeAquecimento();
            return TransformarObjetoParaDto(microOndas);
        }

        public DTOTipoAquecimento AdicionarNovoPrograma(DTOTipoAquecimento dtoTipoAquecimento)
        {
            var microOndas = _tipoAquecimento.IncluirPrograma(TransformarDtoParaObjeto(dtoTipoAquecimento));
            return TransformarObjetoParaDto(microOndas);
        }

        private Dominio.AquecimentoNegocio TransformarDtoParaObjeto(DTOTipoAquecimento dtoTipoAquecimento)
        {
            return new Dominio.AquecimentoNegocio(dtoTipoAquecimento.Id, dtoTipoAquecimento.Nome, dtoTipoAquecimento.Potencia, dtoTipoAquecimento.Tempo);
        }

        private DTOTipoAquecimento TransformarObjetoParaDto(Dominio.AquecimentoNegocio tipoAquecimento)
        {
            return new DTOTipoAquecimento()
            {
                Id = tipoAquecimento.Id,
                Nome = tipoAquecimento.Nome,
                Potencia = tipoAquecimento.Potencia,
                Tempo = tipoAquecimento.Tempo,
                EhValido = tipoAquecimento.EhValido,
                Mensagem = tipoAquecimento.Mensagem,
            };
        }

        private IList<DTOTipoAquecimento> TransformarObjetoParaDto(IList<Dominio.AquecimentoNegocio> tipoAquecimentos)
        {
            return tipoAquecimentos
                .Select(tipo => new DTOTipoAquecimento
                {
                    Id = tipo.Id,
                    Nome = tipo.Nome,
                    Potencia = tipo.Potencia,
                    Tempo = tipo.Tempo,
                    EhValido = tipo.EhValido,
                    Mensagem = tipo.Mensagem
                })
                .ToList();
        }

        private DTOMicroOndas TransformarObjetoParaDto(Dominio.MicroOndasNegocio microOndasDigital)
        {
            return new DTOMicroOndas()
            {
                Tempo = microOndasDigital.Tempo,
                Potencia = microOndasDigital.Potencia,
                EhValido = microOndasDigital.EhValido,
                Mensagem = microOndasDigital.Mensagem
            };
        }
    }
}