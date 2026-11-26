using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene07 : MonoBehaviour
{
    public GameObject mainTextObject;
    public GameObject fadeIn;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject textBox;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject optionAButton;
    [SerializeField] GameObject optionBButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;

    void Update()
    {
        textLength = TextCreator.charCount;
    }
    void Start(){
        textBox.SetActive(false);
        nextButton.SetActive(false);
        optionAButton.SetActive(false);
        optionBButton.SetActive(false);
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter(){
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeIn.SetActive(false);
        //char
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Narator";
        textToSpeak = "Kembali di tengah hutan. Raka berdiri dengan wajah dingin dan tertekan di depan rekan-rekan kerjanya. Dengan suara lantang ia memberi aba-aba.";
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
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak = "Tuangkan semuanya di sepanjang batas patok! Kita selesaikan pekerjaan ini hari ini juga!";
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
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Narator";
        textToSpeak = "Rekan kerja menuangkan bensin dari jerigen ke semak dan pangkal pohon. Raka mengeluarkan korek api gas/kayu dan menyalakannya; cahaya api kecil memantul di pupil matanya.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 3; 
    }

    IEnumerator EventThree()
    {
        optionAButton.SetActive(false);
        optionBButton.SetActive(false);
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Narator";
        textToSpeak = "Raka tiba-tiba mengingat masa kecilnya. Raka kecil berlari gembira di hutan yang sama bersama teman-teman desa";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 4;  
    }

    IEnumerator EventFour()
    {
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Ibu Raka";
        textToSpeak = "Nak, hutan itu titipan Tuhan. Dari sanalah air bersih mengalir dan udara kita tetap sejuk. Jangan pernah merusak tempat hidup orang banyak demi uang sesaat.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 5;  
    }

    IEnumerator EventFive()
    {
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak = "Hutan ini tempat aku tumbuh besar... Warga kampung di kaki bukit minum dari sungai hutan ini. Apa yang sebenarnya sedang kulakukan?";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 6;  
    }

    IEnumerator EventSix()
    {
        nextButton.SetActive(false);
        textBox.SetActive(false);
        yield return new WaitForSeconds(1);
        optionAButton.SetActive(true);
        optionBButton.SetActive(true);
    }

    IEnumerator EventSeven()
    {
        optionAButton.SetActive(false);
        optionBButton.SetActive(false); 
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak = "Maafkan aku, Bu... Aku tidak punya pilihan lain!";
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

    IEnumerator EventEight()
    {
        optionAButton.SetActive(false);
        optionBButton.SetActive(false); 
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Narator";
        textToSpeak = "Raka terdiam dan menolak membakar hutan dengan tangannya sendiri. Lalu, rekannya menghidupkan korek api dan melemparkannya ke hutan";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = -2;  
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
        else if (eventPos == 3)
        {
            StartCoroutine(EventThree());
        }
        else if (eventPos == 4)
        {
            StartCoroutine(EventFour());
        }
        else if (eventPos == 5)
        {
            StartCoroutine(EventFive());
        }
        else if (eventPos == 6)
        {
            StartCoroutine(EventSix());
        }
        else if (eventPos == -1)
        {
            SceneManager.LoadScene("EndingB");
        }
        else if (eventPos == -2)
        {
            SceneManager.LoadScene("EndingC");
        }
    }

    public void OptionAButton()
    {
        eventPos = 7;
        StartCoroutine(EventSeven());
        textBox.SetActive(true);
    }

    public void OptionBButton()
    {
        eventPos = 8;
        StartCoroutine(EventEight());
        textBox.SetActive(true);
    }
}
