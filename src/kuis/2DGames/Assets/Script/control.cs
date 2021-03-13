using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public float berat,tinggiLompat;
    public GameObject bird,instruction,pipeCopy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        if (Time.timeScale == 1)
        {
            pipeCopy.SetActive(true);
            instruction.SetActive(false);
            bird.GetComponent<Rigidbody2D>().gravityScale = berat;
            bird.GetComponent<Rigidbody2D>().velocity = new Vector2(bird.GetComponent<Rigidbody2D>().velocity.x, tinggiLompat);
        }          
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }             
    }
}
