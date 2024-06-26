using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comidasScript : MonoBehaviour
{
    public GameObject[] producto1;
    public GameObject[] producto2;
    int productoizquierdo;
    int productoderecho;

    // Start is called before the first frame update
    void Start()
    {

        Deactivate();
        Activate();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void Deactivate()
    {
        for (int i = 0; i < producto1.Length; i++)
        {
            producto1[i].SetActive(false);
            producto2[i].SetActive(false);
        }
    }
    void Activate()
    {
        productoizquierdo = Random.Range(0, producto1.Length);
        productoderecho = Random.Range(0, producto2.Length);
        producto1[productoizquierdo].transform.position = new Vector3(5f, 0f, 0f);
        producto2[productoderecho].transform.position = new Vector3(-9f, 0f, 0f);
        producto1[productoizquierdo].SetActive(true);
        producto1[productoderecho].SetActive(true);


    }
}

