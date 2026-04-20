Console.Clear();

Conta conta = new Conta(123, "Daniel");

conta.Depositar(200);
conta.Sacar(600);

Console.WriteLine(conta);
Console.WriteLine("Status: " + conta.StatusConta);