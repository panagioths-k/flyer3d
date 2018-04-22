using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleHero : MonoBehaviour {

    public GameObject hero;
    public Vector3 herosDistanceFromCamera;
    public float horizontalHeroLeap;

    public float smoothTime = 0.3F;
    public Vector3 velocity = Vector3.zero;

    private int direction;                          //defines whether the hero moves left (1) or right (-1)

    // Use this for initialization
    void Start() {

        GameObject c = gameObject;                  //generate hero in front of camera
        hero = Instantiate(hero, gameObject.transform.transform.position + herosDistanceFromCamera, gameObject.transform.rotation);
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButton(0) || Input.GetMouseButton(1) || (Input.touchCount > 0 && (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(0).phase == TouchPhase.Stationary)) )
        {
            direction = 1;
            if (Input.mousePosition.x < Screen.width / 2)
            {
                direction = -1;
            }
            hero.transform.position = Vector3.SmoothDamp(hero.transform.position,
                    new Vector3(hero.transform.position.x + ( horizontalHeroLeap * direction), hero.transform.position.y, hero.transform.position.z),
                    ref velocity, smoothTime);
           
        }
    }
}
