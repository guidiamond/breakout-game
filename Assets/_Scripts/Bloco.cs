using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    // public int durability   // property
    // {
    //   get { return durability; }   // get method
    //   set { durability = value; }  // set method
    // }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // durability -= 1;
        // if (durability == 0) {
             Destroy(gameObject);
        // }
    }
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }
}
