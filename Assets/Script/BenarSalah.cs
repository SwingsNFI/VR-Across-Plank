using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenarSalah : MonoBehaviour
{
    public static BenarSalah instance2;
    GameObject platform;
    GameObject playerr;
    public bool habis = false;
    // Start is called before the first frame update
    void Start()
    {
        instance2 = this;
        platform = GameObject.Find("WoodPlank");
        playerr = GameObject.Find("Player");
    }

    public void benar()
    {
        habis = false;
        gameObject.SetActive(false);
        PlayerControl.instance.isbenar = true;
    }

    public void salah()
    {
        Handheld.Vibrate();
        if (habis == true)
        {
            Debug.Log("seharusnyabisa");
            platform.SetActive(false);
            playerr.GetComponent<Rigidbody>().useGravity = true;
        }
        else
        {
            ngurangichance.instance3.ngurangi();
        }
    }
}