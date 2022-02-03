using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int money = 100;
    public text MoneyText;
    public Text inventory;

    public void addItem(string item)
    {
        MoneyText.text = money.ToString();
        inventory.text += "\n" + item;
    }
}
