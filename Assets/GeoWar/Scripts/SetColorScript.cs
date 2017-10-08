using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColorScript : MonoBehaviour
{
    [Tooltip("The sprite to color.")]
    [SerializeField]
    private SpriteRenderer mySprite;

    private void SetColor(Color color)
    {
        mySprite.color = color;
    }
}
