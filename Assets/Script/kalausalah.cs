using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kalausalah : MonoBehaviour
{
    public GameObject playerr2;
    public GameObject platform2;
    public static kalausalah habisclass;
    // Start is called before the first frame update
    void Start()
    {
        habisclass = this;
    }

    // Update is called once per frame
    void Update()
    {
        platform2.SetActive(false);
        Rigidbody rigwood = playerr2.AddComponent<Rigidbody>();
        rigwood.mass = 5;
    }
}
