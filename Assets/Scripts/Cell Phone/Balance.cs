using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balance : MonoBehaviour
{
    //计算余额
    public Text balance;
    public int LifeMax;

    void Update()
    {
        //BalanceManager.Life = Mathf.Clamp(BalanceManager.Life, 0, LifeMax);
        balance.text =  ""+BalanceManager.Life;
    }
}
