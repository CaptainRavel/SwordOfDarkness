using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    private int primAtributtesPoints;
    private int secAtributtesPoints;
    private int vitalPoints;
    private int gardeValue;
    private int counterValue;
    private int baseAttack;
    private int level;



    public int HealthPoints
    {
        get { return vitalPoints; }
        set { vitalPoints = value; }
    }
    public int PrimAtrributePoints
    {
        get { return primAtributtesPoints; }
        set { primAtributtesPoints = value; }
    }
    public int SecAtrributePoints
    {
        get { return secAtributtesPoints; }
        set { secAtributtesPoints = value; }
    }
    public int VitalPoints
    {
        get { return vitalPoints; }
        set { vitalPoints = value; }
    }
    public int GardeValue
    {
        get { return gardeValue; }
        set { gardeValue = value; }
    }
    public int CounterValue
    {
        get { return counterValue; }
        set { counterValue = value; }
    }
    public int Level
    {
        get { return level; }
        set { level = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
