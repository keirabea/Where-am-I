using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{

    public GameObject[] playerPrefabs;
    int characterIndex;
    
    private void Awake()
    {
        characterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        Instantiate(playerPrefabs[characterIndex]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
