using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudFirestore
{
    [FirestoreData]
    public class Documentos
    {
        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public string Caminho { get; set; }
        [FirestoreProperty]
        public string Nome { get; set; }
        [FirestoreProperty]
        public string MediaLink { get; set; }
        [FirestoreProperty]
        public string Bucket { get; set; }
        [FirestoreProperty]
        public string TipoConteudo { get; set; }
        [FirestoreProperty]
        public byte[] Tamanho { get; set; }
        [FirestoreProperty]
        public DateTime? DataCriacao { get; set; }
        [FirestoreProperty]
        public string Plataforma { get; set; }
        [FirestoreProperty]
        public string Cpf { get; set; }
    }
}
