using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public void IncreaseScore(int score)
    {
        GetComponent<Text>().text = score.ToString();
    }
}
