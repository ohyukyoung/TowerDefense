using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Achieve_Descript : MonoBehaviour
{ 
    private bool IsLocated=false;
    public GameObject DescriptPanel;
    public Text Descript;
    public void ClickLock1()
    {
        Descript.text = "잠금해제 조건: Round1 돌파";
        ShowDescript();
    }
    public void ClickLock2()
    {
        Descript.text = "잠금해제 조건: Round2 돌파";
        ShowDescript();
    }
    public void ClickLock3()
    {
        Descript.text = "잠금해제 조건: Round3 돌파";
        ShowDescript();
    }

    public void ClickLock4()
    {
        Descript.text = "잠금해제 조건: 보유코인 2300이상";
        ShowDescript();
    }
    void ShowDescript()
    {
        if (!IsLocated)
        {
            DescriptPanel.SetActive(true);
            Invoke("SetFalse", 4.0f);
            IsLocated = false;
        }
    }
    void SetFalse()
    {
        DescriptPanel.SetActive(false);
    }
    
}
