using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITextUpdater : MonoBehaviour
{
    [SerializeField] private string message1;
    [SerializeField] private string message2;
    [SerializeField] private TextMeshProUGUI messageLabel;
    public void Button1()
    {
        messageLabel.text = "\nWhats the best day of the week: " + message1;
    }
    public void Button2()
    {
        messageLabel.text = "\nWhats the worst day of the week: " + message2;
    }
}
