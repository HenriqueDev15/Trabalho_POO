using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    public Ninja ninja1;
    public Ninja ninja2;

    void Start()
    {
        ninja1 = gameObject.AddComponent<Ninja>();
        ninja1.SetNome("Tanjiro");
        ninja1.SetVida(200);
        ninja1.SetAtaque(75);
        ninja1.SetDefesa(50);
        ninja1.quantidadeDeShurikens = 5;
        ninja1.numeroDeClones = 3;

        ninja2 = gameObject.AddComponent<Ninja>();
        ninja2.SetNome("Ran");
        ninja2.SetVida(150);
        ninja2.SetAtaque(70);
        ninja2.SetDefesa(60);
        ninja2.quantidadeDeShurikens = 7;
        ninja2.numeroDeClones = 2;

        
        Debug.Log("Personagem 1: " + ninja1.GetNome());
        Debug.Log("Vida: " + ninja1.GetVida());
        Debug.Log("Ataque: " + ninja1.GetAtaque());
        Debug.Log("Defesa: " + ninja1.GetDefesa());
        Debug.Log("Shurikens: " + ninja1.quantidadeDeShurikens);
        Debug.Log("Clones: " + ninja1.numeroDeClones);

        Debug.Log("Personagem 2: " + ninja2.GetNome());
        Debug.Log("Vida: " + ninja2.GetVida());
        Debug.Log("Ataque: " + ninja2.GetAtaque());
        Debug.Log("Defesa: " + ninja2.GetDefesa());
        Debug.Log("Shurikens: " + ninja2.quantidadeDeShurikens);
        Debug.Log("Clones: " + ninja2.numeroDeClones);
        
        Debug.Log(ninja1.CompararComOutro(ninja2));
        
        ninja1.UsarHabilidadeEspecial();
        ninja2.UsarHabilidadeEspecial();
    }
}