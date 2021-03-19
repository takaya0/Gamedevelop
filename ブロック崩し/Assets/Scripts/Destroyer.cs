using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject gameObj;
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnCollisionEnter(Collision collision) {
        gameObj.GetComponent<Game_Master>().blocknum--;
        Destroy(gameObject);
    }
}
