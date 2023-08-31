using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private float _deadZoneUp = 25;
    private float _deadZoneDown = -25;
    private Vector2 startingZone;

    Animator _animator;

    BirdScript _birdScript;
    // Start is called before the first frame update
    void Start()
    {
        startingZone = transform.position;
        _birdScript = GetComponent<BirdScript>();
        _animator = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < _deadZoneDown || transform.position.y>_deadZoneUp)
        {
            LoosingLives();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Pipe")
        {
            LoosingLives();
        }
    }

    private void LoosingLives()
    {
        _birdScript.OnDeaths();
        gameObject.transform.position = startingZone;
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        _animator.SetBool("IsTransitioning", true);
        StartCoroutine(LoosingLivesDelay());

        if (_birdScript.LivesLeft() < 1)
        {
            DeathSequence();
        }   
    }

    public IEnumerator LoosingLivesDelay()
    {
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
        _animator.SetBool("IsTransitioning", false);
    }
    

    private void DeathSequence()
    {
        Time.timeScale = 0;
        StartCoroutine(DeathDelay());
        Debug.Log("GameOver");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(1);
    }

}
