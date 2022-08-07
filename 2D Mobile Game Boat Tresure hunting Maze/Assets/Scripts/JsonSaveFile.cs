

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class PaymentData
{
    public string id_card;
    public int expiry_month;
    public int expiry_year;
    public int security_ccv;

}

[System.Serializable]
public class PlayerData
{
    public int health;
    public string name;
    public int GemCounter;
    public Vector3 position;
    public PaymentData PaymentData;

}

public class JsonSaveFile : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //crating data class instance
        PlayerData myPlayerData = new PlayerData();
        myPlayerData.health = 1;
        myPlayerData.name = "Shiply";
        myPlayerData.GemCounter = 0;
        myPlayerData.position = transform.position;
        myPlayerData.PaymentData = new PaymentData();
        myPlayerData.PaymentData.id_card = "4234234234234";
        myPlayerData.PaymentData.expiry_month = 12;
        myPlayerData.PaymentData.expiry_year = 26;
        myPlayerData.PaymentData.security_ccv = 124;

        //now, let's serialize, and turn the object into json string
        string json = JsonUtility.ToJson(myPlayerData);
        //Debug.Log(json);

        Debug.Log(Application.persistentDataPath);
        File.WriteAllText(Application.persistentDataPath + @"\json.txt", json);

        //read data from json and deserialize it (trun it into a string)
        //string json_from_file = File.ReadAllText(Application.persistentDataPath + @"\json.txt");

        //PlayerData from_Json_player_data = JsonUtility.FromJson<PlayerData>(json_from_file);
        //Debug.Log(from_Json_player_data.XP);
    }
}