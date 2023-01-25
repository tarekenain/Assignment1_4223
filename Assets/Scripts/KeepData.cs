using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static string PlayerName;
    public static float PlayerSpeed;

    public InputField PlayerNameInput;
    public Slider speedSlider;

    public Text showPlayerName;
    public Text PlayerSpeedText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {

    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text; // PlayerName (Variable) is set to the text that is inputted in InputField
        Debug.Log(PlayerName);
        showPlayerName.text = PlayerName; // The Text box for the player name is then set to the PlayerName variable.
    }

    public void ShowName()
    {
        showPlayerName.text = PlayerName;
        Debug.Log(PlayerName);
    }

    public void SetSpeed()
    {
        PlayerSpeed = speedSlider.value;
        PlayerSpeedText.text = PlayerSpeed.ToString();
    }
    public void ShowSpeed()
    {
        PlayerSpeedText.text = PlayerSpeed.ToString();
        speedSlider.value = PlayerSpeed;
    }

    public void ChangeSpeed()
    {
        PlayerSpeed = speedSlider.value;
        PlayerSpeedText.text = speedSlider.value.ToString();
    }


}
