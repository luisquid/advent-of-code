using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace luisquid
{
    public class Day3Code : MonoBehaviour
    {
        public TextAsset day3Input;
        public string[] day3Array;
        public List<string> tempInput;
        public List<string> currentInput;
        public List<string> positive;
        public List<string> negative;
        
        public int currentIndex = 0;

        // Start is called before the first frame update
        void Start()
        {
            day3Array = day3Input.text.Split('\n');
            
            tempInput = new List<string>();
            currentInput = new List<string>();
            positive = new List<string>();
            negative = new List<string>();

            //We add the values to the current list
            for (int i = 0; i < day3Array.Length; i++)
            {
                currentInput.Add(day3Array[i]);
                tempInput.Add(day3Array[i]);
            }

            Day3Part2();
        }

        public void Day3Part2()
        {
            tempInput.Clear();
            positive.Clear();
            negative.Clear();

            for (int i = 0; i < currentInput.Count; i++)
            {
                if (currentInput[i][currentIndex] == '1')
                {
                    positive.Add(currentInput[i]);
                }

                else
                {
                    negative.Add(currentInput[i]);
                }              
            }

            //CO2
            //tempInput = (positive.Count < negative.Count) ?  positive : negative;

            //OXYGEN
            tempInput = (positive.Count < negative.Count) ? negative : positive;

            if(tempInput.Count > 1)
            {
                currentIndex++;
                currentInput.Clear();
                for (int i = 0; i < tempInput.Count; i++)
                    currentInput.Add(tempInput[i]);

                //currentInput = tempInput;
                Debug.Log("SHOOT ME AGAIN");
                //Day3Part2();
            }
            else
            {               
                Debug.Log(tempInput[0]);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Day3Part2();
            }
        }
    }
}
