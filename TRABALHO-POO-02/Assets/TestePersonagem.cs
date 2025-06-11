using UnityEngine;

public class TestePersonagem : MonoBehaviour
{ 
    Samurai samurai = new Samurai();


    void Start()
    {
        samurai.AtribuirNome("Samurai X"); 
        samurai.AtribuirEnergia(10);
        samurai.AtribuirVelocidadeDeCorte(5);
        samurai.AtribuirNumeroDeKatana(1);
        samurai.AtribuirVelocidade(5);
        samurai.AtribuitNumero_de_pes(2);
        samurai.AtribuitNumero_de_maos(2);
    }
  


}
