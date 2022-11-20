using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
public class JSONController : MonoBehaviour
{
    public List<SettingInformation> SettingInformations;
    private void Awake()
    {
        var q = Resources.Load<TextAsset>("JSON/test_data");
        SettingInformations = JsonConvert.DeserializeObject<List<SettingInformation>>(q.text);
    }
}
[Serializable]
public class SettingInformation
{
    public int id;
    public string first_name;
    public string last_name;
    public string email;
    public string gender;
    public string ip_address;
    public string address;
}
