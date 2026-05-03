using System.Text;


var caminhoDoArquivo = "pessoas.txt";


var fluxoDoArquvio = new FileStream(caminhoDoArquivo, FileMode.Open);
var buffer = new byte[1024];

fluxoDoArquvio.Read(buffer, 0, 1024);

var utf8 = new UTF8Encoding();
var text = utf8.GetString(buffer);

Console.WriteLine(text);
Console.WriteLine(text);
Console.WriteLine(text);
Console.WriteLine(text);
Console.WriteLine(text);
Console.WriteLine(text);


//text.Clone();

