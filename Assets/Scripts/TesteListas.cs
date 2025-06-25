using System.Collections.Generic;
using UnityEngine;

public class TesteListas : MonoBehaviour
{
    public GameObject[] bolasArray;
    public List<GameObject> bolasLista;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            SpawnDoArray();

        if (Input.GetKeyDown(KeyCode.L))
            SpawnDaLista();

        if (Input.GetKeyDown(KeyCode.P))
            AdicionarNaLista();

        if (Input.GetKeyDown(KeyCode.R))
            RemoverDaLista();
    }
    public void SpawnDoArray()
    {
        if (bolasArray.Length == 0) return;

        int i = Random.Range(0, bolasArray.Length);
        Instantiate(bolasArray[i], transform.position, Quaternion.identity);

    }

    public void SpawnDaLista()
    {
        if (bolasLista.Count == 0) return;

        int i = Random.Range(0, bolasLista.Count);
        Instantiate(bolasLista[i], transform.position, Quaternion.identity);

    }

    public void AdicionarNaLista()
    {
        if (bolasArray.Length == 0) return;

        int i = Random.Range(0, bolasArray.Length);
        bolasLista.Add(bolasArray[i]);
        Debug.Log("Adicionou na Lista: " + bolasArray[i].name);
    }

    public void RemoverDaLista()
    {
        if (bolasLista.Count == 0) return;

        int i = Random.Range(0, bolasLista.Count);
        Debug.Log("Removeu da Lista: " + bolasLista[i].name);
        bolasLista.RemoveAt(i);
    }
}