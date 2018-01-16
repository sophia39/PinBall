using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    int point; //スコアポイント
    int smallstirpoint;
    int largestirpoint;
    int smallcloudpoint;
    int largecloudpoint;

    //スコアを表示するテキスト
    private GameObject scoreText;

    // Use this for initialization
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
        //スコアを表示
        this.scoreText.GetComponent<Text>().text = "Score:" + point;
    }
    // Update is called once per frame
    void Update()
    {

    }
    //衝突に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        // タグによってスコアを変える
        if (other.gameObject.tag == "SmallStarTag")
        {
            smallstirpoint += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            largestirpoint += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            smallcloudpoint += 30;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            largecloudpoint += 40;
        }
        //スコア計算
        point = smallstirpoint + largestirpoint + smallcloudpoint + largecloudpoint;
        //スコアを表示
        this.scoreText.GetComponent<Text>().text = "Score:" + point;

    }
}