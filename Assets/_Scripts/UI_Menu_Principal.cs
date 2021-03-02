using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Menu_Principal : MonoBehaviour
{
    GameManager gm;

    private void OnEnable()
    {
        gm = GameManager.GetInstance();
    }

    public void Comecar()
    {
        Debug.Log("Carai");
        gm.ChangeState(GameManager.GameState.GAME);
    }
}
