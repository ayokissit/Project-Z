using UnityEngine;
using UnityEngine.UI;

public class TextTrigger : MonoBehaviour
{
    public GameObject Text;
    public GameObject Sphere;
    public Text LabelName;
    public bool IsPlayerInTrigger { get; set; }

    void Start()
    {
        Text.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GetPlayerPosition();
            Text.SetActive(true);
            IsPlayerInTrigger = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        GetPlayerPosition();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Text.SetActive(false);
        IsPlayerInTrigger = false;
    }

    void GetPlayerPosition()
    {
        var playerPos = Camera.main.WorldToScreenPoint(Sphere.transform.position);
        LabelName.transform.position = playerPos;
    }
}
