using UnityEngine;

public class SpriteAlphaAnimation : MonoBehaviour
{
    public float duration = 5f; // Total duration for the alpha animation
    public float maxAlpha = 0.7f; // Maximum alpha value

    private SpriteRenderer spriteRenderer;
    private float timer;
    private bool increasingAlpha;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        timer = 0f;
        increasingAlpha = true;
    }

    void Update()
    {
        // Increment the timer based on the elapsed time
        timer += Time.deltaTime;

        // Calculate the normalized time value
        float normalizedTime = Mathf.Clamp01(timer / duration);

        // Calculate the alpha value based on the normalized time
        float alpha = increasingAlpha ? Mathf.Lerp(0f, maxAlpha, normalizedTime) : Mathf.Lerp(maxAlpha, 0f, normalizedTime);

        // Update the sprite's color with the new alpha value
        Color spriteColor = spriteRenderer.color;
        spriteColor.a = alpha;
        spriteRenderer.color = spriteColor;

        // Check if the animation is complete
        if (timer >= duration)
        {
            timer = 0f;
            increasingAlpha = !increasingAlpha;
        }
    }
}
