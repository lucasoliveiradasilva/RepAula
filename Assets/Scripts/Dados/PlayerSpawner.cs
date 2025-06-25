using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public Transform player;

    public void Start()
    {
        if (JSONLoader.loadedData != null) //Se tem dados de save carregados ele continua, Se não tem(exemplo: o jogador começou um novo jogo), não faz nada.
        {
            Vector3 pos = new Vector3(
                JSONLoader.loadedData.x,
                JSONLoader.loadedData.y,
                JSONLoader.loadedData.z
            );

            player.position = pos;
        }
    }
}