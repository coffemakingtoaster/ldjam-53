using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public bool isShown = false;

    public GameObject gameGod;

    public GameObject player;
    private CanvasGroup canvasGroup;
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.H))
        {
            isShown = !isShown;
            canvasGroup.alpha = isShown ? 1 : 0;
            canvasGroup.blocksRaycasts = isShown;
        }
        if (isShown)
        {
            Time.timeScale = 0; // pause the game
        }
        else
        {
            Time.timeScale = 1; // unpause the game
        }
    }

    public void buyHonk()
    {
        if (gameGod.GetComponent<GameGod>().buySomething(2000))
        {
            player.GetComponent<DriftController>().ActivateHonk();
            Debug.Log("Buying Bumpers");
        }
    }

    public void buyJumpers()
    {
        if (gameGod.GetComponent<GameGod>().buySomething(500))
        {
            player.GetComponent<DriftController>().ActivateJumper();
            Debug.Log("Buying Jumpers");
        }

    }

    public void buyJets()
    {
        if (gameGod.GetComponent<GameGod>().buySomething(1000))
        {
            player.GetComponent<DriftController>().ActivateTurbine();
            Debug.Log("Buying Jumpers");
        }
    }
}
