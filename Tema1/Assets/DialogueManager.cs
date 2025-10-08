using UnityEngine;
using TMPro;
using System.Collections;

public class DialogueManager : MonoBehaviour
{
    public GameObject pizza;           
    public float activationDistanceMes1 = 0.4f; 
    public float activationDistanceMes2 = 0.25f; 

    public string mes1 = "Hm..Something smells nice";
    public string mes2 = "NomNomNom Delicious";
    public string mes3 = "It was very good";
    public string mes4 = "I am hungry";

    public TextMeshPro text3D;

    private bool isCoroutineRunning = false;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, pizza.transform.position);

        if (distance > activationDistanceMes1)
        {
            text3D.text = mes4;
        }
        else if (distance > activationDistanceMes2)
        {
            text3D.text = mes1;
        }
        else
        {
            if (!isCoroutineRunning)
                StartCoroutine(EatSequence());
        }
    }

    IEnumerator EatSequence()
    {
        isCoroutineRunning = true;

        text3D.text = mes2;
        yield return new WaitForSeconds(2f);

        text3D.text = mes3;
        yield return new WaitForSeconds(2f);

        isCoroutineRunning = false;
    }
}
