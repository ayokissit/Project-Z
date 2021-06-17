using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messanger : MonoBehaviour
{
    public GameObject chatPanel, textObject;

    [SerializeField]
    List<Message> messageList = new List<Message>();

    public void SendMessageToChat(string secMessage)
    {
        var newMessage = new Message();
        newMessage.text = secMessage;

        var newTextObj = Instantiate(textObject, chatPanel.transform);
        newMessage.textObject = newTextObj.GetComponent<Text>();
        newMessage.textObject.text = newMessage.text;

        messageList.Add(newMessage);
    }
}

[System.Serializable]
public class Message
{
    public string text;
    public Text textObject;
}
