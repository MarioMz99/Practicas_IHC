using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desaparecer : MonoBehaviour
{
    // Start is called before the first frame update
    public string turnOnCommand = "día";
    public string turnOffCommand = "noche";

    private GameObject[] cube = new GameObject[1];
    private int cubesNum = 0;

    private void Awake()
    {
        cube = GameObject.FindGameObjectsWithTag("Cielo");//GetComponent<GameObject>();
    }

    void Start()
    {
        VoiceCommandManager.Instance.RegisterCommand(turnOnCommand, SwitchLightOn);
        VoiceCommandManager.Instance.RegisterCommand(turnOffCommand, SwitchLightOff);
    }

    private void SwitchLightOn()
    {   
        cube[0].transform.position = new Vector3(10, 0.5f, 0);
    }

    private void SwitchLightOff()
    {
        cube[0].transform.position = new Vector3(-10, 0.5f, 0);
}
}   