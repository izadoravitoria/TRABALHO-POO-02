using Unity.VisualScripting;
using UnityEngine;
// Generico
public class Personagem : MonoBehaviour
{
    private string nome;
    private int energia = 5;
    private float velocidade;
    private int numero_de_pes;
    private int numero_de_maos;
    
    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }

    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public int Energia()
    {
        return this.energia;
    }

    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }

    public void AtribuitNumero_de_pes(int numero_de_pes)
    {
        this.numero_de_pes = numero_de_pes;
    }

    public int Numero_de_pes()
    {
        return this.numero_de_pes;
    }

    public void AtribuitNumero_de_maos(int numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos;
    }

    public int Numero_de_maos()
    {
        return this.numero_de_maos;
    }
}
