public class Conta
{
    private readonly int numero;
    private string titular;
    private double saldo;
    private double limite;

    // propriedades calculadas
    public double SaldoTotal => saldo + limite;
    public string StatusConta => saldo < 0 ? "Negativo" : "Positivo";

    // construtor
    public Conta(int numero, string titular)
    {
        this.numero = numero;
        this.titular = titular;
        this.saldo = 0;
        this.limite = 500;
    }

    // depósito
    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

    // saque
    public bool Sacar(double valor)
    {
        if (valor <= SaldoTotal)
        {
            saldo -= valor;
            return true;
        }
        return false;
    }

    // exibir dados
    public override string ToString()
    {
        return $"Conta: {numero} | Titular: {titular} | Saldo: {saldo} | Limite: {limite}";
    }
}