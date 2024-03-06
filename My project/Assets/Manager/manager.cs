using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition)
            var obj = Physics2D.OverlapPoint(mousePosition)
            if(obj !=null){
                if(obj.gameObject.TryGetCoomponent<Itouch>(out var touch)){
                    touch.Touch();
                }
            }
        }
    }
}
