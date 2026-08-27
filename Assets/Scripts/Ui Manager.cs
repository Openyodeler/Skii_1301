using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour  
{
    [SerializeField] private TMP_Text notiText;
    [SerializeField] private TMP_Text ScreenText;
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

    public void ShowScreenText(string text)
    {
        ScreenText.text = text;
    }

    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ShowHideRestartButton(bool flag)
    {
        restartButton.SetActive(flag);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
