class Program
{
    static void Main(string[] args)
    {
        Person person = new Person { Nome = "Lidiia",  Sobrenome = "Araujo", Idade = 37};
        Console.WriteLine("Nome {0}\n\rSobrenome {1}\n\rIdade {2}", person.Nome, person.Sobrenome, person.Idade);
    }
}
class Person 
{ 
  public string Nome { get; set; }
  public string Sobrenome { get; set; }
  public byte Idade { get; set; }
}