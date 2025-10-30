using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyMessageListener : MonoBehaviour
{
    [SerializeField] Sprite attractSprite;
    [SerializeField] Sprite benSprite;
    [SerializeField] Sprite danielleSprite;
    [SerializeField] Sprite johnnySprite;
    [SerializeField] Sprite khourySprite;
    [SerializeField] Sprite rebeccaSprite;

    [SerializeField] TextMeshPro attractName;
    [SerializeField] TextMeshPro attractRole;

    string oldMsg = "0";

    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {
     // Debug.Log("Arrived: " + msg + "  Oldmsg:" + oldMsg);

        if (msg == "0" && oldMsg != msg)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = attractSprite;
            attractName.GetComponent<TypewriterUI>().SetText("");

        }

        if (msg == "1" && oldMsg != msg)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = benSprite;
            attractName.GetComponent<TypewriterUI>().SetText("Ben - Hatchery Technician");

        }

        if (msg == "2" && oldMsg != msg)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = danielleSprite;
            attractName.GetComponent<TypewriterUI>().SetText("Danielle - Director of Restoration");
        }

        if (msg == "3" && oldMsg != msg)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = johnnySprite;
            attractName.GetComponent<TypewriterUI>().SetText("Johnny - Fabrication Coordinator");
        }

        if (msg == "4" && oldMsg != msg)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = khourySprite;
            attractName.GetComponent<TypewriterUI>().SetText("Khoury - Project Manager");
        }

        if (msg == "5" && oldMsg != msg)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = rebeccaSprite;
            attractName.GetComponent<TypewriterUI>().SetText("Rebecca - Hatchery Manager");
        }

        oldMsg = msg;

    }
  
  
    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}
