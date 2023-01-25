using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    public void Quit ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void RestartGame ()
    {
        SceneManager.LoadScene(0);
    }

}
