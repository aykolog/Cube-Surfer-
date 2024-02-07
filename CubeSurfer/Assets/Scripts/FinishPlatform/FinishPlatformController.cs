using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishPlatformController : MonoBehaviour
{
    public Text puanText;

    public int basamakPuan = 10; 
    private int toplamPuan = 0;
    


    private void Start()
    {
        if (PlayerPrefs.HasKey("ToplamPuan"))
        {
            toplamPuan = PlayerPrefs.GetInt("ToplamPuan");
            UpdatePuanText();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FinishPlatform")
        {
            toplamPuan += basamakPuan; 
            UpdatePuanText();

           
            if (toplamPuan >= 3 * basamakPuan) 
            {
                Debug.Log("Oyunu Kazandınız!");

                PlayerPrefs.SetInt("ToplamPuan", toplamPuan);
                PlayerPrefs.Save();

                GelecekLevel(); 
            }

        }
    }

    private void UpdatePuanText()
    {
        if(puanText != null)
        {
            puanText.text = " " + toplamPuan;
        }
    }

    private void GelecekLevel()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnApplicationQuit()
    {
        // Uygulama kapatıldığında PlayerPrefs'i sıfırla
        PlayerPrefs.DeleteAll();
    }
}
