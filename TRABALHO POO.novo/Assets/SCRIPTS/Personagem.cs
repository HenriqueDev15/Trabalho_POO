using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome;
    public int vida;
    public int ataque;
    public int defesa;
    
    public string GetNome() => nome;
    public void SetNome(string novoNome) => nome = novoNome;

    public int GetVida() => vida;
    public void SetVida(int novaVida) => vida = novaVida;

    public int GetAtaque() => ataque;
    public void SetAtaque(int novoAtaque) => ataque = novoAtaque;

    public int GetDefesa() => defesa;
    public void SetDefesa(int novaDefesa) => defesa = novaDefesa;
    
    public string CompararComOutro(Personagem outro)
    {
        if (this.ataque > outro.ataque)
            return $"{nome} é mais forte que {outro.nome} em ataque.";
        else if (this.ataque < outro.ataque)
            return $"{outro.nome} é mais forte que {nome} em ataque.";
        else
            return $"{nome} e {outro.nome} têm o mesmo nível de ataque.";
    }
}