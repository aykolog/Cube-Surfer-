using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondCollector : MonoBehaviour
{
    public GameObject mainCube;
    public Text skorText;

    


    private void Start()
    {
        // Load the saved score from PlayerPrefs
        mainCube.GetComponent<SurferStackController>().score = PlayerPrefs.GetInt("CollectedDiamonds", 0);
        GuncelleSkorText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collector"))
        {

            
            mainCube.GetComponent<SurferStackController>().score++;
            GuncelleSkorText();

            // Save the updated score to PlayerPrefs
            PlayerPrefs.SetInt("CollectedDiamonds", mainCube.GetComponent<SurferStackController>().score);

            // Destroy the diamond
            
            Destroy(gameObject);

        }
    }

    private void GuncelleSkorText()
    {
        skorText.text = " " + mainCube.GetComponent<SurferStackController>().score.ToString();
    }

    private void OnApplicationQuit()
    {
        // Uygulama kapatıldığında PlayerPrefs'i sıfırla
        PlayerPrefs.DeleteAll();
    }
}