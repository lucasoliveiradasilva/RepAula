using System.Collections;
using UnityEngine;

public class Temporizadores : MonoBehaviour
{
    public GameObject prefab;
    public bool podeSpawnar;
    public float tempo;

    public void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.K) && podeSpawnar) // Timer Coroutine : Relativamente mais pesado, pode ser interrompido, � tem uso simples.
        {
            StartCoroutine(Timer(5f)); 
        }

        if (Input.GetKeyDown(KeyCode.J) && podeSpawnar) // Timer Invoke : Relativamente mais leve que com o Coroutine, n�o pode ser interrompido ou controlado, � tem uso muito simples.
        {
            podeSpawnar = false;
            Instantiate(prefab, transform.position, Quaternion.identity);
            Invoke("Timer2", 2f);
        }

        if (!podeSpawnar) // Timer L�gico : Bem mais leve, pode ser controlado completamente, � muito mais complexo.
        {
            tempo += Time.deltaTime;

            if (tempo >= 2f)
            {
                podeSpawnar = true;
                tempo = 0f;
            }
        }
        if (Input.GetKeyDown(KeyCode.L) && podeSpawnar)
        {
            podeSpawnar = false;
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
    public IEnumerator Timer(float segundos)
    {
        podeSpawnar = false;
        yield return new WaitForSeconds(segundos);
        Instantiate(prefab, transform.position, Quaternion.identity);
        podeSpawnar = true;
    }
    public void Timer2()
    {
        podeSpawnar = true;
    }
}