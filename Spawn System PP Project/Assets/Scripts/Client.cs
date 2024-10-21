using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class Client : MonoBehaviour
{
    public string Mark;
    public string Element;
    public string Size;
    //public bool Cargo;

    public TextMeshProUGUI Output;

    //public Toggle EngineToggle;
    //public Toggle CargoToggle;

    public TMP_Dropdown DragonElement;
    public TMP_Dropdown DragonMark;
    public TMP_Dropdown DragonSize;

    public GameObject Fire01;
    public GameObject Fire02;
    public GameObject Fire03;

    public GameObject Ice01;
    public GameObject Ice02;
    public GameObject Ice03;

    public GameObject Lightning01;
    public GameObject Lightning02;
    public GameObject Lightning03;

    //public TMP_InputField WheelAmount;
    //public TMP_InputField LegAmount;

    public void Create()
    {
        //NumberOfWings = int.Parse(WheelAmount.text);
        //NumberOfLegs = int.Parse(LegAmount.text);

        //NumberOfWings = Mathf.Max(NumberOfWings, 1);
        //NumberOfLegs = Mathf.Max(NumberOfLegs, 1);

        //Engine = Cargo;

        //EngineToggle.isOn = Cargo;

        VehicleRequirements requirements = new VehicleRequirements();
        requirements.Mark = Mark;
        requirements.Element = Element;
        requirements.Size = Size;

        IDragon v = GetVehicle(requirements);
        
        GameObject Egg = Instantiate(v);

        Output.text = v.ToString();
        //Debug.Log(v);

        //Debug.Log("Element = " + Element);
        //Debug.Log("Wings = " + NumberOfWings);
        //Debug.Log("Legs = " + NumberOfLegs);
    }

    public void ChangeElement()
    {
        //Element = DragonElement.options[DragonElement.value].text;
        switch (DragonElement.value)
        {
            case 0:
                Element = "Fire";
                break;
            case 1:
                Element = "Ice";
                break;
            case 2:
                Element = "Lightning";
                break;
        }
    }

    public void ChangeMark()
    {
        //Element = DragonElement.options[DragonElement.value].text;
        switch (DragonMark.value)
        {
            case 0:
                Mark = "Circle";
                break;
            case 1:
                Mark = "Square";
                break;
            case 2:
                Mark = "Triangle";
                break;
        }
    }

    public void ChangeSize()
    {
        //Element = DragonElement.options[DragonElement.value].text;
        switch (DragonSize.value)
        {
            case 0:
                Element = "S";
                break;
            case 1:
                Element = "M";
                break;
            case 2:
                Element = "L";
                break;
        }
    }

    private static IDragon GetVehicle(VehicleRequirements requirements)
    {
        VehicleFactory factory = new VehicleFactory(requirements);
        return factory.Create();
    }

    /*
    void Start()
    {
        NumberOfWings = Mathf.Max(NumberOfWings, 1);
        NumberOfLegs = Mathf.Max(NumberOfLegs, 1);
        
        //Engine = Cargo;

        VehicleRequirements requirements = new VehicleRequirements();
        requirements.NumberOfWings = NumberOfWings;
        requirements.Element = Element;
        requirements.NumberOfLegs = NumberOfLegs;

        IVehicle v = GetVehicle(requirements);
        Output.text = v.ToString();

        Debug.Log(v);
    }
    */



    /*
    public void ToggleChangeEngine(bool tickOn)
    {
        if (tickOn)
            Element = true; 
        else 
            Element = false;
    }

    public void ToggleChangeCargo(bool tickOn)
    {
        if (tickOn)
            Cargo = true;
        else
            Cargo = false;
    }
    */
}
