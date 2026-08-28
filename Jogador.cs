public class Jogador
{
    private string? nome;
    private double? altura;
    private string? time;
    public string Nome
    {
        get {return nome;}
        set {if (nome.All(char.IsLetter))
                {
                   value = nome;
                   return;
                }
              
            Console.WriteLine("nome inválido! Contém números, espaços ou símbolos.");
                
        }
    }
    public double Altura
    {
        get{return altura;}
        set
        {
            if (altura <= 0)
            {
                Console.WriteLine("altura negativa");
                return;
            }
            if (altura.All(char.IsDigit))
            {
                value = altura;
                return;
            }
            Console.WriteLine("altura inválida");
        }
    }
    public string Time
    {
        get{return time;}
        set {if (time.All(char.IsLetter))
                {
                   value = time;
                   return;
                }
              
            Console.WriteLine("nome inválido! Contém números, espaços ou símbolos.");
    }
}