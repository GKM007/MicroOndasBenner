using System.Collections.Generic;

namespace MicroOndasBenner.Dominio.Interface
{
    public interface ITipoAquecimento
    {
        AquecimentoNegocio BuscarPorPrograma(int idPrograma);
        IList<AquecimentoNegocio> ListarTodosTipodeAquecimento();
        AquecimentoNegocio IncluirPrograma(AquecimentoNegocio tipoAquecimento);
    }
}
