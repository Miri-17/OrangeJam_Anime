using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFade : MonoBehaviour
{
    [SerializeField]
    private float fadeDuration = 1.0f;
    [SerializeField]
    private bool isFadeIn = false;

    private SpriteRenderer fadeSprite = null;
    private bool isCompleted = false;
    private float red;
    private float green;
    private float blue;
    private float currentAlpha;
    private float fadeSpeed;

    private void Start()
    {
        fadeSprite = GetComponent<SpriteRenderer>();
        red = fadeSprite.color.r;
        green = fadeSprite.color.g;
        blue = fadeSprite.color.b;
        currentAlpha = fadeSprite.color.a;

        fadeSpeed = 1.0f / fadeDuration;
    }

    private void Update()
    {
        if (isCompleted)
        {
            return;
        }

        if (isFadeIn)
        {
            if (currentAlpha < 1.0f)
            {
                currentAlpha += fadeSpeed * Time.deltaTime;
                if (currentAlpha >= 1.0f)
                {
                    isCompleted = true;
                    currentAlpha = 1.0f;
                }
            }
        }
        else
        {
            if (currentAlpha > 0.0f)
            {
                currentAlpha -= fadeSpeed * Time.deltaTime;
                if (currentAlpha <= 0.0f)
                {
                    isCompleted = true;
                    currentAlpha = 0.0f;
                }
            }
        }
        fadeSprite.color = new Color(red, green, blue, currentAlpha);
    }
}
