using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor;

public class characterSelect : MonoBehaviour
{
    public GameObject[] skins;
    public int selectedCharacter;

    //private void Awake()
    private void Awake()
    {
         selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter", 0);
         foreach (GameObject player in skins)
             player.SetActive(false);
         skins[selectedCharacter].SetActive(true);
     }

    //gives functionality to next button, user can cycle forward in the character options
    public void NextOption()
    {
        skins[selectedCharacter].SetActive(false);
        //increments by 1
        selectedCharacter++;
        if (selectedCharacter == skins.Length)
             selectedCharacter = 0;

        skins[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);
     }
 
    //gives functionality to back button, user can return to previous option
    public void BackOption()
    {
         skins[selectedCharacter].SetActive(false);
         //increment by -1
         selectedCharacter--;
         if (selectedCharacter == skins.Length)
         {
             selectedCharacter = 0;
         }
         skins[selectedCharacter].SetActive(true);
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
