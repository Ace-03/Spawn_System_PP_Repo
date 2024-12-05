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

    public TextMeshProUGUI Output;

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

    public GameObject dra;
    public void Create()
    {
        DragonRequirements requirements = new DragonRequirements();
        requirements.Mark = Mark;
        requirements.Element = Element;
        requirements.Size = Size;

        IDragon v = GetDragon(requirements);

        Egg(v);
    }

    public void ChangeElement()
    {
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
        switch (DragonMark.value)
        {
            case 0:
                Mark = "Type1";
                break;
            case 1:
                Mark = "Type2";
                break;
            case 2:
                Mark = "Type3";
                break;
        }
    }

    public void ChangeSize()
    {
        switch (DragonSize.value)
        {
            case 0:
                Size = "S";
                break;
            case 1:
                Size = "M";
                break;
            case 2:
                Size = "L";
                break;
        }
    }

    private static IDragon GetDragon(DragonRequirements requirements)
    {
        DragonFactory factory = new DragonFactory(requirements);
        return factory.Create();
    }

    private void Egg(IDragon v)
    {
        dra = Instantiate(Resources.Load(v.ToString()) as GameObject);
        dra.AddComponent<CapsuleCollider>();
        Rigidbody rb = dra.AddComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;

        switch (Size)
        {
            case "S":
                dra.transform.localScale *= 0.5f;
                break;
            case "M":
                dra.transform.localScale *= 1;
                break;
            case "L":
                dra.transform.localScale *= 2;
                break;
        }
    }
}
