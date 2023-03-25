using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{

    public GameObject[] playerPrefabs;
    //public GameObject[] skins;
    public static bool isGameOver;
    public static Vector2 LastCheckPointPos = new Vector2(-3,0);
    public int character;

    private void Awake()
    { 
        Debug.Log("In playerManager awake");
        character = PlayerPrefs.GetInt("SelectedCharacter", 0); 
        Debug.Log("playerManager playing game with: " + character);
        //Debug.Log("name is: " + gameObject.name);
        //Debug.Log("tag is: " + gameObject.tag);
        GameObject player = Instantiate(playerPrefabs[character]);
       
    }
 
 
}
