using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingA : MonoBehaviour
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
        textToSpeak = "Mobil patroli Kepolisian dan petugas Dinas Kehutanan tiba di lokasi hutan yang masih hijau asri, memasang garis segel \"DILARANG MELAKUKAN AKTIVITAS / DALAM PENGAWASAN HUKUM\" di depan kawasan hutan. Terlihat plang denda administrasi dan penyegelan terhadap PT. Sawit Sejahtera Selalu. Raka tersenyum lega menatap pepohonan yang selamat.";
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
        textToSpeak = "Beberapa minggu kemudian, Raka memegang surat pemecatan tidak hormat di depan pintu kantor. Adegan berganti ke Raka yang ditolak saat melamar kerja di berbagai tempat karena daftar hitam (blacklist) dari koneksi Pak Wahyu.";
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
        textToSpeak = "Raka pulang ke rumah dengan tangan kosong; meja makan tampak sepi, ibu dan adik-adiknya menahan lapar, sementara Raka menatap keluar jendela memandang hutan hijau di kejauhan dengan perasaan campur aduk antara bangga dan pilu.";
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
