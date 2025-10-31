using System.Collections;
using UnityEngine;
using TMPro;

public class TypewriterUI : MonoBehaviour
{
    private TMP_Text _tmpProText;
    private Coroutine typingCoroutine;
    private bool isTyping = false;

    [Header("Typewriter Settings")]
    [SerializeField] private float delayBeforeStart = 0f;
    [SerializeField] private float timeBtwChars = 0.05f;
    [SerializeField] private string leadingChar = "";
    [SerializeField] private bool leadingCharBeforeDelay = false;

    void Awake()
    {
        // This works for both 3D TextMeshPro and TextMeshProUGUI
        _tmpProText = GetComponent<TMP_Text>();
        if (_tmpProText == null)
        {
            Debug.LogError("❌ No TMP_Text component found! Please attach this to a Text (TMP) or TextMeshProUGUI object.");
        }
    }

    /// <summary>
    /// Call this to change and animate text.
    /// </summary>
    public void SetText(string newText)
    {
        if (_tmpProText == null) return;

        // Stop any current animation
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
            typingCoroutine = null;
        }

        // Start new animation
        typingCoroutine = StartCoroutine(TypeWriterTMP(newText));
    }

    private IEnumerator TypeWriterTMP(string fullText)
    {
        isTyping = true;

        // Optional starting char
        _tmpProText.text = leadingCharBeforeDelay ? leadingChar : "";

        if (delayBeforeStart > 0)
            yield return new WaitForSeconds(delayBeforeStart);

        // Animate letters
        for (int i = 0; i < fullText.Length; i++)
        {
            // Remove cursor if needed
            if (!string.IsNullOrEmpty(leadingChar) && _tmpProText.text.EndsWith(leadingChar))
                _tmpProText.text = _tmpProText.text.Substring(0, _tmpProText.text.Length - leadingChar.Length);

            _tmpProText.text += fullText[i];

            if (!string.IsNullOrEmpty(leadingChar))
                _tmpProText.text += leadingChar;

            yield return new WaitForSeconds(timeBtwChars);
        }

        // Remove trailing cursor at the end
        if (!string.IsNullOrEmpty(leadingChar) && _tmpProText.text.EndsWith(leadingChar))
            _tmpProText.text = _tmpProText.text.Substring(0, _tmpProText.text.Length - leadingChar.Length);

        isTyping = false;
        typingCoroutine = null;
    }
}
