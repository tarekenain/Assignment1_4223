using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public GameObject settingsUI;
    public GameObject hiddenButton;
    public GameObject showButton;


    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShowSettings()
    {
        settingsUI.SetActive(true);
        hiddenButton.SetActive(true);
        showButton.SetActive(false);
    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void BackFromSettings()
    {
        SceneManager.LoadScene(0);
    }



    public void HideSettings()
    {
        settingsUI.SetActive(false);
        hiddenButton.SetActive(false);
        showButton.SetActive(true);
    }



}