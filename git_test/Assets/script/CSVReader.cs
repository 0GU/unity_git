using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVReader : MonoBehaviour
{

    TextAsset csvFile; // CSVファイル
    public int height; // CSVの行数
    List<string[]> csvDatas = new List<string[]>(); // CSVの中身を入れるリスト;
    public GameObject objG;
    public GameObject objB;
    public GameObject objY;
    public GameObject objSB;
    public GameObject objR;

    void Start()
    {
        csvFile = Resources.Load("STAGE1") as TextAsset; // Resouces下のCSV読み込み
        StringReader reader = new StringReader(csvFile.text);

        // , で分割しつつ一行ずつ読み込み
        // リストに追加していく
        while (reader.Peek() > -1) // reader.Peaekが0になるまで繰り返す
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
            height++; // 行数加算
        }

        // csvDatas[行][列]を指定して値を自由に取り出せる
        for (int h = 0; h <= height; h += 21)
        {
            for (int i = 0; i < 20; i++)//縦
            {
                for (int j = 0; j < 20; j++)//横
                {
                    switch (csvDatas[i + h][j])
                    {

                        case "1":
                            //Instantiate(生成したいGameObject, 位置, 姿勢);
                            Instantiate(objG, new Vector3(i, (i + h) / 21, j), Quaternion.identity);
                            break;
                        case "2":
                            //Instantiate(生成したいGameObject, 位置, 姿勢);
                            Instantiate(objB, new Vector3(i, (i + h) / 21, j), Quaternion.identity);
                            break;
                        case "3":
                            //Instantiate(生成したいGameObject, 位置, 姿勢);
                            Instantiate(objY, new Vector3(i, (i + h) / 21, j), Quaternion.identity);
                            break;
                        case "4":
                            //Instantiate(生成したいGameObject, 位置, 姿勢);
                            Instantiate(objSB, new Vector3(i, (i + h) / 21, j), Quaternion.identity);
                            break;
                        case "5":
                            //Instantiate(生成したいGameObject, 位置, 姿勢);
                            Instantiate(objR, new Vector3(i, (i + h) / 21, j), Quaternion.identity);
                            break;
                        default:
                            break;

                    }


                }


            }

        }
    }
}
    // 疑問
    // TextAssetはナニモン？
    // StringReaderはナニモン？
    // わざわざリストに入れてるけどTextAssetのままでは使えないの？


