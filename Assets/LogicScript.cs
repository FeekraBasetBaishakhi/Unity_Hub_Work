using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int scorePlyer;
    public Text textScore;
    
    public void  scoreAdd()// for showcasing number
    {
        scorePlyer = scorePlyer + 1;
        textScore.text = scorePlyer.ToString();

    }
    
}
