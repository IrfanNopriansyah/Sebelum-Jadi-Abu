using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    public GameObject mainTextObject;
    public GameObject fadeIn;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject textBox;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject charName;

    void Update()
    {
        textLength = TextCreator.charCount;
    }
    void Start(){
        textBox.SetActive(false);
        nextButton.SetActive(false);
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter(){
        yield return new WaitForSeconds(2);
        fadeIn.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Narator";
        textToSpeak = "Sejak Januari hingga 29 September 2026, tercatat 1.279 kejadian kebakaran hutan dan lahan di Indonesia.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength >= currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Scene01");
    }
}
