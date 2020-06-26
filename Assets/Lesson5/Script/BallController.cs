using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;
    int Score = 0;
    private GameObject scoreText;
    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        
        this.scoreText.GetComponent<Text>().text = "Score" + Score;
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {

            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="SmallStarTag")
        {
            Score += 5;
        }
        else if (other.gameObject.tag=="LargeStarTag")
        {
            Score += 3;
        }
        else if(other.gameObject.tag == "SmallCloudTag")
        {
            Score += 8;
        }else if(other.gameObject.tag == "LargeCloudTag")
        {
            Score += 10;
        }

      

    }
}