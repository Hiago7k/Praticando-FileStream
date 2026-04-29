

using System.Text;

var enderecoDoArquivo = "pessoas.txt";

var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
var buffer = new byte[1024];
fluxoDoArquivo.Read(buffer, 0, 1024);


var utf8 = new UTF8Encoding();
var texto = utf8.GetString(buffer);
Console.WriteLine(texto);


