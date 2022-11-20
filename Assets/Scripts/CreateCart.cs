using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class CreateCart : MonoBehaviour
{
    [SerializeField] private GameObject _panel,_content;
    [SerializeField] private JSONController _jsonController;
    [SerializeField] private List<TextMeshProUGUI> _text;
    private GameObject _button;

    private void Start()
    {
        _button = Resources.Load<GameObject>("Materials/Button");
        CreateButton();
    }
    
    private void Update()
    {
        if (_content.transform.position.y < 5)
        {
            _content.transform.position = new Vector3(_content.transform.position.x,5,_content.transform.position.z);
        }
    }

    private void CreateButton()
    {
        for (int i = 0; i < _jsonController.SettingInformations.Count; i++)
        {
            var game = Instantiate(_button,_content.transform);
            if (i != 0)
            {
                game.transform.position = new Vector3(game.transform.position.x,game.transform.position.y - i,0);
            }
            game.GetComponentInChildren<TextMeshProUGUI>().text = _jsonController.SettingInformations[i].first_name +
                                                                  " " + _jsonController.SettingInformations[i]
                                                                      .last_name;
            var click = game.GetComponent<ButtonClick>();
            click.GameObject = _panel;
            click.SettingInformation = _jsonController.SettingInformations[i];
            for (int j = 0; j < _text.Count; j++)
            {
                click.Texts.Add(_text[j]);
            }
        }
    }
}
