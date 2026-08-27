using UnityEngine;

public class OutofBound : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player == null) { return; }

        player.HP -= 100;

        if (player.HP <= 0)
        {
            player.HP = 0;
            UiManager.instance.ShowNotiText($" ");
            UiManager.instance.ShowHideRestartButton(true);
            UiManager.instance.ShowScreenText("Game Over");
            Time.timeScale = 0;
        }
    }
}
