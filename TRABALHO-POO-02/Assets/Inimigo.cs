public class Inimigo : Personagem
{
    public string nome;
    public int energia;
    public int poder;

    public Inimigo(string nome, int energia, int poder)
    {
        this.nome = nome;
        this.energia = energia;
        this.poder = poder;
    }

    public string Nome() => nome;
    public int Energia() => energia;
    public int Poder() => poder;
}