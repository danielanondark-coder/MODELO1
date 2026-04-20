Console.Clear();

Lampada lamp = new Lampada("Philips", "LED");

lamp.Alternar();        // liga
lamp.AjustarBrilho(80); // ajusta brilho

Console.WriteLine(lamp);