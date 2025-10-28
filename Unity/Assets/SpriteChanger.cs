using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    [SerializeField] Sprite attractSprite;
    [SerializeField] Sprite benSprite;
    [SerializeField] Sprite danielleSprite;
    [SerializeField] Sprite johnnySprite;
    [SerializeField] Sprite khourySprite;
    [SerializeField] Sprite rebeccaSprite;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = benSprite;
    }
}
