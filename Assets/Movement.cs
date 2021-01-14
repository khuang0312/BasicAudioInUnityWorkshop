using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpDistance;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.paused)
        {
            float horizontalMovement = Input.GetAxisRaw("Horizontal");
            gameObject.transform.position = new Vector2(transform.position.x + (horizontalMovement * speed), transform.position.y);

            if (Input.GetKeyDown("space"))
            {
                SoundManager.playSound("jump_sound");
                gameObject.transform.position = new Vector2(transform.position.x, transform.position.y + jumpDistance);
            }
        }

    }
}
