using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingC : MonoBehaviour
{
    public GameObject mainTextObject;
    public GameObject fadeIn;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject textBox;
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
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
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeIn.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Narator";
        textToSpeak = "Rekan kerja Raka melempar korek api. Kebakaran sempat berkobar, namun hujan deras tiga hari kemudian memadamkan api sebelum asapnya mencapai kota.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength >= currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 1;  
    }
    IEnumerator EventOne()
    {
        nextButton.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Narator";
        textToSpeak = " Tidak ada bencana kabut asap, namun tidak ada pula hadiah jabatan atau kekayaan bagi Raka. Hutan masa kecilnya telah hilang, berganti barisan sawit yang sunyi.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 2;  
    }

    IEnumerator EventTwo()
    {
        nextButton.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Narator";
        textToSpeak = " Dalam lubuk hatinya yang terdalam, Raka hanya bisa menyesali diamnya.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = -1;  
    }

    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
        }
        else if (eventPos == 2)
        {
            StartCoroutine(EventTwo());
        }
        else if (eventPos == -1)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
