using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    [SerializeField]
    private string summary;
    [SerializeField]
    private ProductionStats stats;
    [SerializeField]
    private Cartridge cartridge;

    private bool complete = false;

    public Cartridge Cartridge
    {
        get { return cartridge; }
        set { cartridge = value; }
    }

}
