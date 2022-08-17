using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyPartsList : MonoBehaviour
{
    public Image brainImg;
    public Image heartImg;

    public void OnBrainFound()
    {
        brainImg.color = new Color(1, 1, 1, 1);
    }
    public void OnHeartFound()
    {
        brainImg.color = new Color(1, 1, 1, 1);
    }

}
