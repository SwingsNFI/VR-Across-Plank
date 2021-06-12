using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ngurangichance : MonoBehaviour
{
    public static ngurangichance instance3;
    public GameObject[] Chance;
    int kurang;
    // Start is called before the first frame update
    void Start()
    {
        kurang = Chance.Length;
        instance3 = this;
    }
    public void ngurangi()
    {
        if (kurang > 0)
        {
            kurang--;
            Chance[kurang].SetActive(false);
            if(kurang <= 0)
            {
                Debug.Log("aneh");
                BenarSalah.instance2.habis = true;
                BenarSalah.instance2.salah();
            }
        }
    }
}
