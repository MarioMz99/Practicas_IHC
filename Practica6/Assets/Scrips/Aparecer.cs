using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparecer : MonoBehaviour
{
    // Start is called before the first frame update
    public string LavaCommand = "lava";
    public string DirtCommand = "tierra";
    public string DiamondCommand = "diamante";
    public string DisappearCommand = "destruir";

    
    private float pos = 1.0f;
    public GameObject cubolava;
    public GameObject cubotierra;
    public GameObject cubodiamante;
    public GameObject[] cubo = new GameObject[1];
    private GameObject[] cube = new GameObject[1];

    private void Awake()
    {
        cubo = GameObject.FindGameObjectsWithTag("Cubos");//GetComponent<GameObject>();
    }

    void Start()
    {
        VoiceCommandManager.Instance.RegisterCommand(LavaCommand, appearCubeLava);
        VoiceCommandManager.Instance.RegisterCommand(DirtCommand, appearCubeTierra);
        VoiceCommandManager.Instance.RegisterCommand(DiamondCommand, appearCubeDiamante);
        VoiceCommandManager.Instance.RegisterCommand(DisappearCommand, disappearCube);
    }

    private void appearCubeLava()
    {   
        cube[0] = Instantiate(cubolava);
        cube[0].transform.position = new Vector3(0, 0.5f+pos, 0);
        pos++;
    }
    private void appearCubeTierra()
    {   
        cube[0] = Instantiate(cubotierra);
        cube[0].transform.position = new Vector3(1, 0.5f+pos, 0);
        pos++;
    }
    private void appearCubeDiamante()
    {   
        cube[0] = Instantiate(cubodiamante);
        cube[0].transform.position = new Vector3(2, 0.5f+pos, 0);
        pos++;
    }
    private void disappearCube(){
        Destroy(cube[0]);

        pos--;
    }
}   