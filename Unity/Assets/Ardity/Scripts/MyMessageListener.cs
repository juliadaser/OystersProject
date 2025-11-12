using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Video;
using TMPro;

public class MyMessageListener : MonoBehaviour
{
    //[SerializeField] Sprite attractSprite;
    [SerializeField] UnityEngine.Video.VideoPlayer attractVideoPlayer;
    [SerializeField] Sprite benSprite;
    [SerializeField] Sprite danielleSprite;
    [SerializeField] Sprite johnnySprite;
    [SerializeField] Sprite khourySprite;
    [SerializeField] Sprite rebeccaSprite;

    [SerializeField] TextMeshPro attractName;
    [SerializeField] TextMeshPro attractRole;

    public AudioSource source;
    public AudioClip clip_Danielle;
    public AudioClip clip_Khoury;
    public AudioClip clip_Johnny;
    public AudioClip clip_Rebecca;
    public AudioClip clip_Ben;

    public float fadeDuration = 0.5f;

    string oldMsg = "0";
    private Coroutine activeAudioCoroutine;

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
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();

         //Debug.Log("Arrived: " + msg + "  Oldmsg:" + oldMsg);

        if (msg == "0" && oldMsg != msg)
        {
            // Show attract video
            renderer.enabled = true;
            attractVideoPlayer.Play();

            // Clear text + stop audio
            attractName.GetComponent<TypewriterUI>().SetText("");
            StartAudioTransition(null);

            Debug.Log("Show attract video, clear text and stop audio");
        }

        if (msg == "1" && oldMsg != msg)
        {
            StopAttractVideo();
            renderer.sprite = benSprite;
            attractName.GetComponent<TypewriterUI>().SetText("Ben - Hatchery Technician");
            Debug.Log("Ben");

            StartAudioTransition(clip_Ben);
        }

        if (msg == "2" && oldMsg != msg)
        {
            StopAttractVideo();
            renderer.sprite = danielleSprite;
            attractName.GetComponent<TypewriterUI>().SetText("Danielle - Director of Restoration");
            Debug.Log("Danielle");

            StartAudioTransition(clip_Danielle);
        }

        if (msg == "3" && oldMsg != msg)
        {
            StopAttractVideo();
            renderer.sprite = johnnySprite;
            attractName.GetComponent<TypewriterUI>().SetText("Johnny - Fabrication Coordinator");
            Debug.Log("Johnny");

            StartAudioTransition(clip_Johnny);
        }

        if (msg == "4" && oldMsg != msg)
        {
            StopAttractVideo();
            renderer.sprite = khourySprite;
            attractName.GetComponent<TypewriterUI>().SetText("Khoury - Project Manager");
            Debug.Log("Khoury");
            Debug.Log("Renderer enabled? " + renderer.enabled);
            Debug.Log("Attract video renderer active? " + attractVideoPlayer.GetComponent<Renderer>().enabled);

            StartAudioTransition(clip_Khoury);
        }

        if (msg == "5" && oldMsg != msg)
        {
            StopAttractVideo();
            renderer.sprite = rebeccaSprite;
            attractName.GetComponent<TypewriterUI>().SetText("Rebecca - Hatchery Manager");
            Debug.Log("Rebecca");

            StartAudioTransition(clip_Rebecca);
        }

        oldMsg = msg;

    }


    void StopAttractVideo()
    {
        if (attractVideoPlayer.isPlaying)
        {
            attractVideoPlayer.Stop();
            Debug.Log("Stopping video player");
        }
    }


    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }

    public void StartAudioTransition(AudioClip newClip)
    {
        // If a fade is already in progress, stop it immediately.
        if (activeAudioCoroutine != null)
        {
            StopCoroutine(activeAudioCoroutine);
        }

        // Start the new transition and store a reference to it.
        activeAudioCoroutine = StartCoroutine(AudioTransitionCoroutine(newClip));
    }

    private IEnumerator AudioTransitionCoroutine(AudioClip clipToPlay)
    {
        // 1. Fade out the currently playing clip (if there is one)
        if (source.isPlaying)
        {
            float startVolume = source.volume;
            float timer = 0f;

            while (timer < fadeDuration)
            {
                timer += Time.deltaTime;
                source.volume = Mathf.Lerp(startVolume, 0f, timer / fadeDuration);
                yield return null; // Wait for the next frame
            }
        }

        // 2. Stop the source completely
        source.Stop();
        source.volume = 0f; // Ensure volume is 0

        // 3. Play the new clip (if one was provided)
        if (clipToPlay != null)
        {
            source.volume = 1f; // Reset volume to full
            source.PlayOneShot(clipToPlay);
        }
    }
}