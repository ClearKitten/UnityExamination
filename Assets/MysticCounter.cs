using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class MysticCounter : MonoBehaviour
{
    private TextMeshProUGUI mysticItemText;
    private int counter = -1;

    private int pickedUpSinceTimerStarted;
    private bool timerStarted = false;

    public UnityEvent onCollectedItems;

    private void Awake()
    {
        mysticItemText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateMysticItemText()
    {
        counter++;
        if (counter == 0) mysticItemText.enabled = true;

        if (timerStarted)
        {
            pickedUpSinceTimerStarted++;
            if(pickedUpSinceTimerStarted == 3) onCollectedItems?.Invoke();
        }
        mysticItemText.text = $"Mystic Items: {counter + 1}";
    }
}
