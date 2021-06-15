using System;
using UnityEngine;
using UnityEngine.UI;

public class RegistrationScript : MonoBehaviour
{
    public InputField FirstNameInput;
    public InputField LastNameInput;
    public InputField PasswordInput;

    public Button Registration;

    private PasswordCheck passCheck;

    void Start()
    {
        Registration.interactable = false;
        passCheck = GetComponent<PasswordCheck>();
    }

    void Update()
    {
        if (passCheck.isAllCorrect)
        {
            Registration.interactable = true;
        }
        else
            Registration.interactable = false;
    }

    public void SaveUsername()
    {
        PlayerPrefs.SetString("FirstName", FirstNameInput.text);
        PlayerPrefs.SetString("LastName", LastNameInput.text);
    }
}
