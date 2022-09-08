
using ProjetoLivro;

var P = new Pessoa[2];
var L = new Livro[3];


P[0] = new Pessoa("Paulo", 33, "M");
P[1] = new Pessoa("Maria", 51, "F");

L[0] = new Livro("Aprendendo C#", "Guanabara", 300, P[0]);
L[1] = new Livro("POO para iniciantes", "Guanabara", 200, P[1]);
L[2] = new Livro("C# Avançado", "Maria Candido", 500, P[0]);

L[0].Abrir();
L[0].Folhear(100);

Console.WriteLine(L[0].Detalhes());
Console.WriteLine(L[1].Detalhes());


