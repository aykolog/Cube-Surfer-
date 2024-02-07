using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
{

    public void OnReplayButtonClicked()
    {
        // Şu anki sahneyi yeniden yükle
        ReloadScene();
    }

    // Sahneyi yeniden yüklemek için fonksiyon
    private void ReloadScene()
    {
        // SceneManager sınıfını kullanarak şu anki sahnenin adını al
        string currentSceneName = SceneManager.GetActiveScene().name;

        // SceneManager sınıfını kullanarak sahneyi yeniden yükle
        SceneManager.LoadScene(currentSceneName);
    }

    public void OnQuitButtonClicked()
    {
        // Uygulamayı kapat
        QuitGame();
    }

    // Uygulamayı kapatmak için fonksiyon
    private void QuitGame()
    {
        // Uygulamayı kapatmak için Application.Quit() fonksiyonunu kullan
        // Bu fonksiyon yalnızca standalone platformlarda çalışır (örneğin, PC, Mac)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
