using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int attackPower;
    public int currentHealth;
    public int manaCost;

    public TMP_Text attackText;
    public TMP_Text healthText;
    public TMP_Text costText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackText.text = attackPower.ToString();
        healthText.text = currentHealth.ToString();
        costText.text = manaCost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
