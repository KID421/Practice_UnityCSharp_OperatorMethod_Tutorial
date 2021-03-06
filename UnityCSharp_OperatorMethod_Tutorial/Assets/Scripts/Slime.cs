﻿using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{
    [Header("顯示訊息")]
    public Text message;
    [Header("蝙蝠")]
    public Bat bat;

    private float hp = 200;
    private float atk = 20;
    private float cure = 10;

    /// <summary>
    /// 攻擊
    /// </summary>
    public void Attack()
    {
        bat.Damage(atk);
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">要接收的傷害值</param>
    public void Damage(float damage)
    {
        hp -= damage; // hp = hp - damage;
        message.text = "<color=#7B8610>" + gameObject.name + "</color> - 受到傷害：" + damage;
        message.text += "\n<color=#7B8610>" + gameObject.name + "</color> - 血量剩下：" + hp;
    }

    /// <summary>
    /// 治癒
    /// </summary>
    public void Cure()
    {
        hp += cure;
        message.text = "<color=#7B8610>" + gameObject.name + "</color> - 受到治癒：" + cure;
        message.text += "\n<color=#7B8610>" + gameObject.name + "</color> - 血量剩下：" + hp;
    }
}
