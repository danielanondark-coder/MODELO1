public class Cofre
{
    private string dono;
    private string senha;
    private bool estaAberto;
    private int tentativas;

    // propriedade somente leitura
    public bool EstaAberto => estaAberto;

    // construtor
    public Cofre(string dono, string senha)
    {
        this.dono = dono;
        this.senha = senha;
        this.estaAberto = false;
        this.tentativas = 0;
    }

    // abrir cofre
    public string Abrir(string senhaInformada)
    {
        if (tentativas >= 3)
            return "Cofre bloqueado";

        if (senhaInformada == senha)
        {
            estaAberto = true;
            tentativas = 0;
            return "Cofre aberto";
        }
        else
        {
            tentativas++;
            return "Senha incorreta";
        }
    }

    // fechar
    public void Fechar()
    {
        estaAberto = false;
    }

    // alterar senha
    public bool AlterarSenha(string senhaAntiga, string novaSenha)
    {
        if (estaAberto && senhaAntiga == senha)
        {
            senha = novaSenha;
            return true;
        }
        return false;
    }
}