using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    [SerializeField] int TresuresCounter;

    public void GemAdd(Treasures Spoils)
    {
        TresuresCounter+=Spoils.value;
        
        Debug.Log($"Treasures collected:{" "+TresuresCounter}");
    }

    
}
