using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class ButtonColor : MonoBehaviour
{
    public GameObject Gd;
    public Button bt;
    public Color cl;
    
    public string data;

    void Start()
    {
        data = File.ReadAllText("Save/" + gameObject.GetInstanceID() + ".txt");
        JsonUtility.FromJsonOverwrite(data, this);
        SetCol();
    }

    void Update()
    {
        if (Gd.GetComponent<Renderer>().material.color == Color.white)
        {
            bt.GetComponentInChildren<Text>().text = "White";
        }
        else
        {
            bt.GetComponentInChildren<Text>().text = "Blue";
        }
    }

    public void ColorAndText()
    {
        if (Gd.GetComponent<Renderer>().material.color != Color.blue)
        {
            Gd.GetComponent<Renderer>().material.color = Color.blue;
        }
        else
        {
            Gd.GetComponent<Renderer>().material.color = Color.white;
        }
    }


    public void Coll()
    {
        cl = Gd.GetComponent<Renderer>().material.color;
    }

    public void SetCol()
    {
        Gd.GetComponent<Renderer>().material.color = cl;
    }

    void OnApplicationQuit()
    {
        Coll();
        data = JsonUtility.ToJson(this, true);
        File.WriteAllText("Save/" + gameObject.GetInstanceID() + ".txt", data);

    }

}

