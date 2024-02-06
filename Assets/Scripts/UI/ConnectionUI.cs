using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectionUI : MonoBehaviour
{
    [SerializeField] private Button connectHostButton;
    [SerializeField] private Button connectClientButton;

    private void Awake()
    {

    }

    void Show()
    {
        gameObject.SetActive(false);
    }

    void Hide()
    {
        gameObject.SetActive(false);
    }
}
