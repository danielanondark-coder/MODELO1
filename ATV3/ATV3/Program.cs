Console.Clear();

Cofre cofre = new Cofre("Daniel", "1234");

Console.WriteLine(cofre.Abrir("1111")); // erro
Console.WriteLine(cofre.Abrir("1234")); // abre

cofre.Fechar();

Console.WriteLine(cofre.Abrir("1234")); // abre de novo