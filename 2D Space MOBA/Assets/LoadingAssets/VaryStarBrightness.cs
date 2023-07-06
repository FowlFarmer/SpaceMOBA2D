using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class VaryStarBrightness : MonoBehaviour
{
    public float increaseSpeed = 0.5f;  // Speed of alpha increase
    public float decreaseSpeed = 0.2f;  // Speed of alpha decrease
    public float targetAlpha1 = 0.5f;   // Target alpha value for the first phase
    public float targetAlpha2 = 0.04f;  // Target alpha value for the second phase
    public float waitTime1 = 3f;        // Time to wait after reaching targetAlpha1
    public float waitTime2 = 6f;        // Time to wait after reaching targetAlpha2
    public Image targetImage;           // Reference to the UI Image component

    private bool increasing = true;     // Flag to indicate if alpha is currently increasing

    private void Start()
    {
        StartCoroutine(AnimateAlpha());
    }

    private IEnumerator AnimateAlpha()
    {
        while (true)
        {
            // Phase 1: Exponentially increase alpha until targetAlpha1 is reached
            while (targetImage.color.a < targetAlpha1)
            {
                float currentAlpha = targetImage.color.a;
                float newAlpha = currentAlpha + (increaseSpeed * (1 - currentAlpha));
                targetImage.color = new Color(targetImage.color.r, targetImage.color.g, targetImage.color.b, newAlpha);
                yield return null;
            }

            // Wait for the specified time
            yield return new WaitForSeconds(waitTime1);

            // Phase 2: Exponentially decrease alpha until targetAlpha2 is reached
            while (targetImage.color.a > targetAlpha2)
            {
                float currentAlpha = targetImage.color.a;
                float newAlpha = currentAlpha - (decreaseSpeed * currentAlpha);
                targetImage.color = new Color(targetImage.color.r, targetImage.color.g, targetImage.color.b, newAlpha);
                yield return null;
            }

            // Wait for the specified time
            yield return new WaitForSeconds(waitTime2);
        }
    }
}
