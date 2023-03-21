using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterSelect : MonoBehaviour
{
    public GameObject[] Skins;
    public int selectedCharacter;

    private void Awake()
    {
        selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter", 0);
        Debug.Log("no of skins: " + Skins.Length);
        Debug.Log("selected char: " + selectedCharacter);
        foreach (GameObject player in Skins)
        {
            player.SetActive(false);
            Debug.Log("set player " + player + " to false");
        }
        //set selected character to true
        Skins[selectedCharacter].SetActive(true);
    }

    //gives functionality to next button, user can cycle forward in the character options
    public void NextOption()
    {
        //disable current selected character
        Skins[selectedCharacter].SetActive(false);
        //increment by 1 each time next is clicked
        selectedCharacter++;
        if (selectedCharacter == Skins.Length)
        {
            selectedCharacter = 0;
        }
        Skins[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);
    }

    //gives functionality to back button, user can return to previous option
    public void BackOption()
    {
        Debug.Log("Back option selected char " + selectedCharacter);
        Skins[selectedCharacter].SetActive(false);
        //increment by -1
        selectedCharacter--;
        if (selectedCharacter == -1)
        {
            selectedCharacter = Skins.Length - 1;
        }
        Skins[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);
    }
    
    public void PlayGame()
    {
        //PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/selectedSkin.prefab");
        SceneManager.LoadScene("pinkRoomL1");
    }

    public void MenuOption()
    {
        SceneManager.LoadScene("menu");
    }
}

