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
            Debug.LogWarning("Atenção: Vida do jogador está abaixo de 50!");
        }
        if (inimigo == null)
        {
            Debug.LogError("Erro: Inimigo não encontrado na cena!");
        }
        else
        {
            Debug.Log("Inimigo encontrado com sucesso.");
        }

    }
}