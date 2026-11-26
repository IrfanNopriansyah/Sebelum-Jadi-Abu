using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene05 : MonoBehaviour
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
    [SerializeField] GameObject optionCButton;
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
        optionCButton.SetActive(false);
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter(){
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeIn.SetActive(false);
        //char
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Narator";
        textToSpeak = "Keesokan harinya, Raka ditugaskan memimpin langsung tim ekspansi menuju titik lokasi di dalam hutan.";
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
        textToSpeak = "Di tengah rimbunnya pepohonan hutan, dua rekan kerja Raka menurunkan beberapa jerigen plastik berisi bensin/solar dari mobil pikap dan mulai membukanya di dekat tumpukan semak kering.";
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
        textToSpeak = "Berhenti! Kalian bawa jerigen apa ini? Untuk apa bensin sebanyak ini di tengah hutan?";
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
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Rekan Kerja";
        textToSpeak = "Ini perintah langsung dari manajemen pusat, Ka. Lahan ini harus cepat dibersihkan pakai api biar target tanam bulan depan terkejar.";
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
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak = "Kalian gila?! Api di hutan kering seperti ini bisa merembet puluhan kilometer dan membakar habis semuanya! Hentikan sekarang juga!";
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
        charName.GetComponent<TMPro.TMP_Text>().text = "Narator";
        textToSpeak = "Tiba-tiba, ponsel Raka berdering";
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
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Pak Wahyu";
        textToSpeak = "Raka, saya dengar dari mandor lapangan kamu menahan pekerjaan tim di sana. Jangan bertindak bodoh. Ikuti instruksi perusahaan dan jangan menghambat proyek ekspansi ini!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 7;  
    }

    IEnumerator EventSeven()
    {
        nextButton.SetActive(false);
        textBox.SetActive(false);
        yield return new WaitForSeconds(1);
        optionAButton.SetActive(true);
        optionBButton.SetActive(true); 
        optionCButton.SetActive(true);
    }

    IEnumerator EventEight()
    {
        optionAButton.SetActive(false);
        optionBButton.SetActive(false);
        optionCButton.SetActive(false);  
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak = "Saya tidak bisa melakukannya, Pak! Membakar hutan melanggar hukum dan akan menghancurkan lingkungan serta warga sekitar!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 12;  
    }
    IEnumerator EventNine()
    {
        optionAButton.SetActive(false);
        optionBButton.SetActive(false); 
        optionCButton.SetActive(false); 
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak = "Baik, Pak... Saya mengerti. Saya akan perintahkan tim untuk segera melaksanakannya.";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 12;  
    }
    IEnumerator EventTen()
    {
        optionAButton.SetActive(false);
        optionBButton.SetActive(false);
        optionCButton.SetActive(false);  
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak = "Pak, tolong beri kami waktu beberapa hari untuk membuka lahan dengan alat potong manual saja. Jangan pakai api, risikonya terlalu besar!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 11;  
    }

IEnumerator EventEleven()
    {
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Pak Wahyu";
        textToSpeak = "Tidak ada waktu untuk negosiasi, Raka! Kerjakan sekarang atau posisi kamu digantikan orang lain!";
        mainTextObject.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 12;  
    }
    IEnumerator EventTwelve()
    {
        nextButton.SetActive(false);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Narator";
        textToSpeak = "Raka menutup telepon dengan napas memburu.";
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
        else if (eventPos == 7)
        {
            StartCoroutine(EventSeven());
        }
        else if (eventPos == 11)
        {
            StartCoroutine(EventEleven());
        }
        else if (eventPos == -1)
        {
            SceneManager.LoadScene("Scene06");
        }
    }

    public void OptionAButton()
    {
        eventPos = 8;
        StartCoroutine(EventEight());
        textBox.SetActive(true);
    }

    public void OptionBButton()
    {
        eventPos = 9;
        StartCoroutine(EventNine());
        textBox.SetActive(true);
    }
    public void OptionCButton()
    {
        eventPos = 10;
        StartCoroutine(EventTen());
        textBox.SetActive(true);
    }
}
