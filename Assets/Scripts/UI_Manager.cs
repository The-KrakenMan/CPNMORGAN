using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public Slider DrunkOMeter;
    public GameObject DeathScreen;
    public TextMeshProUGUI ScoreOut;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GrogUp()
    {
        DrunkOMeter.value += 0.1f;
    }

    public void DeathScreenUP(int Score)
    {
        DeathScreen.SetActive(true);
        ScoreOut.text = Score.ToString();
    }
}
