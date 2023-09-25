using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreElement : MonoBehaviour
{
    public TMP_Text usernameText;
    public TMP_Text killsText;


    public void NewScoreElement (string _username, int _kills)
    {
        Debug.LogWarning("Hola me han creado");
        usernameText.text = _username;
        killsText.text = _kills.ToString();

    }
}

