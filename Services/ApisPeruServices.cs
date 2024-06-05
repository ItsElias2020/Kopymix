using IServices;
using RequestResponseModel;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace Services
{
    public class ApisPeruServices : IApisPeruServices
    {
        ApisPeruEmpresaResponse empresaResult;
        ApisPeruPersonaResponse personaResult;
        public ApisPeruServices()
        {
            empresaResult = new ApisPeruEmpresaResponse();
            personaResult = new ApisPeruPersonaResponse();
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


        public ApisPeruEmpresaResponse EmpresaPorRUC(string dni)
        {
            return new ApisPeruEmpresaResponse();
            //throw new NotImplementedException();
        }

        public ApisPeruPersonaResponse PersonaPorDNI(string dni)
        {
            PersonaPorDNITask(dni).GetAwaiter().GetResult();
            return personaResult;
        }

        public async Task PersonaPorDNITask(string dni)
        {
            string url = "https://dniruc.apisperu.com/api/v1/dni/##DNI##?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImkyMjEyNzY3QGNvbnRpbmVudGFsLmVkdS5wZSJ9.wSfQ3qsRnqoDn0IvDnSM2zstHVMmJwztvggRYN8SR6w";
            url = url.Replace("##DNI##", dni);

            using (HttpClient client = new HttpClient())
            {
                //con la seguridad de C#
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback = delegate
                (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                { return true; };

                //https | http

                //EN EL CASO DE QUE LA URL O SERVICIO SOLICITE UN TOKEN
                // ==> client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "token jwt");

                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    if (response.StatusCode == HttpStatusCode.OK)//200
                    {
                        string jsonResult = await response.Content.ReadAsStringAsync();

#pragma warning disable CS8601 // Possible null reference assignment.
                        personaResult = JsonConvert.DeserializeObject<ApisPeruPersonaResponse>(jsonResult);
                    }
                    else
                    {
                        //VAMOS A MANEJAR UN CONTROL DE ERRORES
                    }
                }
            }
        }
    }
}