using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class win : MonoBehaviour
{
    public Text winText;
    public GameObject board;
    public MeshRenderer ball;
    public MeshRenderer quad;
    public MeshRenderer [] boardPieces;
    
    // Start is called before the first frame update
    void Start()
    {
        boardPieces = board.GetComponentsInChildren<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnTriggerEnter(Collider c){
        winText.enabled = true;
        foreach(MeshRenderer m in boardPieces){
            m.enabled = false;
        }
        ball.enabled = false;
        quad.enabled = false;
    }
}
