using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudFirestore
{
    public class CloudStorage
    {
        public IEnumerable<Google.Apis.Storage.v1.Data.Object>? BuscarDados()
        {
            var googleCredential = GoogleCredential.FromFile("service-account-cloudstorage.json");
            Console.WriteLine("AUTENTICAÇÃO CONCLUÍDA DAS CREDENCIAIS DO GCP.");
            var storageClient = StorageClient.Create(googleCredential);
            var listObjects = storageClient.ListObjects("nome_bucket");
            Console.WriteLine($"QUANTIDADE DE DOCUMENTOS ENCONTRADOS: {listObjects.Count()}.");
            return listObjects;
        }
    }
}
