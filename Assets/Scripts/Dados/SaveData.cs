[System.Serializable] //Diz pra Unity que essa classe pode ser convertida pra JSON.
public class SaveData // Não herda de MonoBehaviour, então não aparece no Inspector e não vai em nenhum objeto na cena.
{
    public float x;
    public float y;
    public float z;
    public string sceneName;
}