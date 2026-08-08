using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {   
        Time.timeScale = 0.0f;
        Player p = other.gameObject.GetComponent<Player>();
        if (p == null || p.HP == 0)
            return;
        UiManager.instance.ShowNotiText($"You Win \nPoint {p.Point}");
        UiManager.instance.ShowHideRestartButton(true);
    }
}
