using System;
using TMPro;
using UnityEngine;

public class MysticCounter : MonoBehaviour
{
    private TextMeshProUGUI mysticItemText;
    private int counter = -1;

    private void Awake()
    {
        mysticItemText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateMysticItemText()
    {
        counter++;
        if (counter == 0) mysticItemText.enabled = true;
        mysticItemText.text = $"Mystic Items: {counter + 1}";
    }
}
