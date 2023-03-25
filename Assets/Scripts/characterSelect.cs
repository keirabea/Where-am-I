using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterSelect : MonoBehaviour
{
    public GameObject[] skins;
    public int selectedCharacter;

    private void Awake()
    {
        selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter", 0);
        Debug.Log("awake" );
        Debug.Log("selected char: " + selectedCharacter);
        Debug.Log("no of skins: " + skins.Length);
        
        foreach (GameObject player in skins)
        {
            player.SetActive(false);
            Debug.Log("set player " + player + " to false");
        }
        //set selected character to true
        skins[selectedCharacter].SetActive(true);
    }

    //gives functionality to next button, user can cycle forward in the character options
    public void NextOption()
    {
        //disable current selected character
        skins[selectedCharacter].SetActive(false);
        //increment by 1 each time next is clicked
        selectedCharacter++;
        if (selectedCharacter == skins.Length)
        {
            selectedCharacter = 0;
        }
        skins[selectedCharacter].SetActive(true);
        Debug.Log("Next option selected char " + selectedCharacter);
        //PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);
    }

    //gives functionality to back button, user can return to previous option
    public void BackOption()
    {
        Debug.Log("Back option selected char " + selectedCharacter);
        skins[selectedCharacter].SetActive(false);
        //increment by -1
        selectedCharacter--;
        if (selectedCharacter == -1)
        {
            selectedCharacter = skins.Length - 1;
        }
        skins[selectedCharacter].SetActive(true);
        Debug.Log("Back option selected char " + selectedCharacter);
        //PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);
    }
    
    public void PlayGame()
    {
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);
        Debug.Log("PlayGame with " + selectedCharacter);
        SceneManager.LoadScene("pinkRoomL1");
    }

    public void MenuOption()
    {
        SceneManager.LoadScene("menu");
    }
}

