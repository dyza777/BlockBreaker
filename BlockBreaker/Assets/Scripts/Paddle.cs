using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] int worldWidth;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(GetXPos(), minX, maxX);
        transform.position = paddlePos;
    }

    private float GetXPos()
    {
        if (FindObjectOfType<GameStatus>().IsAutoplayEnabled())
        {
            return FindObjectOfType<Ball>().transform.position.x;
        } else
        {
            return Input.mousePosition.x / Screen.width * worldWidth;
        }
    }
}
