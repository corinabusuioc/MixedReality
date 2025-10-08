using UnityEngine;

public class PizzaScaler : MonoBehaviour
{
    public GameObject cactus;           
    public float activationDistance = 0.3f; 
    public float scaleSpeed = 2f;      
    public float minScale = 0.3f;      

    private Vector3 originalScale;
    public Animator characterAnimator;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        if (cactus == null) return;

        float distance = Vector3.Distance(transform.position, cactus.transform.position);
        float targetScaleFactor = 1f;

        if (distance < activationDistance)
        {
            targetScaleFactor = minScale;
            characterAnimator.SetBool("isDead", true);
        }
        else
        {
            characterAnimator.SetBool("isDead", false);
        }

       
        Vector3 targetScale = originalScale * targetScaleFactor;

        
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * scaleSpeed);
    }
}
