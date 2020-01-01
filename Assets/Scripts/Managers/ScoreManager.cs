using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    static int speedBoost = 0;
    public int scoreRequired = 50;
    int scoreTreshold = 0;
    public static int SpeedBoost {
        get {return speedBoost;}
        set {speedBoost = value;}
    }

    Text text;
    public Text powerUpText;


    void Awake ()
    {
        text = GetComponent <Text> ();
        score = 0;
    }


    void Update ()
    {
        text.text = "Score: " + score;
        powerUpText.text = "Power Up Charge : "+ speedBoost;
        CheckSpeedBoost();
    }

    void CheckSpeedBoost()
    {
        if(score-scoreTreshold >= scoreRequired)
        {
            speedBoost+= (int) (score-scoreTreshold) / scoreRequired;
            scoreTreshold = score;
        }
    }

}
