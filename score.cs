using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public Transform player; // don't use publice gameobject because i only want postion and Transform is for postion rotation scale
    public TextMeshProUGUI scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); // can't just use player.position.z because the position of z axis is a float number.
                                                          // and float is one of the basic data type.
                                                          // so need to add .ToString() in order to make it into String.
                                                          // because whenever need to the text = something it requires String .
                                                          // and String is a fundamental data type and it use to store text , integer , charater.
                                                          // add the 0 in ToString() so that won't have 0.xxxxx
    }
}
