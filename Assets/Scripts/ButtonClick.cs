using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class ButtonClick : MonoBehaviour, IPointerClickHandler
{
    public SettingInformation SettingInformation;
    public GameObject GameObject;
    public List<TextMeshProUGUI> Texts = new List<TextMeshProUGUI>();
    [SerializeField] private UnityEngine.UI.Button _button;

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject.SetActive(true);
        for (int i = 0; i < Texts.Count; i++)
        {
            switch (Texts[i].name)
            {
                case "id":
                    Texts[i].text = SettingInformation.id.ToString();
                    break;
                case "name":
                    Texts[i].text =  SettingInformation.first_name + " " + SettingInformation.last_name;
                    break;
                case "gender":
                    Texts[i].text = SettingInformation.gender;
                    break;
                case "adress":
                    Texts[i].text = SettingInformation.address;
                    break;
                case "ip":
                    Texts[i].text = SettingInformation.ip_address;
                    break;
                case "email":
                    Texts[i].text = SettingInformation.email;
                    break;
            }
        }
    }
}
