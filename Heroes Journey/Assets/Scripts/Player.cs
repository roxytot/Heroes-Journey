using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

void Die() {
    UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
}
    // Update is called once per frame
    void Update()
    {
        // if(currentHealth>maxHealth){
        //     currentHealth = maxHealth;
        // }

        if(currentHealth<=0){
            Die();
        }
    }

    public void Damage(int dmg){
        currentHealth -= dmg;
    }
}
