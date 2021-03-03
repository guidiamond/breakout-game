using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Menu_Principal : MonoBehaviour
{
    GameManager gm;

    private void OnEnable()
    {
        gm = GameManager.GetInstance();
    }

    public void Comecar()
    {
        gm.isUnPause = false;
        gm.ChangeState(GameManager.GameState.GAME);
    }
}
