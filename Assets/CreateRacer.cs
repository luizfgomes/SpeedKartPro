using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateRacer : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private TMP_InputField teamInputField;
    [SerializeField] private TMP_Text message;

    string MessageFeedback() {

        var lastNameRegistered = nameInputField.text;

        if (nameInputField.text.Length < 2) {

            message.color = Color.red;
            return "O nome do piloto é invalido (menos de 2 digitos).";
        }

        if (teamInputField.text.Length<2) {

            message.color = Color.red;
            return "O nome da equipe é invalido (menos de 2 digitos).";
        }

        if (CheckInputsAreNull()) {

            message.color = Color.green;
            ClearInputFields();
            return $"O piloto <b>{lastNameRegistered}</b> foi cadastrado com sucesso.";
        }

        return default;
    }

    bool CheckInputsAreNull() {

        if(nameInputField.text.Length >= 2 && teamInputField.text.Length >= 2) {

            return true;
        } else {

            return false;
        }  
    }

    void ClearInputFields() {

        nameInputField.text = "";
        teamInputField.text = "";
    }

    public void ValidateInputs() {

        message.text = MessageFeedback();
        Debug.Log(CheckInputsAreNull());
    }
}
