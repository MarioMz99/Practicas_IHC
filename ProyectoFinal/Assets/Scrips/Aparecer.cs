using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparecer : MonoBehaviour
{
    // Start is called before the first frame update
    public string LavaCommand = "lava";
    public string DirtCommand = "tierra";
    public string DiamondCommand = "diamante";
    public string MaderaCommand = "madera";
    public string AguaCommand = "agua";
    public string CasaCommand = "casa";
    public string DisappearCommand = "destruir";

    
    private float pos1 = 1.0f;
    private float pos2 = 1.0f;
    private float pos3 = 1.0f;
    private float pos4 = 1.0f;
    private float pos5 = 1.0f;
    private float pos6 = -1.0f;

    public GameObject cubolava;
    public GameObject cubotierra;
    public GameObject cubodiamante;
    public GameObject cubomadera;
    public GameObject cuboagua;
    public GameObject[] cubo = new GameObject[1];
    private GameObject[] cube = new GameObject[1];

    public GameObject sonidoAgua;
    public GameObject sonidoLava;
    public GameObject sonidoMadera;

    private void Awake()
    {
        cubo = GameObject.FindGameObjectsWithTag("cubos");//GetComponent<GameObject>();
    }

    void Start()
    {
        VoiceCommandManager.Instance.RegisterCommand(LavaCommand, appearCubeLava);
        VoiceCommandManager.Instance.RegisterCommand(DirtCommand, appearCubeTierra);
        VoiceCommandManager.Instance.RegisterCommand(DiamondCommand, appearCubeDiamante);
        VoiceCommandManager.Instance.RegisterCommand(MaderaCommand, appearCubeMadera);
        VoiceCommandManager.Instance.RegisterCommand(AguaCommand, appearCubeAgua);
        VoiceCommandManager.Instance.RegisterCommand(CasaCommand, appearCubeCasa);
        VoiceCommandManager.Instance.RegisterCommand(DisappearCommand, disappearCube);
    }

    private void appearCubeLava()
    {   
        Instantiate(sonidoLava);
        cube[0] = Instantiate(cubolava);
        cube[0].transform.position = new Vector3(-0.5f, -1+pos2, 0.5f);
        pos1 += 0.5f;
    }
    private void appearCubeTierra()
    {   
        cube[0] = Instantiate(cubotierra);
        cube[0].transform.position = new Vector3(-0.5f, -1+pos1, 0);
        pos2+= 0.5f;
    }
    private void appearCubeDiamante()
    {   
        cube[0] = Instantiate(cubodiamante);
        cube[0].transform.position = new Vector3(-0.5f, -1+pos3, 1);
        pos3+=0.5f;
    }
    private void appearCubeMadera()
    {   
        Instantiate(sonidoMadera);
        cube[0] = Instantiate(cubomadera);
        cube[0].transform.position = new Vector3(-0.5f, -1+pos4, 1.5f);
        pos4+=0.5f;
    }
    private void appearCubeAgua(){
        Instantiate(sonidoAgua);
        cube[0] = Instantiate(cuboagua);
        cube[0].transform.position = new Vector3(-0.5f, -1+pos5, 2);
        pos5+=0.5f;
    }
    private void appearCubeCasa(){
        float x=0;
        float y=-1; 
        float z=2;
        Instantiate(sonidoMadera);
        for (int i = 0; i < 3; i++)
        {
            cube[0] = Instantiate(cubomadera);
            cube[0].transform.position = new Vector3(x,y,z);
            for (int j = 0; j < 2; j++)
            {
                y+=0.5f;
                cube[0] = Instantiate(cubomadera);
                cube[0].transform.position = new Vector3(x,y,z);
                
            }
            for (int k = 0; k < 3; k++)
            {
                z+=0.5f;
                cube[0] = Instantiate(cubomadera);
                cube[0].transform.position = new Vector3(x,y,z);
            }
            x+=0.5f;
            y=-1;
            
        }
        cube[0] = Instantiate(cubomadera);
            cube[0].transform.position = new Vector3(-0.5f,-1,2);
        cube[0] = Instantiate(cubomadera);
            cube[0].transform.position = new Vector3(-0.5f,-0.5f,2);
        x=-1;
        y=-1; 
        z=2;
        Instantiate(sonidoMadera);
        for (int i = 0; i < 3; i++)
        {
            cube[0] = Instantiate(cubomadera);
            cube[0].transform.position = new Vector3(x,y,z);
            for (int j = 0; j < 2; j++)
            {
                y+=0.5f;
                cube[0] = Instantiate(cubomadera);
                cube[0].transform.position = new Vector3(x,y,z);                
            }
            for (int j = 0; j < 2; j++)
            {
                z+=0.5f;
                cube[0] = Instantiate(cubomadera);
                cube[0].transform.position = new Vector3(x,y,z);                
            }
            x-=0.5f;
            y=-1;
            
        }
    }
    private void disappearCube(){
        Destroy(cube[0]);

        pos1-=0.5f;
        pos2-=0.5f;
        pos3-=0.5f;
        pos4-=0.5f;
        pos5-=0.5f;
    }
}   