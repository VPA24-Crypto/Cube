using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickCube : MonoBehaviour
{
    private Color bafColor = Color.blue;
    private Color hovColor = Color.white;
    private Renderer render;

    void Start()
    {
        render = GetComponent<Renderer>();
        //render.material.color = hovColor;
    }
    void OnMouseDown()
    {
       if(render.material.color != bafColor)
        {
            render.material.color = bafColor;
        }
       else
        {
            render.material.color = hovColor;
        }
    }



}
