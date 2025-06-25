using UnityEngine;

public class TesteDeDebug : MonoBehaviour
{
    public int vida = 100;
    public GameObject inimigo;

    void Start()
    {
        Debug.Log("Iniciando sistema de debug...");

        inimigo = GameObject.Find("Inimigo");

        if (vida < 50)
        {
            Debug.LogWarning("Aten��o: Vida do jogador est� abaixo de 50!");
        }
        if (inimigo == null)
        {
            Debug.LogError("Erro: Inimigo n�o encontrado na cena!");
        }
        else
        {
            Debug.Log("Inimigo encontrado com sucesso.");
        }

    }
}