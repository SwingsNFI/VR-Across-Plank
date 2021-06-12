using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public static PlayerControl instance;
    public Transform[] targets;
    public GameObject[] quest;
    public float speed = 1;
    public bool isbenar = false;
    public bool lanjut = false;
    int next;
    int amountquest;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        bergerak();
    }


    void bergerak()
    {
        if (isbenar == true)
        {
            float jarak = Vector3.Distance(transform.position, targets[next].position);
            if (jarak > 0)
            {
                float jalan = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, targets[next].position, jalan);
            }
            else
            {
                isbenar = false;
                next++;
                amountquest++;
                if (quest[amountquest])
                {
                    if (amountquest < quest.Length - 1)
                    {
                        quest[amountquest].SetActive(true);
                    }
                    else
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                    }
                }
                else
                {
                    isbenar = true;
                }
            }
        }

        if(amountquest == quest.Length)
        {
            Debug.Log("hala");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Map" || collision.gameObject.name == "Water")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
