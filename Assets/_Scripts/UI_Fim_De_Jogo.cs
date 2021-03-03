using UnityEngine;
using UnityEngine.UI;

public class UI_Fim_De_Jogo : MonoBehaviour
{
    public Text message;

    GameManager gm;
    private void OnEnable()
    {
        gm = GameManager.GetInstance();

        if (gm.vidas > 0 && gm.timeToLose > 0)
        {
            message.text = "Você Ganhou!!!";
        }
        else
        {
            message.text = "Você Perdeu!!";
        }
    }

    public void Voltar()
    {
        gm.isUnPause = false;
        gm.ChangeState(GameManager.GameState.MENU);
    }
}