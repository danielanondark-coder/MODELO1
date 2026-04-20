Console.Clear();

Personagem p = new Personagem("Heroi", "Guerreiro");

p.ReceberDano(50);
p.Curar(20);
p.SubirNivel();

Console.WriteLine(p);a