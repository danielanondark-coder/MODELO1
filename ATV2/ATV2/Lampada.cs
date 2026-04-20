public class Lampada
{
    private string marca;
    private readonly string tecnologia;
    private bool ligada;
    private int brilho;

    // Construtor
    public Lampada(string marca, string tecnologia)
    {
        this.marca = marca;
        this.tecnologia = tecnologia;
        this.ligada = false;
        this.brilho = 100;
    }

    // Liga / Desliga
    public void Alternar()
    {
        ligada = !ligada;
    }

    // Ajusta brilho (só se estiver ligada)
    public void AjustarBrilho(int novoBrilho)
    {
        if (!ligada)
        {
            Console.WriteLine("A lâmpada está desligada!");
            return;
        }

        if (novoBrilho >= 0 && novoBrilho <= 100)
        {
            brilho = novoBrilho;
        }
        else
        {
            Console.WriteLine("Brilho inválido (0 a 100)");
        }
    }

    // Exibir dados
    public override string ToString()
    {
        return $"Marca: {marca} | Tecnologia: {tecnologia} | Ligada: {ligada} | Brilho: {brilho}";
    }
}