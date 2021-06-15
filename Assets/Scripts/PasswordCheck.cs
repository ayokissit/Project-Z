using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PasswordCheck : MonoBehaviour
{
    public InputField FirstNameInput;
    public InputField LastNameInput;
    public InputField PasswordInput;

    public GameObject NameToggle;
    public GameObject SurnameToggle;
    public GameObject SymbolsToggle;
    public GameObject UpCaseToggle;
    public GameObject LengthToggle;

    public Text NameText;
    public Text SurnameText;
    public Text SymbolsText;
    public Text UpCaseText;
    public Text LengthText;

    private bool IsNameCorrect;
    private bool IsSurnameCorrect;
    private bool IsSymbolsCorrect;
    private bool IsUpCaseCorrect;
    private bool IsLengthCorrect;

    public bool isAllCorrect { get; set; }

    void Start()
    {
        isAllCorrect = false;
    }

    void Update()
    {
        Name();
        Surname();
        Symbols();
        UpCase();
        TextLength();

        if (IsNameCorrect 
            && IsSurnameCorrect 
            && IsSymbolsCorrect 
            && IsUpCaseCorrect 
            && IsLengthCorrect)
            isAllCorrect = true;
        else
            isAllCorrect = false;
    }

    private void UpCase()
    {
        var chars = "QWERTYUIOPASDFGHJKLZXCVBNM";
        foreach (var symbol in chars)
        {
            if (PasswordInput.text.Contains(symbol))
            {
                MakeActive(UpCaseToggle, UpCaseText);
                IsUpCaseCorrect = true;
            }
        }
    }

    private void Symbols()
    {
        var symbols = "%*)?@#$~";
        foreach (var e in PasswordInput.text)
        {
            if (symbols.Contains(e))
            {
                MakeActive(SymbolsToggle, SymbolsText);
                IsSymbolsCorrect = true;
            }
        }
    }

    private void Surname()
    {
        if (LastNameInput.text.Length != 0)
        {
            MakeActive(SurnameToggle, SurnameText);
            IsSurnameCorrect = true;
        }
        else
        {
            MakeNotActive(SurnameToggle, SurnameText);
            IsSurnameCorrect = false;
        }
    }

    private void Name()
    {
        if (FirstNameInput.text.Length != 0)
        {
            MakeActive(NameToggle, NameText);
            IsNameCorrect = true;
        }
        else
        {
            MakeNotActive(NameToggle, NameText);
            IsNameCorrect = false;
        }
    }

    private void TextLength()
    {
        if (PasswordInput.text.Length >= 8)
        {
            MakeActive(LengthToggle, LengthText);
            IsLengthCorrect = true;
        }
        else
        {
            MakeNotActive(LengthToggle, LengthText);
            IsLengthCorrect = false;
        }
    }

    private void MakeNotActive(GameObject toggle, Text text)
    {
        toggle.SetActive(false);
        text.color = Color.red;
    }

    private void MakeActive(GameObject toggle, Text text)
    {
        toggle.SetActive(true);
        text.color = Color.green;
    }
}