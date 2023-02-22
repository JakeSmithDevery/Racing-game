using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarSelectController : MonoBehaviour
{

    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameObject foundObject = GameObject.FindGameObjectWithTag("GameController");

        gameManager = foundObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    public void UpdateSelectedCar(Button selectedButton)
    {
        Image buttonImage = selectedButton.GetComponent<Image>();
        gameManager.selectedCar = buttonImage.sprite;
        gameManager.LoadScene("game");
    }
}


