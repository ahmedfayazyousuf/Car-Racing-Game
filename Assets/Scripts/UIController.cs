using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject[] uI;
    void Start()
    {
        HideUI();
        uI[0].SetActive(true);
    }
    public void HideUI()
    {
        for (int i = 0; i < uI.Length; i++)
        {
            uI[i].SetActive(false);
        }
    }
    public void ShowUI(int uIIndex)
    {
        HideUI();
        uI[uIIndex].SetActive(true);
    }
}
