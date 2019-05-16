using MicroOndasBenner.Servico.Dtos;
using System.Collections.Generic;

namespace MicroOndasBenner.Servico.Interface
{
    public interface IServico
    {
        DTOTipoAquecimento BuscarTipoAquecimento(int idPrograma);
        DTOMicroOndas IniciarMicroOndas(int tempo, int potencia);
        DTOMicroOndas InicioRapido();
        IList<DTOTipoAquecimento> ListarTiposAquecimento();
        DTOTipoAquecimento AdicionarNovoPrograma(DTOTipoAquecimento tipoAquecimento);
    }
}
