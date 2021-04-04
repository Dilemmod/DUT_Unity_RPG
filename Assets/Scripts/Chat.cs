using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Chat : MonoBehaviour
{
    public Transform textPrefab;
    public Transform perent;
    private Canvas chat;


    public void CreateMessage(string text)
    {
        chat.enabled = true;
        GameObject newMessage = Instantiate(textPrefab, perent).gameObject;
        TextMeshProUGUI newMessageText = newMessage.GetComponentInChildren<TextMeshProUGUI>();
        newMessageText.text = text;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            chat.enabled = !chat.enabled; 
        }
    }
    private void Start()
    {
        chat = GetComponent<Canvas>();
        chat.enabled = false;
    }
}
