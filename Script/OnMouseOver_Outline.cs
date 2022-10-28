using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseOver_Outline : MonoBehaviour
{
    private void OnMouseOver()
    {
        {
            GetComponent<Outline>().enabled = true;
        }
    }

    private void OnMouseExit()
    {
        GetComponent<Outline>().enabled = false;
    }
}
