namespace MicroOndasBenner.Dominio.Interface
{
    public interface IMicroOndas
    {
        MicroOndasNegocio Ligar(int tempo, int potencia);
        MicroOndasNegocio InicioRapido();
    }
}
