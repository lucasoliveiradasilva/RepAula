using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class JSONLoader : MonoBehaviour
{
    public static SaveData loadedData;

    public void LoadSavedScene()
    {
        string filePath = Application.persistentDataPath + "/saveData.json"; // Define o caminho onde o arquivo JSON t� salvo.

        if (File.Exists(filePath)) // Verifica se o arquivo existe no disco.
        {
            string json = File.ReadAllText(filePath); // L� o conte�do do arquivo.
            loadedData = JsonUtility.FromJson<SaveData>(json); // Converte o texto JSON de volta pra um objeto SaveData, com as informa��es do save.
            SceneManager.LoadScene(loadedData.sceneName);
        }
        else
        {
            Debug.LogWarning("Nenhum save encontrado!");
        }
    }
}