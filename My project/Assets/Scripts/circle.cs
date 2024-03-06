using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour, Itouch
{
    public void Touch(){
        var renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer color = Color.blue;
    }
}
