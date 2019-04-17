using UnityEngine;
using EventsSystem;


public class Enemy : MonoBehaviour {
    //**************** important value *************
    public static int allCount = 3;


    [SerializeField]
	private int health = 100;
	[SerializeField]
	private int takesLives = 10;
	[SerializeField]
	private int givesMoney = 5;
    //
    private int currentFlag = 1;

    public void Hit(int damage) {
		health -= damage;
		
		if (health <= 0) {
			
			Die();
		} else {
			UpdateHealth();
		}
	}

	private void Die() {
        // Todo: Show dying animation

        if (currentFlag > 0)
        {
            currentFlag--;
            allCount--;
            Debug.Log("Now remaining Enemy count:" + allCount);
            Destroy(gameObject);
            GameManager.instance.money += givesMoney;
        }
        
    }

	private void UpdateHealth() {
		// Todo: Show and update health bar
	}

	public void AchievedTarget() {
		GameManager.instance.lives -= takesLives;
		Die();
	}
}