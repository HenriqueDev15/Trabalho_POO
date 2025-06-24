using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string Nome;
    public int Vida;
    public int Ataque;
    public int Defesa;
    
    public string GetNome()
    {
        return this.Nome;
    }

    public void SetNome(string nome)
    {
        this.Nome = nome;
    }

    public int GetVida()
    {
        return this.Vida;
    }

    public void SetVida(int vida)
    {
        this.Vida = vida;
    }
    public int GetAtaque()
    {
        return this.Ataque;
    }

    public void SetAtaque(int ataque)
    {
        this.Ataque = ataque;
    }

    public int GetDefesa()
    {
        return this.Defesa;
    }

    public void SetDefesa(int defesa)
    {
        this.Defesa = defesa;
    }


   
    }