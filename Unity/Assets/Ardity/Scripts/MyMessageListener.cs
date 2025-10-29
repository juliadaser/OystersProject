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
        Debug.Log("Arrived: " + msg);

        if (msg == "0")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = attractSprite;
            attractName.text = "";
            attractRole.text = "";
        }

        if (msg == "1")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = benSprite;
            attractName.text = "Ben";
            attractRole.text = "Hatchery Technician";

        }

        if (msg == "2")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = danielleSprite;
            attractName.text = "Danielle";
            attractRole.text = "Director of Restoration";
        }

        if (msg == "3")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = johnnySprite;
            attractName.text = "Johnny";
            attractRole.text = "Fabrication Coordinator";
        }

        if (msg == "4")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = khourySprite;
            attractName.text = "Khoury";
            attractRole.text = "Project Manager";
        }

        if (msg == "5")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = rebeccaSprite;
            attractName.text = "Rebecca";
            attractRole.text = "Hatchery Manager";
        }

    }
  
  
    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}
