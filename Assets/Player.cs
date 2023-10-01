using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    

    
    void Update()
    {
        
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        if (mousePos.x > 0)//limit player x coordinates
        {
            mousePos.x = 0;
        }
        GetComponent<Rigidbody2D>().MovePosition(mousePos);
    }
}
