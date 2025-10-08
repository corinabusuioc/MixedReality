using UnityEngine;
using Vuforia;

public class DistanceController : MonoBehaviour
{
    public GameObject imageTargetA;
    public GameObject imageTargetB;
    public Animator characterAnimator; 
    private bool isClose = false;
    public float activationDistance = 0.2f; 

    void Update()
    {
        
        if (imageTargetA.activeInHierarchy && imageTargetB.activeInHierarchy)
        {
            float dist = Vector3.Distance(imageTargetA.transform.position, imageTargetB.transform.position);

          
            Debug.Log("Distanta intre targeturi: " + dist.ToString("F3") + " m"  + "isClose ="+ isClose);
            
         
            if (dist < activationDistance)
            {
                characterAnimator.SetBool("isClose", true);
                isClose = true;
            }
            else
            {
                characterAnimator.SetBool("isClose", false);
                isClose = false;
            }
        }
        else
        {
          
            characterAnimator.SetBool("isClose", false);
        }
    }
}
