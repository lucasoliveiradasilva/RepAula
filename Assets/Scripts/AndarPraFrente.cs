using UnityEngine;

public class AndarPraFrente : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.forward * 9.5f * Time.deltaTime;
    }
}
