using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int health = 5;
    string name;

    // Start is called before the first frame update
    void Start()
    {
        int saved_health = PlayerPrefs.GetInt("health");
        if (saved_health > 0)
        {
            health = saved_health;
        }

        string saved_name = PlayerPrefs.GetString("name");
        if (saved_name.Length > 0)
        {
            name = saved_name;
        }
        //Debug.Log(name);
    }

    private void OnDestroy()
    {
      
        PlayerPrefs.SetInt("health", health);

        PlayerPrefs.SetString("name", name);
    }
}