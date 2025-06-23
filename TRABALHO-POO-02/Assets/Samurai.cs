using UnityEngine;

public class Samurai : Personagem
{
     [ SerializeField ]
    private string nome;
      [ SerializeField ]
    private int energia;
       [ SerializeField ]
    private int velocidade_de_corte_veloz;
        [ SerializeField ]
    private int numero_de_katana;
         [ SerializeField ]
    private float velocidade;
          [ SerializeField ]
    private int numero_de_pes;
           [ SerializeField ]
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

    public void AtribuirVelocidadeDeCorte(int velocidade )
    {
        this.velocidade_de_corte_veloz = velocidade;
    }

    public int VelocidadeDeCorte()
    {
        return this.velocidade_de_corte_veloz;
    }

    public void AtribuirNumeroDeKatana(int numero_de_katana)
    {
        this.numero_de_katana = numero_de_katana;
    }

    public int NumeroDeKatana()
    {
        return this.numero_de_katana;
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


