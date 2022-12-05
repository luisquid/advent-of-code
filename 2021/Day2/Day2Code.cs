using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2Code : MonoBehaviour
{
    public TextAsset day2Input;
    public string[] inputMovement;

    public int verticalPos = 0;
    public int horizontalPos = 0;
    public int aimValue = 0;

    void Start()
    {
        //Day2Part1();
        Day2Part2();
    }

    public void Day2Part1()
    {
        inputMovement = day2Input.text.Split('\n');

        for(int i = 0; i < inputMovement.Length; i++)
        {
            int tempVal = int.Parse(inputMovement[i].Split(' ')[1]);
            
            print("TOTAL STRING: " + inputMovement[i] + " TEMP MOVEMENT " + inputMovement[i][0] + " TEMP VALUE: " + tempVal);
            
            switch (inputMovement[i][0])
            {
                case 'f':
                    {
                        horizontalPos += tempVal;
                        break;
                    }
                case 'u':
                    {
                        verticalPos -= tempVal;
                        break;
                    }
                case 'd':
                    {
                        verticalPos += tempVal;
                        break;
                    }
            }
        }

        print("DAY 2 PART 1 VERTICAL POS: " + verticalPos + "\nDAY 2 PART 1 HORIZONTAL POS: " + horizontalPos);
        print("DAY 2 PART 1 SUM: " + verticalPos * horizontalPos);
    }

    public void Day2Part2()
    {
        inputMovement = day2Input.text.Split('\n');

        for (int i = 0; i < inputMovement.Length; i++)
        {
            int tempVal = int.Parse(inputMovement[i].Split(' ')[1]);

            print("TOTAL STRING: " + inputMovement[i] + " TEMP MOVEMENT " + inputMovement[i][0] + " TEMP VALUE: " + tempVal);

            switch (inputMovement[i][0])
            {
                case 'f':
                    {
                        horizontalPos += tempVal;
                        verticalPos += aimValue * tempVal;
                        break;
                    }
                case 'u':
                    {
                        aimValue -= tempVal;
                        break;
                    }
                case 'd':
                    {
                        aimValue += tempVal;
                        break;
                    }
            }
        }

        print("DAY 2 PART 2 VERTICAL POS: " + verticalPos + "\nDAY 2 PART 2 HORIZONTAL POS: " + horizontalPos);
        print("DAY 2 PART 2 SUM: " + verticalPos * horizontalPos);
    }
}
