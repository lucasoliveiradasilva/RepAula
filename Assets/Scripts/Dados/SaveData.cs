[System.Serializable] //Diz pra Unity que essa classe pode ser convertida pra JSON.
public class SaveData // N�o herda de MonoBehaviour, ent�o n�o aparece no Inspector e n�o vai em nenhum objeto na cena.
{
    public float x;
    public float y;
    public float z;
    public string sceneName;
}