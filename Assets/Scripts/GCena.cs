using UnityEngine;
using UnityEngine.SceneManagement;

public class GCena : MonoBehaviour
{
    public string nomeCena;
    public static int pontos = 5;

    public void MudarCena()
    {
        //SceneManager.LoadScene(1);
        //SceneManager.LoadScene("Em jogo");
        SceneManager.LoadScene(nomeCena); 
    }
    public void Sair()
    {
        Application.Quit(); 
    }
    public void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
