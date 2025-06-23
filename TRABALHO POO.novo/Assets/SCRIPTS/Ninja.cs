using UnityEngine;

public class Ninja : Personagem
{
    public int quantidadeDeShurikens;
    public int numeroDeClones;
    public string habilidadeEspecial = "Clone das Sombras";

    public void UsarHabilidadeEspecial()
    {
        Debug.Log($"{nome} usou sua habilidade especial: {habilidadeEspecial}!");
    }
}
