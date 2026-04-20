public class Personagem
{
    private string nome;
    private string classe;
    private int nivel;
    private double vidaAtual;
    private double vidaMaxima;

    // construtor
    public Personagem(string nome, string classe)
    {
        this.nome = nome;
        this.classe = classe;
        this.nivel = 1;

        if (classe == "Guerreiro")
            vidaMaxima = 150;
        else
            vidaMaxima = 80;

        vidaAtual = vidaMaxima;
    }

    // receber dano
    public void ReceberDano(double dano)
    {
        if (vidaAtual > 0)
        {
            vidaAtual -= dano;

            if (vidaAtual < 0)
                vidaAtual = 0;
        }
    }

    // curar
    public void Curar(double valor)
    {
        if (vidaAtual > 0)
        {
            vidaAtual += valor;

            if (vidaAtual > vidaMaxima)
                vidaAtual = vidaMaxima;
        }
    }

    // subir nível
    public void SubirNivel()
    {
        if (vidaAtual == 0)
            return; // morto não sobe nível

        nivel++;
        vidaMaxima *= 1.1; // aumenta 10%
        vidaAtual = vidaMaxima;
    }

    // exibir
    public override string ToString()
    {
        return $"{nome} ({classe}) - Lvl {nivel} - HP: {vidaAtual}/{vidaMaxima}";
    }
}