using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoShowHide : MonoBehaviour
{
    public GameObject inginhilang;
    public GameObject inginmuncul;
    private void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    
    public void hilang()
    {
        inginhilang.SetActive(false);
        inginmuncul.SetActive(true);
    }
}
