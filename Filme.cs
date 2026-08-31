

public class Filme
{
    private string? nome;
    private double? duracao;
    private string? diretor;

    public string? Nome
    {
        get { return nome; }
        set 
        {
            
            if (!string.IsNullOrEmpty(value) && value.All(char.IsLetter))
            {
                nome = value; 
                return;
            }
            Console.WriteLine("Nome inválido! Contém números, espaços ou símbolos.");
        }
    }

    public double? Duracao
    {
        get { return duracao; }
        set
        {
            
            if (value.HasValue && value <= 0)
            {
                Console.WriteLine("Duração inválida, deve ser maior que 0");
                return;
            }

            duracao = value; 
        }
    }

    public string? Diretor
    {
        get { return diretor; }
        set 
        {
            if (!string.IsNullOrEmpty(value) && value.All(char.IsLetter))
            {
                diretor = value;
                return;
            }
            Console.WriteLine("diretor inválido! Contém números, espaços ou símbolos.");
        }
    }
    public Filme(string nome, double duracao, string diretor)
    {
        Nome = nome;
        Duracao = duracao;
        Diretor = diretor;
    }
    public override string ToString()
    {
        return $"Filme: {Nome} | Duração: {Duracao} min | Diretor: {Diretor}";
    }
}