using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject selectedSkin;
    public GameObject Player;

    private Sprite playersprite;

    void Start()
    {
        playersprite = selectedSkin.GetComponent<SpriteRenderer>().sprite;

        Player.GetComponent<SpriteRenderer>().sprite = playersprite;
    }
}
