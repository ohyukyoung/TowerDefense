using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableLock : MonoBehaviour
{
    private GameObject LockButton;
    public GameObject LockButton1;
    public GameObject LockButton2;
    public GameObject LockButton3;
    public GameObject LockButton4;
    private void Start()
    {
        if (Variables.Mission1Complete)
            DeleteLock1();
        if (Variables.Mission2Complete)
            DeleteLock2();
        if (Variables.Mission3Complete)
            DeleteLock3();
        if (Variables.Mission4Complete)
            DeleteLock4();
    }
    public void DeleteLock1()
    {
        LockButton = LockButton1;
        DeleteLock();
    }
    public void DeleteLock2()
    {
        LockButton = LockButton2;
        DeleteLock();
    }
    public void DeleteLock3()
    {

        LockButton = LockButton3;
        DeleteLock();
    }
    public void DeleteLock4()
    {
        LockButton = LockButton4;
        DeleteLock();
    }
    void DeleteLock()
    {
        LockButton.SetActive(false);
    }
}
