using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.Find("Coin Count Text") != null)
        {
            Debug.Log("I found the Coin Count Text");
            GameObject.find("Coin Count Text").GetComponent<TextMeshProUGUI>;
        }
        else
        {
            Debug.Log("I can't find the Coin Count Text");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RaceButtonPressed()
    {
        SceneManager.LoadScene("GameModes");
    }

    public void SingleRaceButtonPressed()
    {
        SceneManager.LoadScene("Single Race");
    }

    public void CupRaceButtonPressed()
    {
        SceneManager.LoadScene("Course 1");
    }
}
