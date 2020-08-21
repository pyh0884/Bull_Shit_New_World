using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cost : MonoBehaviour
{
    //没啥说的，直接调用EndCost（int 要花的钱的数量）就行了。
    public int cost;

    public void EndCost(int c)
    {
        //gameobject.anim.settrigger("cost");
        BalanceManager.Life -= c;
    }
}
