using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene01 : MonoBehaviour
{
    public GameObject mainTextObject;
    public GameObject fadeIn;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject textBox;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject acceptButton;
    [SerializeField] GameObject rejectButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;
    [SerializeField] GameObject raka;
    [SerializeField] GameObject wahyu;

    void Update()
    {
        textLength = TextCreator.charCount;
    }
    void Start(){
        textBox.SetActive(false);
        nextButton.SetActive(false);
        acceptButton.SetActive(false);
        rejectButton.SetActive(false);
        raka.SetActive(false);
        wahyu.SetActive(false);
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter(){
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeIn.SetActive(false);
        wahyu.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Pak Wahyu";
        textToSpeak = "Perusahaan kita harus mengejar target produksi tahun ini. Kita akan membuka lahan perkebunan sawit baru di sektor timur.";
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
        wahyu.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Pak Wahyu";
        textToSpeak = "Raka, kamu karyawan yang ulet. Saya tunjuk kamu untuk ikut langsung dalam tim proyek ekspansi ini. Bagaimana, kamu siap?";
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
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        textBox.SetActive(false);
        acceptButton.SetActive(true);
        rejectButton.SetActive(true);
    }

    IEnumerator EventThree()
    {
        acceptButton.SetActive(false);
        rejectButton.SetActive(false);
        nextButton.SetActive(false);
        raka.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak = "Siap, Pak Wahyu! Saya sangat membutuhkan kesempatan ini dan siap menjalankan tugas.";
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
        wahyu.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        charName.GetComponent<TMPro.TMP_Text>().text = "Pak Wahyu";
        textToSpeak = "Bagus. Loyalitas seperti ini yang perusahaan butuhkan.";
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

    IEnumerator EventFive()
    {
        acceptButton.SetActive(false);
        rejectButton.SetActive(false);
        nextButton.SetActive(false);
        raka.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak = "Maaf, Pak. Saya khawatir belum siap memegang tanggung jawab ekspansi lapangan sebesar itu.";
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
        wahyu.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Pak Wahyu";
        textToSpeak = "Ini bukan tawaran sukarela, Raka. Ini perintah kerja. Anggap saja ini ujian kelayakanmu di perusahaan.";
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
        wahyu.SetActive(false);
        raka.SetActive(false);
        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
        }
        else if (eventPos == 2)
        {
            StartCoroutine(EventTwo());
        }
        else if (eventPos == 4)
        {
            StartCoroutine(EventFour());
        }
        else if (eventPos == 6)
        {
            StartCoroutine(EventSix());
        }
        else if (eventPos == -1)
        {
            SceneManager.LoadScene("Scene02");
        }
    }

    public void AcceptButton()
    {
        eventPos = 3;
        StartCoroutine(EventThree());
        textBox.SetActive(true);
    }

    public void RejectButton()
    {
        eventPos = 5;
        StartCoroutine(EventFive());
        textBox.SetActive(true);
    }
}
