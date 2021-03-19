using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game_Master : MonoBehaviour {
    // Start is called before the first frame update
    public int blocknum;
    public float nowTime;
    void Start() {
        nowTime = 0;
        blocknum = GameObject.FindGameObjectsWithTag("block").Length;
    }

    // Update is called once per frame
    void Update() {
        nowTime += Time.deltaTime;
        if (blocknum <= 0) {
            GameOver(nowTime.ToString("F0") + "秒でクリアできた!");
        }
    }
    public void GameOver(string resultMessage) {
        DataSender.resultMessage = resultMessage;
        SceneManager.LoadScene("Result");
    }

}
