using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    public Ninja ninja1 = new Ninja();
    public Ninja ninja2 = new Ninja();

    void Start()
    {
        ninja1.SetNome("kokimoto");
        ninja1.SetVida(200);
        ninja1.SetAtaque(75);
        ninja1.SetDefesa(69);
        Debug.Log(ninja1.GetNome() + " tem " + ninja1.GetVida() + " de vida " + ninja1.GetDefesa() + " de defesa " + ninja1.GetAtaque() + " de ataque. "); ;
        
        ninja2.SetNome("Ran");
        ninja2.SetVida(150);
        ninja2.SetAtaque(50);
        ninja2.SetDefesa(57);


        ninja2.UsarHabilidadeEspecial();
        
        
        
            if (ninja1.GetAtaque() > ninja2.GetAtaque())
            { 
                Debug.Log(" é mais forte que " + ninja2.GetNome());
            }
            if (ninja1.GetAtaque() < ninja2.GetAtaque())
            {
                Debug.Log(ninja2.GetNome() + " é mais forte que " + ninja1.GetNome());
            }
            if (ninja1.GetAtaque() == ninja2.GetAtaque())
            {
                Debug.Log(ninja1.GetNome() + " e " + ninja2.GetNome() + " têm a mesma força");
            }
    }
}