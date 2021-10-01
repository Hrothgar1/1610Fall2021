using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOne : MonoBehaviour
{
void Update()
    {
       if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponet<Renderer>().material.color = Color.red;
        }
       if (Input.GetKeyDown(KeyCodce.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().Material.color = Color.blue;
        }
                }
}
