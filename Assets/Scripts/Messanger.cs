using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messanger : MonoBehaviour
{
    public GameObject chatPanel, textObject;

    [SerializeField]
    List<Message> messageList = new List<Message>(); 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SendMessageToChat("Space pressed");
    }

    public void SendMessageToChat(string text)
    {
        var newMessage = new Message();
        newMessage.text = text;

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
