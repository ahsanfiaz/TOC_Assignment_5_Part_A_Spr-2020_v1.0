using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
public class PositionController : MonoBehaviour
{
    public GameObject theObject;
    public GameObject theSphere;
    public float maxPos = 0f;
    public float minPos = 30f;
    private string randomString;
    private int thestringlength;
    public void spawn()
    {
        ArrayList palindromePos = new ArrayList();
        int palindromeLength = Random.Range(3, 10);
        Text name;

        for (int i = 0; i < palindromeLength; i++)
        {
            int generatedNumber = Random.Range(1, 10);
            palindromePos.Add(generatedNumber);
            
        }

        for (int i = 0; i < 10; i++)
        {
            // foreach (var a in palindromePos)
            // {
            //     if (a.Equals(i))
            //     {
            //         Debug.Log("Waqas"+i);
            //     }
            // }
            randomString = "";
            float theXPosition = Random.Range(minPos, maxPos);
            float theZPosition = Random.Range(minPos, maxPos);
           
            var theNewPos = new Vector3(theXPosition, 5.0f, theZPosition);
            GameObject sphere = Instantiate(theSphere);
            GameObject cube = Instantiate(theObject);
            sphere.name = "Sphere" + i;
            cube.name = "Cube" + i;
            /*sphere.transform.position = new Vector3(theXPosition, 1.0f, theZPosition);
            cube.transform.position = theNewPos;
            name = GameObject.Find("Sphere" + i + "/Canvas/Text").GetComponent<Text>();
            string[] characters = new string[] { "x", "w", "3" };
            thestringlength = Random.Range(9, 15);
            for (int j = 0; j < thestringlength; j++)
            {
                randomString = randomString + characters[Random.Range(0, characters.Length)];
            }
            name.text = randomString;*/
        }
    }

    // Update is called once per frame
    void Start()
    {
        spawn();
    }
}