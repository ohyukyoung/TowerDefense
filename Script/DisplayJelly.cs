using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayJelly : MonoBehaviour
{   
    private GameObject Jelly;
    public GameObject Jelly1;
    public GameObject Jelly2;
    public GameObject Jelly3;
    public GameObject Jelly4;
    bool IsAppear1 = false;
    bool IsAppear2 = false;
    bool IsAppear3 = false;
    bool IsAppear4 = false;
    public void SetActivJ1()
    {
        Jelly = Jelly1;
        if (!IsAppear1)
        {
            Jelly.SetActive(true);
            IsAppear1 = true;
        }
        else
        {
            Jelly.SetActive(false);
            IsAppear1 = false;
        }
    }
    public void SetActivJ2()
    {
        Jelly = Jelly2;
        if (!IsAppear2)
        {
            Jelly.SetActive(true);
            IsAppear2 = true;
        }
        else
        {
            Jelly.SetActive(false);
            IsAppear2 = false;
        }
    }
    public void SetActivJ3()
    {
        Jelly = Jelly3;
        if (!IsAppear3)
        {
            Jelly.SetActive(true);
            IsAppear3 = true;
        }
        else
        {
            Jelly.SetActive(false);
            IsAppear3 = false;
        }
    }
    public void SetActivJ4()
    {
        Jelly = Jelly4;
        if (!IsAppear4)
        {
            Jelly.SetActive(true);
            IsAppear4 = true;
        }
        else
        {
            Jelly.SetActive(false);
            IsAppear4 = false;
        }
    }
    

    
}
