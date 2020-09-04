using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public System.Random rand = new System.Random();
    public float velocity;
    public float position_x;

    public GameObject SystemParticule1;
    public GameObject SystemParticule2;

    private Rigidbody rbody;
    private Score score;
    private Score2 score2;
    private Controls controls;
    private IA ia;
    private SFXplaying sfx;
    private Score_1 score_1;
    private Score_2 score_2;
    private lightend light_end;
    private cam camera_l;
    private LoseScript losescript;

    private int hitbox_p1 = 0;
    private int hitbox_p2 = 0;
    private int leftwall = 0;
    private int rightwall = 0;
    private int state = 2;
    private int choix;
    private int score_actuel_1 = 0;
    private int score_actuel_2 = 0;

    public float secondes = 3;

    void Start() {
        choix = rand.Next(1, 3);
        score = GameObject.Find("Score_J1").GetComponent<Score>();
        score2 = GameObject.Find("Score_J2").GetComponent<Score2>();
        controls = GameObject.Find("Player").GetComponent<Controls>();
        sfx = GameObject.Find("SFXplayingGO").GetComponent<SFXplaying>();
        ia = GameObject.Find("Player2").GetComponent<IA>();
        score_1 = GameObject.Find("Score_J1_1").GetComponent<Score_1>();
        score_2 = GameObject.Find("Score_J2_1").GetComponent<Score_2>();
        light_end = GameObject.Find("SpotLightEnd").GetComponent<lightend>();
        camera_l = GameObject.Find("Main_camera").GetComponent<cam>();
        losescript = GameObject.Find("SceneManager").GetComponent<LoseScript>();
        Cursor.visible = false;
    }

    void Update() {

        position_x = transform.position.x;

        float moins = (velocity - (2 * velocity)) * Time.deltaTime;
        float plus = velocity * Time.deltaTime;

        if (score_actuel_1 == 3 && state != 3 || score_actuel_2 == 3 && state != 3) {
            state = 3;
            score_1.text_j1 = score_actuel_1.ToString();
            score_2.text_j2 = score_actuel_2.ToString();
            light_end.LightOn();
            camera_l.Teleport();
            secondes = 3f;
            print(score_actuel_2);
        }

        if (secondes > 0 && state == 3) {
            secondes -= Time.deltaTime;
        }
        if (secondes < 0 && state == 3) {
            losescript.SceneLoader(0);
        }

        if (transform.position.z < -23f) {
            sfx.PlayLose();
            velocity = 15;
            score_actuel_2 += 1;
            score2.text_j2 = score_actuel_2.ToString();
            state = 2;
            hitbox_p1 = 0;
            hitbox_p2 = 0;
            choix = 1;
            ia.diffup = 0;
            transform.position = new Vector3(0f, 1f, 0f);
            ia.transform.position = new Vector3(0f, 0.5f, 20f);
            controls.transform.position = new Vector3(0f, 0.5f, -20f);
            secondes = 3;
        }
        if (transform.position.z > 23f) {
            sfx.PlayLose();
            SystemParticule1.SetActive(false);
            SystemParticule2.SetActive(false);
            SystemParticule1.SetActive(true);
            SystemParticule2.SetActive(true);
            velocity = 15;
            score_actuel_1 += 1;
            score.text_j1 = score_actuel_1.ToString();
            state = 2;
            hitbox_p1 = 0;
            hitbox_p2 = 0;
            choix = 2;
            ia.diffup = 0;
            transform.position = new Vector3(0f, 1f, 0f);
            ia.transform.position = new Vector3(0f, 0.5f, 20f);
            controls.transform.position = new Vector3(0f, 0.5f, -20f);
            secondes = 3;
        }

        if (secondes > 0 && state == 2 && score_actuel_1 < 3 && score_actuel_2 < 3) {
            secondes -= Time.deltaTime;
            if(secondes > 2.9f && secondes < 3f) {
                sfx.PlayPong();
                secondes = 2.9f;
            }
            if(secondes > 1.9f && secondes < 2f) {
                sfx.PlayPong();
                secondes = 1.9f;
            }
            if(secondes > 0.9f && secondes < 1f) {
                sfx.PlayPong();
                secondes = 0.9f;
            }
        }
        if (secondes <= 0 && state == 2) {
            secondes = 3;
            state = 0;
        }

        if (choix == 1 && state == 0) {
            transform.Translate(0f, 0f, moins);
        }
        if (choix == 2 && state == 0) {
            transform.Translate(0f, 0f, plus);
        }

        if (hitbox_p1 == 1 && leftwall == 0 && rightwall == 0) {
            transform.Translate(moins, 0f, plus);
        }
        if (hitbox_p1 == 2 && leftwall == 0 && rightwall == 0) {
            transform.Translate(plus, 0f, plus);
        }
        if (hitbox_p2 == 1 && leftwall == 0 && rightwall == 0) {
            transform.Translate(plus, 0f, moins);
        }

        if (leftwall == 1 && hitbox_p1 == 1 && state == 1) {
            transform.Translate(plus, 0f, plus);
        }
        if (rightwall == 1 && hitbox_p1 == 1 && state == 1) {
            transform.Translate(moins, 0f, plus);
        }

        if (leftwall == 1 && hitbox_p1 == 2 && state == 1) {
            transform.Translate(plus, 0f, plus);
        }
        if (rightwall == 1 && hitbox_p1 == 2 && state == 1) {
            transform.Translate(moins, 0f, plus);
        }

        if (leftwall == 1 && hitbox_p2 == 1 && state == 1) {
            transform.Translate(plus, 0f, moins);
        }
        if (rightwall == 1 && hitbox_p2 == 1  && state == 1) {
            transform.Translate(moins, 0f, moins);
        }
    }

    void OnCollisionEnter(Collision col) {
        if (col.collider.name == "HitBox1") {
            sfx.PlayPing();
            hitbox_p1 = 1;
            hitbox_p2 = 0;
            state = 1;
            if (velocity < 60) {
                velocity += 1;
            }
        }
        if (col.collider.name == "HitBox2") {
            sfx.PlayPing();
            hitbox_p1 = 2;
            hitbox_p2 = 0;
            state = 1;
            if (velocity < 60) {
                velocity += 1;
            }
        }
        if (col.collider.name == "HitBox1_2") {
            sfx.PlayPong();
            hitbox_p2 = 1;
            hitbox_p1 = 0;
            state = 1;
            if (velocity < 60) {
                velocity += 1;
            }
        }
        if (col.collider.name == "LeftWall") {
            leftwall = 1;
            rightwall = 0;
        }
        if (col.collider.name == "RightWall") {
            rightwall = 1;
            leftwall = 0;
        }
    }
}

//test