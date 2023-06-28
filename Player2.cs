using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 10f;
    public float maxHealth = 10f;
    public int coins;
    public AudioClip damageSound;
    public AudioSource audiosourse;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    private float delayAttac = 0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            
            if (delayAttac <= 0){
                Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
                delayAttac = 2f;
            }
            
        }
        
        if (delayAttac > 0) {
            delayAttac -=Time.deltaTime;
        }
    }
    public void CollestCoins()
    {
        coins++;
        audiosourse.PlayOneShot(damageSound);
    }
    public void TakeDamage(float damage)
    {
        health-=damage;
        if (health <= 0) {

            Restart.restartGame();

        }
        else{
            health-=damage;
            audiosourse.PlayOneShot(damageSound);
            print("Количество здоровья "+health);
            
        }
    }
}
