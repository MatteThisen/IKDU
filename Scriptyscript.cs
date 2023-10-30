using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptyscript : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        FindCharacters(3, "Tim Duncan");

    }
    /*
    int NumberOne = 4;
    int NumberTwo = 0;

    if (NumberOne > NumberTwo)
    {
        Debug.Log("Number One (" + NumberOne + ") is bigger than Number Two (" + NumberTwo + ")");
    }
    if (NumberTwo > NumberOne)
    {
        Debug.Log("Number Two (" + NumberTwo + ") is bigger than Number One (" + NumberOne + ")");
    }
    if (NumberOne == NumberTwo)
    {
        Debug.Log(NumberOne + " = " + NumberTwo);
    }
    */

    /*switch (NumberOne, NumberTwo)
    {
        case NumberOne > NumberTwo:
            Debug.Log(NumberOne + " is bigger than " + NumberTwo);
            break;
        case NumberTwo > NumberOne:
            Debug.Log(NumberTwo + " is bigger than " + NumberOne);
            break;
        default:
            Debug.Log(NumberOne + " = ");
            break;
    }*/


    public void FindCharacters(int index, string name)
    {
        List<string> Characters = new List<string>()
        {
        "Michael Jordan",
        "LeBron James",
        "Stephen Curry",
        "Kobe Bryant",
        "Larry Bird",
        "Magic Johnson",
        "Brian Scalabrine"
        };

        int listLength = Characters.Count;

        Characters.RemoveAt(6);
        Characters.Add("Bill Russell");
        Characters.Insert(index, name);

        Debug.LogFormat("Characters: {0}", listLength);

        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, Characters[i]);
            //Debug.Log(Characters[i]);  
            if (Characters[i] == "Michael Jordan")
            {
                Debug.Log("That's the GOAT!");
            }
        }


        // Update is called once per frame
        void Update()
        {

        }
    }
}
