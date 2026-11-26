using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene06 : MonoBehaviour
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
        textToSpeak = "Nurani Raka menang atas rasa takutnya. Ia segera meninggalkan lokasi dan menyiapkan seluruh bukti beserta titik koordinat hutan untuk dilaporkan kepada Dinas Kehutanan dan Kepolisian.";
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
        charName.GetComponent<TMPro.TMP_Text>().text = "Narator";
        textToSpeak = "Raka meninggalkan area hutan dengan tergesa-gesa menuju pinggir jalan desa yang memiliki sinyal seluler. Ia membuka ponselnya, menyusun foto berkas rencana pembakaran, foto jerigen di hutan, serta pin koordinat lokasi GPS untuk dikirimkan ke kanal pengaduan Dinas Kehutanan dan Kepolisian.";
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
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak = "Nomor pengaduan Dinas Kehutanan dan Polres sudah siap. Begitu laporan ini terkirim, mereka tidak akan sempat menyulut api.";
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
        textToSpeak = "Layar ponsel Raka tiba-tiba menampilkan panggilan masuk bertuliskan \"Nomor Tidak Dikenal\".";
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
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "Kami tahu apa yang sedang kamu siapkan, Raka. Hentikan laporan itu sekarang, atau ibu dan sepuluh adikmu di rumah akan menerima akibatnya.";
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
        textBox.SetActive(false);
        yield return new WaitForSeconds(1);
        optionAButton.SetActive(true);
        optionBButton.SetActive(true);
    }

    IEnumerator EventSix()
    {
        optionAButton.SetActive(false);
        optionBButton.SetActive(false); 
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak = "Kalian tidak bisa terus membungkam kebenaran dengan ancaman! Laporan ini tetap aku kirim!";
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

    IEnumerator EventSeven()
    {
        optionAButton.SetActive(false);
        optionBButton.SetActive(false); 
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak = "Maafkan aku... Aku tidak sanggup mempertaruhkan nyawa ibu dan adik-adikku.";
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
        else if (eventPos == -1)
        {
            SceneManager.LoadScene("EndingA");
        }
        else if (eventPos == -2)
        {
            SceneManager.LoadScene("EndingC");
        }
    }

    public void OptionAButton()
    {
        eventPos = 6;
        StartCoroutine(EventSix());
        textBox.SetActive(true);
    }

    public void OptionBButton()
    {
        eventPos = 7;
        StartCoroutine(EventSeven());
        textBox.SetActive(true);
    }
}
