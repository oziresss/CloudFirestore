using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudFirestore
{
    public class CloudFirestore
    {
        public async Task InserirRegistro(IEnumerable<Google.Apis.Storage.v1.Data.Object>? documentos)
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "service-account-cloudfirestore.json");
            Console.WriteLine($"CRIAÇÃO CONCLUÍIDA DA VARIÁVEL DE AMBIENTE.");

            FirestoreDb firestoreDb = FirestoreDb.Create("nome_projeto");
            foreach (var documento in documentos)
            {
                DocumentReference docRef = firestoreDb.Collection("nome_colecao").Document();
                Documentos doc = new Documentos
                {
                    Id = documento.Id,
                    Caminho = documento.Name,
                    Nome = Extracao.Nome(documento.Name),
                    MediaLink = documento.MediaLink,
                    Bucket = documento.Bucket,
                    TipoConteudo = documento.ContentType,
                    Tamanho = Extracao.Bytes(documento?.Size),
                    DataCriacao = Extracao.Datas(documento?.TimeCreated),
                    Plataforma = "Google",
                    Cpf = Extracao.Cpf(documento.Name)
                };

                await docRef.SetAsync(doc);
                Console.WriteLine($"INSERÇÃO CONCLUÍDA DO ARQUIVO: {documento.Name}.");
            }
        }
    }
}
