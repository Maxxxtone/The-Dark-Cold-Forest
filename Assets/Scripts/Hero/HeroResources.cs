using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroResources : MonoBehaviour
{
    public static HeroResources resources;
    [SerializeField] private Text moneyText=null, woodText=null, rockText=null;
    private int _money, _timber, _rock;
    private void Awake()
    {
        resources = this;
    }
    private void UpdateUI()
    {
        moneyText.text = _money.ToString();
        woodText.text = _timber.ToString();
        rockText.text = _rock.ToString();
    }
    public void UpdateResources(int money, int timber, int rock)
    {
        _money += money;
        _timber += timber;
        _rock += rock;
        UpdateUI();
    }
    public void ConvertResourcesToMoney()
    {
        _money += _timber;
        _money += _rock * 2;
        _timber = 0;
        _rock = 0;
        UpdateUI();
    }
    public void ResetResources()
    {
        _money = 0;
        _timber = 0;
        _rock = 0;
        UpdateUI();
    }
}
