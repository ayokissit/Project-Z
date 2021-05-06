using UnityEngine;
using UnityEngine.UI;

public class TextTrigger : MonoBehaviour
{
    public GameObject Text;
    public GameObject Sphere;
    public Text LabelName;

    void Start()
    {
        Text.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            Text.SetActive(true);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        var playerPos = Camera.main.WorldToScreenPoint(Sphere.transform.position);
        LabelName.transform.position = playerPos;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Text.SetActive(false);
    }
}
