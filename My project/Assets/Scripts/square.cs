using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour, Itouch
{
    void Touch()
    {
        var SpriteRenderer = GetComponent<SpriteRenderer>();
        SpriteRenderer.color = SpriteRenderer.color ==Color.blue ? Color.white :Color.blue;
        
    }

}
