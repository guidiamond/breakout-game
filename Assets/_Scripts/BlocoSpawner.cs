using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlocoSpawner : MonoBehaviour
{
    public GameObject Bloco;
    GameManager gm;
    private float msTimer; // counts in ms

    void Start()
    {
        msTimer = 0.0f;
        gm = GameManager.GetInstance();
        GameManager.changeStateDelegate += Construir;
        Construir();
    }

    void Construir()
    {
        if (gm.isUnPause == false) 
        {
            if (gm.gameState == GameManager.GameState.GAME)
            {
                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                }
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                    Color currColor = Color.yellow;
                    if (j % 2 == 0) {
                        currColor = Color.green;
                    }
                    else if (j % 3 == 0) {
                         currColor = Color.magenta;
                    }
                        Vector3 posicao = new Vector3(-9 + 1.55f * i, 4 - 0.55f * j);

                        GameObject t = Instantiate(Bloco, posicao, Quaternion.identity, transform) as GameObject;
                        Renderer rend = t.GetComponent<Renderer>();
                        rend.material.color = currColor;
                    }
                }
            }
        }
    }

    void Update()
    {
        if (gm.gameState == GameManager.GameState.GAME) { 
            if (transform.childCount <= 0 || gm.timeToLose <= 0) {
                gm.ChangeState(GameManager.GameState.ENDGAME);
            }
            msTimer += Time.deltaTime;
            gm.timer = (int)(msTimer % 60); // counts in secs
            gm.timeToLose = 120 - gm.timer;
        }
        if (gm.gameState == GameManager.GameState.MENU || gm.gameState == GameManager.GameState.ENDGAME) {
            msTimer = 0;
        }
       
    }

}