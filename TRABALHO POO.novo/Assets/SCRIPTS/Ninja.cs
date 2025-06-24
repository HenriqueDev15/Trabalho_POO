using UnityEngine;

public class Ninja : Personagem
{
    public int Shurikens;
    public int Clones;
    public string habilidadeEspecial = "Clone das Sombras";

    public void UsarHabilidadeEspecial()
    {
        Debug.Log($"{Nome} usou sua habilidade especial: {habilidadeEspecial}!");
    }
}
