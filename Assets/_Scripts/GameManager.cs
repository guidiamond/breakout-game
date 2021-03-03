using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager
{
    private static GameManager _instance;
    public enum GameState { MENU, GAME, PAUSE, ENDGAME };

    public GameState gameState { get; private set; }
    public int vidas;
    public int pontos;

    // Used on BlocoSpawner.Construir and GameManager.ChangeState so if the game is unpaused it doesn't reset the scores
    public bool isUnPause = false; 

    public delegate void ChangeStateDelegate();
    public static ChangeStateDelegate changeStateDelegate;
    
    private void Reset()
    {
        vidas = 3;
        pontos = 0;
    }

    public void ChangeState(GameState nextState)
    {
        if (nextState == GameState.GAME && isUnPause == false) {
            Reset();
        }
        gameState = nextState;
        changeStateDelegate();
    }

    private GameManager()
    {
        vidas = 3;
        pontos = 0;
        gameState = GameState.MENU;
    }

    public static GameManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameManager();
        }

        return _instance;
    }
}