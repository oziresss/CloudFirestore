using CloudFirestore;

public class Program
{
    private static async Task Main(string[] args)
    {
        var cloudFirestore = new CloudFirestore.CloudFirestore();
        var cloudStorage = new CloudFirestore.CloudStorage();

        var dataInicio = DateTime.Now;

        var documentos = cloudStorage.BuscarDados();
        await cloudFirestore.InserirRegistro(documentos);

        var dataFim = DateTime.Now;

        Console.WriteLine($"TEMPO DE EXECUÇÃO {dataFim.Minute - dataInicio.Minute} MINUTOS.");
    }
}