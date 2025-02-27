using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitVfx : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color hitColor = Color.red;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        spriteRenderer.color = hitColor;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        spriteRenderer.color = Color.white;
    }
}
