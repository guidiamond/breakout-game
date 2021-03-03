using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    public int Durability { get; set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Durability -= 1;
        if (Durability <= 0) {
           Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Durability = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
