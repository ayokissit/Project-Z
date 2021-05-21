using System;
using UnityEngine;
using UnityEngine.UI;

public class RegistrationScript : MonoBehaviour
{
    public InputField FirstNameInput;
    public InputField LastNameInput;
    public InputField PasswordInput;

    public GameObject WarningFirstName;
    public GameObject WarningLastName;
    public GameObject WarningPassword;

    public Button Registration;

    void Start()
    {
        Registration.interactable = false;
    }

    void Update()
    {
        var firstNameLength = FirstNameInput.text.Length;
        var lastNameLength = LastNameInput.text.Length;
        var passwordLength = PasswordInput.text.Length;

        ActiveField(firstNameLength, WarningFirstName);
        ActiveField(lastNameLength, WarningLastName);
        ActiveField(passwordLength, WarningPassword);

        if (firstNameLength != 0
            && lastNameLength != 0
            && passwordLength != 0)
        {
            Registration.interactable = true;
        }
    }

    public void SaveUsername()
    {
        PlayerPrefs.SetString("FirstName", FirstNameInput.text);
        PlayerPrefs.SetString("LastName", LastNameInput.text);
    }

    void ActiveField(int fieldLength, GameObject warningField)
    {
        if (fieldLength == 0) 
            warningField.SetActive(true);
        else 
            warningField.SetActive(false);
    }
}
