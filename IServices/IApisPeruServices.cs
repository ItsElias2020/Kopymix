using RequestResponseModel;

namespace IServices
{
    public interface IApisPeruServices : IDisposable
    {
        ApisPeruPersonaResponse PersonaPorDNI(string dni);
        ApisPeruEmpresaResponse EmpresaPorRUC(string dni);
    }
}