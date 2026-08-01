using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UiManager : MonoBehaviour  
{
    [SerializeField] private TMP_Text notiText;
    public static UiManager instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowNotiText(string text)
    {
        notiText.text = text;
    }
}
