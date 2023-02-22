using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject foundObject = GameObject.FindGameObjectWithTag("GameController");

        if(foundObject != null)
        {

            GameManager gameManager = foundObject.GetComponent<GameManager>();

            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

            spriteRenderer.sprite = gameManager.selectedCar; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
