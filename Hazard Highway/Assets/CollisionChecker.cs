using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionChecker : MonoBehaviour
{
    public GameOverState gameover;

    //Collision Checker - When Collision occurs, we check that we've collided with something that should trigger a game over state (just one thing atm, another car)
    //if so, the GameOver function is called (see GameOverState script)
    void OnCollisionEnter2D(Collision2D other)
    {
        gameover.GameOver();
        //transform.position = new Vector3(0, 0, -1000f);
        //Destroy(gameObject, 2f);

    }

}
