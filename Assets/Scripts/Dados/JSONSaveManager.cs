using UnityEngine;
using System.IO; // Permite ler e escrever arquivos no disco.

public class JSONSaveManager : MonoBehaviour
{
    public Transform player;
    public string sceneName;  // Nome da cena atual ou destino.

    string filePath => Application.persistentDataPath + "/saveData.json";

    public void SaveGame()
    {
        SaveData data = new SaveData(); // Cria um novo SaveData.
        data.x = player.position.x; // Preenche com os dados do player e da cena.
        data.y = player.position.y;
        data.z = player.position.z;
        data.sceneName = sceneName;

        string json = JsonUtility.ToJson(data); // Transforma tudo em JSON.
        File.WriteAllText(filePath, json); // Grava o JSON no arquivo.

        Debug.Log("Jogo salvo em: " + filePath);
    }

    public SaveData LoadGame()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            Debug.Log("Jogo carregado!");
            return data;
        }
        else
        {
            Debug.LogWarning("Nenhum save encontrado!");
            return null;
        }
    }
}