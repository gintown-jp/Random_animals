using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animalNameM : MonoBehaviour
{
    //動物の種類
    string[] type = new string[]
    {
        "犬",
        "猫",
        "牛",
        "馬"
    };

    //形容詞
    string[] adjective = new string[]
    {
        "かしこい",
        "大きい",
        "小さい",
        "心配性な",
        "金持ちな",
        "美味しい",
        "人見知りな"
    };


    void Start()
    {
        NameSelect(adjective, type);
    }

    public void NameSelect(string[] leftText,string[] rightText)
    {
        string animalName = null;
        System.Random r = new System.Random();

        //乱数で配列を決定
        var left = leftText[r.Next(0, leftText.Length)];
        var right = rightText[r.Next(0, rightText.Length)];

        //結合
        animalName = $"{left}{right}";

        //表示
        this.GetComponent<Text>().text = animalName;
    }

}
