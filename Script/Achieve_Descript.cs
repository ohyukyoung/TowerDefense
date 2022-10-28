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
        Descript.text = "������� ����: Round1 ����";
        ShowDescript();
    }
    public void ClickLock2()
    {
        Descript.text = "������� ����: Round2 ����";
        ShowDescript();
    }
    public void ClickLock3()
    {
        Descript.text = "������� ����: Round3 ����";
        ShowDescript();
    }

    public void ClickLock4()
    {
        Descript.text = "������� ����: �������� 2300�̻�";
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
