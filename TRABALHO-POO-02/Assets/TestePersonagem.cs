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


        Inimigo inimigo = new Inimigo("Oni Guerreiro", 90, 70);

        
        Debug.Log("== STATUS DO SAMURAI ==");
        Debug.Log("Nome: " + samurai.Nome());
        Debug.Log("Energia: " + samurai.Energia());
        Debug.Log("Velocidade de Corte: " + samurai.VelocidadeDeCorte());

        Debug.Log("== STATUS DO INIMIGO ==");
        Debug.Log("Nome: " + inimigo.Nome());
        Debug.Log("Energia: " + inimigo.Energia());
        Debug.Log("Poder: " + inimigo.Poder());

        
        Debug.Log("== COMBATE ==");
        if (samurai.VelocidadeDeCorte() > inimigo.Poder())
        {
            Debug.Log(samurai.Nome() + " venceu o combate com um corte veloz!");
        }
        else if (samurai.VelocidadeDeCorte() < inimigo.Poder())
        {
            Debug.Log(inimigo.Nome() + " venceu o combate com força bruta!");
        }
        else
        {
            Debug.Log("O combate terminou empatado!");
        }
    }
}



    

        
    

        
    
  

