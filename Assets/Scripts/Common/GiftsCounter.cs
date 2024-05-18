using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiftsCounter
{
    public static Text countText;
    public static Text winText;
    private static int count;

    // Start is called before the first frame update
    public void Start()
    {
        count = 0;
        countText.text = "Count: " + count.ToString();
        winText.text = "";

    }

    public static void Count()
    {
        count++;
        countText.text = "Count: " + count.ToString();
        if (count >= 8)
        {
            winText.text = "You Win!";
        }
    }
}
