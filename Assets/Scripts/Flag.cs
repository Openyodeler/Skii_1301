using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class Flag : MonoBehaviour
{
    [SerializeField] private int point = 1; 
    
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player == null)
            return;
        player.Point += point;
        UiManager.instance.ShowNotiText($"+10 point\nPoint : {player.Point}");
        Destroy(gameObject);
    }
}
