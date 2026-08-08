using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UiManager : MonoBehaviour  
{
    [SerializeField] private TMP_Text notiText;
    public static UiManager instance;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private Player player;

    private void Awake()
    {
        instance = this;
    }

    public void ShowNotiText(string text)
    {
        notiText.text = text;
    }

    public void Restart()
    {
        player.HP = 100;
        player.transform.position = new Vector3(0,87,-85);
        player.Resetforce();
        Time.timeScale = 1.0f;
        ShowNotiText("Restart");
        ShowHideRestartButton(false);
    }

    public void ShowHideRestartButton(bool flag)
    {
        restartButton.SetActive(flag);
    }
}
