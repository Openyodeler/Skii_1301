using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {   
        Time.timeScale = 0.0f;
        Player p = other.gameObject.GetComponent<Player>();
        if (p == null || p.HP == 0)
            return;
        UiManager.instance.ShowNotiText($" ");
        UiManager.instance.ShowHideRestartButton(true);
        UiManager.instance.ShowScreenText($"You Win \nPoint {p.Point}");
    }
}
