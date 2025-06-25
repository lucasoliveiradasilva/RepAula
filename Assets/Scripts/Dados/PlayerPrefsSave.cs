using UnityEngine;

public class PlayerPrefsSave : MonoBehaviour
{
    public Transform player;

    public void SavePosition()
    {
        PlayerPrefs.SetFloat("PlayerX", player.position.x);
        PlayerPrefs.SetFloat("PlayerY", player.position.y);
        PlayerPrefs.SetFloat("PlayerZ", player.position.z);
        PlayerPrefs.Save();
        Debug.Log("Posição salva!");
    }

    public void LoadPosition()
    {
        float x = PlayerPrefs.GetFloat("PlayerX", 0);
        float y = PlayerPrefs.GetFloat("PlayerY", 0);
        float z = PlayerPrefs.GetFloat("PlayerZ", 0);

        player.position = new Vector3(x, y, z);
        Debug.Log("Posição carregada!");
    }
}
