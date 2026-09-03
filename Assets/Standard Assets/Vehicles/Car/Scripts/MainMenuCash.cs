using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuCash : MonoBehaviour
{
    public Text CashText;
    public GameObject StatsPanel;
    void Start()
    {
        StartCoroutine(WaitForSec());
        Time.timeScale = 1;
       
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(0.2f);
        CashText.text = UniversalSave.CashAmount.ToString();
    }
    public void SwitchStatsPanelOn()
    {
        StatsPanel.SetActive(true);
    }
}
