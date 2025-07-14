using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public CardScriptableObject cardSO;

    public int attackPower;
    public int currentHealth;
    public int manaCost;

    public TMP_Text attackText;
    public TMP_Text healthText;
    public TMP_Text costText;
    public TMP_Text nameText, actionDescriptionText, loreText;

    public Image characterArt, bgArt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetupCard();
    }

    public void SetupCard()
    {
        currentHealth = cardSO.currentHealth;
        attackPower = cardSO.attackPower;
        manaCost = cardSO.manaCost;

        healthText.text = currentHealth.ToString();
        attackText.text = attackPower.ToString();
        costText.text = manaCost.ToString();
        //UpdateCardDisplay();

        nameText.text = cardSO.cardName;
        actionDescriptionText.text = cardSO.actionDescription;
        loreText.text = cardSO.cardLore;

        characterArt.sprite = cardSO.characterSprite;
        bgArt.sprite = cardSO.bgSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
