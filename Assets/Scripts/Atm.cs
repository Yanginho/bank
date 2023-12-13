using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Atm : MonoBehaviour
{
    public GameObject depositMenu;
    public GameObject withdrawMenu;
    public GameObject startMenu;
    public GameObject popup;
    public Text CashTxt;
    public Text BalanceText;
    public int balance=50000;
    public int cash = 100000;

    public void Deposit(int money)
    {
        if (cash > money) 
        {
            balance += money;
            cash -= money;
        }
        else if(cash < money)
        {
            popup.SetActive(true);
        }
    }

    public void Withdraw(int money)
    {
        if(balance > money)
        {
            balance -= money;
            cash += money;
        }
        else
        {
            popup.SetActive(true);
        }
    }

    
}
