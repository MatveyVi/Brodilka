using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class GrobScript : MonoBehaviour
{
    public float DisappearingTime = 5f;

    private float alphaDelta;
    private Color spriteColor;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteColor = spriteRenderer.color;
        alphaDelta = spriteColor.a / DisappearingTime;

    }

    void Update()
    {
        spriteColor.a -= alphaDelta * Time.deltaTime;
        spriteRenderer.color = spriteColor;

        if (spriteColor.a <= 0)
            Destroy(gameObject);
    }
}
