public class Animal
{
    private string? raca;
    private double? altura;
    private double? peso;

    public string? Raca
    {
        get { return raca; }
        set 
        {
            
            if (!string.IsNullOrEmpty(value) && value.All(char.IsLetter))
            {
                raca = value; 
                return;
            }
            Console.WriteLine("Raça inválida! Contém números, espaços ou símbolos.");
        }
    }

    public double? Altura
    {
        get { return altura; }
        set
        {
            
            if (value.HasValue && value <= 0)
            {
                Console.WriteLine("Altura deve ser maior que zero.");
                return;
            }

            altura = value; 
        }
    }

    public double? Peso
    {
        get { return peso; }
        set 
        {
            if  (value.HasValue && value <= 0)
            {
                Console.WriteLine("peso deve ser maior que zero.");
                return;
            }
            peso = value;
        }
    }
    public Animal(string raca, double altura, double peso)
    {
        Raca = raca;
        Altura = altura;
        Peso = peso;
    }
    public override string ToString()
    {
        return $"Animal: {Raca} | Altura: {Altura}m | Peso: {Peso}kg";
    }
}

  