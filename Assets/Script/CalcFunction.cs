using System;
using TMPro;
using UnityEngine;

public class CalcFunction : MonoBehaviour
{
    private int ops;

    private float num1;
    private float num2;
    public float answer;

    private bool isOperatorActive;
    private bool isDecimalAlready;

    public TextMeshProUGUI firstDisplay;
    public TextMeshProUGUI secondDisplay;

    // Start is called before the first frame update
    void Start()
    {
        firstDisplay.text = "0";
        isDecimalAlready = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //populates firstDisplay
    public void UpdateDisplayText(string newText)
    {
        firstDisplay.text += newText;
    }

    public void Answer()
    {
        //display answer on second textmeshpro
        secondDisplay.text = answer.ToString();
    }

    //onClickEvents
    public void One()
    {
       
        if (firstDisplay.text.Length <= 10)
        {
            if (firstDisplay.text.Length == 1)
            {
                firstDisplay.text = "";

            }

            UpdateDisplayText("1");
        }

        else
            return;

        if (!isOperatorActive) 
        {
            num1 = float.Parse(firstDisplay.text);
        }

        else
        {
            num2 = float.Parse(firstDisplay.text);
        }
        
    }

    public void Two()
    {
        if (firstDisplay.text.Length >= 1 && firstDisplay.text.Length <= 10)
        {
            if (firstDisplay.text.Length == 1)
            {
                firstDisplay.text = "";
            }

            UpdateDisplayText("2");
        }

        else
            return;

        if (!isOperatorActive)
        {
            num1 = float.Parse(firstDisplay.text);
        }

        else
        {
            num2 = float.Parse(firstDisplay.text);
        }
    }

    public void Three()
    {
        if (firstDisplay.text.Length >= 1 && firstDisplay.text.Length <= 10)
        {
            if (firstDisplay.text.Length == 1)
            {
                firstDisplay.text = "";
            }

            UpdateDisplayText("3");
        }

        else
            return;

        if (!isOperatorActive)
        {
            num1 = float.Parse(firstDisplay.text);
        }

        else
        {
            num2 = float.Parse(firstDisplay.text);
        }
    }

    public void Four()
    {
        if (firstDisplay.text.Length >= 1 && firstDisplay.text.Length <= 10)
        {
            if (firstDisplay.text.Length == 1)
            {
                firstDisplay.text = "";
            }

            UpdateDisplayText("4");
        }

        else
            return;

        if (!isOperatorActive)
        {
            num1 = float.Parse(firstDisplay.text);
        }

        else
        {
            num2 = float.Parse(firstDisplay.text);
        }
    }

    public void Five()
    {
        if (firstDisplay.text.Length >= 1 && firstDisplay.text.Length <= 10)
        {
            if (firstDisplay.text.Length == 1)
            {
                firstDisplay.text = "";
            }

            UpdateDisplayText("5");
        }

        else
            return;

        if (!isOperatorActive)
        {
            num1 = float.Parse(firstDisplay.text);
        }

        else
        {
            num2 = float.Parse(firstDisplay.text);
        }
    }

    public void Six()
    {
        if (firstDisplay.text.Length >= 1 && firstDisplay.text.Length <= 10)
        {
            if (firstDisplay.text.Length == 1)
            {
                firstDisplay.text = "";
            }

            UpdateDisplayText("6");
        }

        else
            return;

        if (!isOperatorActive)
        {
            num1 = float.Parse(firstDisplay.text);
        }

        else
        {
            num2 = float.Parse(firstDisplay.text);
        }
    }

    public void Seven()
    {
        if (firstDisplay.text.Length >= 1 && firstDisplay.text.Length <= 10)
        {
            if (firstDisplay.text.Length == 1)
            {
                firstDisplay.text = "";
            }

            UpdateDisplayText("7");
        }

        else
            return;

        if (!isOperatorActive)
        {
            num1 = float.Parse(firstDisplay.text);
        }

        else
        {
            num2 = float.Parse(firstDisplay.text);
        }
    }

    public void Eight()
    {
        if (firstDisplay.text.Length >= 1 && firstDisplay.text.Length <= 10)
        {
            if (firstDisplay.text.Length == 1)
            {
                firstDisplay.text = "";
            }

            UpdateDisplayText("8");
        }

        else
            return;

        if (!isOperatorActive)
        {
            num1 = float.Parse(firstDisplay.text);
        }

        else
        {
            num2 = float.Parse(firstDisplay.text);
        }
    }

    public void Nine()
    {
        if (firstDisplay.text.Length >= 1 && firstDisplay.text.Length <= 10)
        {
            if (firstDisplay.text.Length == 1)
            {
                firstDisplay.text = "";
            }

            UpdateDisplayText("9");
        }

        else
            return;

        if (!isOperatorActive)
        {
            num1 = float.Parse(firstDisplay.text);
        }

        else
        {
            num2 = float.Parse(firstDisplay.text);
        }
    }

    public void Zero()
    {
        if (firstDisplay.text.Length >= 1 && firstDisplay.text.Length <= 10)
        {
            if (firstDisplay.text.Length == 1)
            {
                firstDisplay.text = "";
            }

            UpdateDisplayText("0");
        }

        else
            return;

        if (!isOperatorActive)
        {
            num1 = float.Parse(firstDisplay.text);
        }

        else
        {
            num2 = float.Parse(firstDisplay.text);
        }
    }

    public void DecimalPoint()
    {
        // to prevent more than one decimal points
        if (!isDecimalAlready)
        {
            firstDisplay.text = ".";
            isDecimalAlready = true;
        }
    }

    //Operators
    public void Multiplication()
    {
        isOperatorActive = true;
        firstDisplay.text = "*";
        ops = 0;
    }

    public void Division()
    {
        isOperatorActive = true;
        firstDisplay.text = "/";
        ops = 1;
    }

    public void Addition()
    {
        isOperatorActive = true;
        firstDisplay.text = "+";
        ops = 2;
    }

    public void Substraction()
    {
        isOperatorActive = true;
        firstDisplay.text = "-";
        ops = 3;
    }

    public void Percentage()
    {
        isOperatorActive = true;
        firstDisplay.text = "%";
        ops = 4;
    }

    public void Clear()
    {
        firstDisplay.text = "0";
        secondDisplay.text = "";
        isDecimalAlready = false;
    }

    public void Negetion()
    {
        //negate value of num1
    }

    public void Equalto()
    {
        Commute(ops);
        Answer();
        isOperatorActive = false;
        Debug.Log("Done");
    }


    public void Commute(int operation)
    {
        switch (operation)
        {
            case 0:
                answer = num1 * float.Parse(firstDisplay.text);
                break;

            case 1:
                answer = num1 / float.Parse(firstDisplay.text);
                break;

            case 2:
                answer = num1 + float.Parse(firstDisplay.text);
                break;

            case 3:
                answer = num1 - float.Parse(firstDisplay.text);
                break;

            case 4:
                answer = float.Parse(firstDisplay.text) * 100 / num1;
                break;

        }
    }

}
