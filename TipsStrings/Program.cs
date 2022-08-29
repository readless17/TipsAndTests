Console.WriteLine("Bem-vindo ao projeto Tips And Tests em C# \n\n");

//----------------------------------------------------
Console.WriteLine("Trabalhando com string \n");
//----------------------------------------------------
Console.WriteLine("");
Console.WriteLine("Formatação de strings com uso de Format");
Console.WriteLine("--------------------");
string nome = "João";
string sobrenome = "Santos";
var nomeCompleto = nome + " " + sobrenome;
Console.WriteLine("Mensagem base: " + nome + " - " + sobrenome);
var mensagemFormatada = string.Format("Nome Completo = {0}", nomeCompleto);
Console.WriteLine("Resultado - " + mensagemFormatada);

Console.WriteLine("");
Console.WriteLine("Formatação de strings com uso de Interpolação");
Console.WriteLine("--------------------");
string nomeAluno = "Harry";
string nomeProfessor = "Minerva";
string mensagem =
    $"Aluno {nomeAluno}, Você foi aprovado(a) com sucesso! " +
    $"Atenciosamente, Prof. {nomeProfessor}";
Console.WriteLine("Resultado - " + mensagem);

Console.WriteLine("");
Console.WriteLine("Formatação de strings com uso de Verbatim strings");
Console.WriteLine("--------------------");
Console.WriteLine("Resultado:");
string semestre = "Janeiro\nFevereiro\nMarço\nAbril\nMaio\nJunho";
Console.WriteLine("Resultado:");
Console.WriteLine(semestre);
Console.WriteLine("OBS: o caractere '@' antes das aspas duplas ignora barras de Verbatim strings");
string diretorio = @"C:\temp\codigo";
Console.WriteLine("Resultado - Exemplo: " + diretorio);

//----------------------------------------------------
Console.WriteLine("\n\n");
Console.WriteLine("Métodos e propriedades para strings\n");
//----------------------------------------------------

Console.WriteLine("Método Length");
Console.WriteLine("--------------------");
var textoLength = "Entendendo strings em C#.";
Console.WriteLine("Mensagem base: " + textoLength);
Console.WriteLine("Resultado - Número de caracteres da mensagem base = " + textoLength.Length);

Console.WriteLine("");
Console.WriteLine("Métodos IndexOf e LastIndexOf");
Console.WriteLine("--------------------");
string mensagemIndex = "Entendendo como manipular strings com C#.";
Console.WriteLine("Mensagem base: " + mensagemIndex);
Console.WriteLine("Resultado - Primeira ocorrência do caractere {E} = Posição: " + mensagemIndex.IndexOf("E"));
Console.WriteLine("Resultado - Primeira ocorrência do caractere {e} = Posição: " + mensagemIndex.IndexOf("e"));
Console.WriteLine("Resultado - Última ocorrência do caractere {e} = Posição: " + mensagemIndex.LastIndexOf("e"));

Console.WriteLine("");
Console.WriteLine("Método Join");
Console.WriteLine("--------------------");
var texto = "Manipulando";
var complemento = "strings com C#";
Console.WriteLine("Mensagem base: " + texto + " - " + complemento);
var resultado = String.Join(" ", new String[] { texto, complemento });
Console.WriteLine("Resultado - " + resultado);

Console.WriteLine("");
Console.WriteLine("Método Split");
Console.WriteLine("--------------------");
var mensagemSplit = "vamos, dividir, esta mensagem, com base, na vírgula";
Console.WriteLine("Mensagem base: " + mensagemSplit);
Console.WriteLine("Resultado:");
string[] _split = mensagemSplit.Split(",");
for (int i = 0; i < _split.Length; i++)
{
    Console.WriteLine($"{_split[i]}");
}

Console.WriteLine("");
Console.WriteLine("Método Join");
Console.WriteLine("--------------------");
var textoJoin = "Manipulando";
var complementoJoin = "strings com C#";
Console.WriteLine("Mensagem base: " + textoJoin + " + " + complementoJoin);
var resultadoJoin = String.Join(" ", new String[] { textoJoin, complementoJoin });
Console.WriteLine("Resultado = " + resultado);

Console.WriteLine("");
Console.WriteLine("Método Replace");
Console.WriteLine("--------------------");
string frase = @"Exelentíssimo _nomeasubstituir_, estamos a sua espera!";
string substituir = "Bill Gates";
Console.WriteLine("Mensagem base: " + frase + " - " + substituir);
Console.WriteLine("Resultado - " + frase.Replace("_nomeasubstituir_", substituir));

Console.WriteLine("");
Console.WriteLine("Método Substring");
Console.WriteLine("--------------------");
string chave = "Os primeiros 12 caracteres dessa frase serão considerados";
Console.WriteLine("Mensagem base: " + chave);
Console.WriteLine("Resultado - " + chave.Substring(0, 12));

Console.WriteLine("");
Console.WriteLine("Método Equals");
Console.WriteLine("--------------------");
string palavra1 = "Palavra";
string palavra2 = "Palavra";
Console.WriteLine("Mensagem base: " + palavra1 + " - " + palavra2);
Console.WriteLine($"Resultado: " + (palavra1.Equals(palavra2) ? "Verdadeiro" : "Falso"));
Console.WriteLine("OBS: validação case sensitive, ou seja 'Palavra' é diferente de 'palavra'. Exemplo:");
palavra1 = "Palavra";
palavra2 = "palavra";
Console.WriteLine("Mensagem base: " + palavra1 + " - " + palavra2);
Console.WriteLine($"Resultado: " + (palavra1.Equals(palavra2) ? "Verdadeiro" : "Falso"));

Console.WriteLine("");
Console.WriteLine("Método Insert");
Console.WriteLine("--------------------");
string textoBase = "Texto padrão []";
string textoAdicional = "Texto que será adicionado a partir da posição 14";
Console.WriteLine("Mensagem base: " + textoBase + " - " + textoAdicional);
Console.WriteLine("Resultado: " + textoBase.Insert(14, textoAdicional));

Console.WriteLine("");
Console.WriteLine("Método Trim");
Console.WriteLine("--------------------");
string textoTrim = " Texto com um espaço vazio no início e no fim ";
Console.WriteLine("Mensagem base: " + textoTrim);
Console.WriteLine("Numero de caracteres: " + textoTrim.Length);
Console.WriteLine("Mensagem formatada: " + textoTrim.Trim());
Console.WriteLine("Resultado - Numero de caracteres: " + textoTrim.Trim().Length);
Console.WriteLine("OBS: métodos derivados: TrimStart e TrimEnd - Retiram o espaço no início e no fim da string, respectivamente");


Console.WriteLine("");
Console.WriteLine("Métodos ToUpper e ToLower");
Console.WriteLine("--------------------");
string textoUpLower = "Texto Base Com Cada Primeira Letra em Maiúsculo";
Console.WriteLine("Mensagem base: " + textoUpLower);
Console.WriteLine("Resultado ToUper - " + textoUpLower.ToUpper());
Console.WriteLine("Resultado ToLower - " + textoUpLower.ToLower());

Console.WriteLine("\n\n");
