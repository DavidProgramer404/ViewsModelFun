#pragma warning disable CS8618
public class User
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public User(string nom, string ape)
    {
        Nombre = nom;
        Apellido = ape;
    }

    public User(string first)
    {
        Nombre = first;
    }
}
