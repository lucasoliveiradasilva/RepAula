using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public Transform player;

    public void Start()
    {
        if (JSONLoader.loadedData != null) //Se tem dados de save carregados ele continua, Se n�o tem(exemplo: o jogador come�ou um novo jogo), n�o faz nada.
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