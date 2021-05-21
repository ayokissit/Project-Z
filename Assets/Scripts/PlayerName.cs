using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    static string FirstName;
    static string LastName;

    public Text PlayersName;

    void Start()
    {
        FirstName = PlayerPrefs.GetString("FirstName");
        LastName = PlayerPrefs.GetString("LastName");

        PlayersName.text = LastName + " " + FirstName;
    }
}
