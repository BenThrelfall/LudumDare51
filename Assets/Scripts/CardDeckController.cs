using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CardDeckController : MonoBehaviour {

    public List<AbilityCard> deck = new List<AbilityCard>();

    [SerializeField] TextMeshProUGUI cardOneText;
    [SerializeField] TextMeshProUGUI cardTwoText;

    [SerializeField] TextMeshProUGUI cardOneDesc;
    [SerializeField] TextMeshProUGUI cardTwoDesc;

    [SerializeField] Image cardOneImage;
    [SerializeField] Image cardTwoImage;

    [SerializeField] AudioSource pickWarningSound;
    [SerializeField] AudioSource pickSound;

    AbilityCard cardOne;
    AbilityCard cardTwo;

    AbilityCard choice;


    private void Start() {
        StartCoroutine(DoCardChoice());
        StartCoroutine(DoSoundLoop());
    }

    private void Update() {
        
        if (Input.GetKeyDown(KeyCode.J)) {
            choice = cardOne;
            cardOneText.color = Color.red;
            cardTwoText.color = Color.white;
        }

        if (Input.GetKeyDown(KeyCode.K)) {
            choice = cardTwo;
            cardOneText.color = Color.white;
            cardTwoText.color = Color.red;
        }

    }

    IEnumerator DoSoundLoop() {
        while (true) {

            yield return new WaitForSeconds(8);

            pickWarningSound.Play();

            yield return new WaitForSeconds(2);

            pickSound.Play();
        }
    }

    IEnumerator DoCardChoice() {

        while (true) {
            choice = null;

            cardOneText.color = Color.white;
            cardTwoText.color = Color.white;

            cardOne = deck[Random.Range(0, deck.Count)];
            cardTwo = deck[Random.Range(0, deck.Count)];

            cardOneText.text = cardOne.cardName;
            cardTwoText.text = cardTwo.cardName;

            cardOneDesc.text = cardOne.cardDescription;
            cardTwoDesc.text = cardTwo.cardDescription;

            cardOneImage.sprite = cardOne.cardArt;
            cardTwoImage.sprite = cardTwo.cardArt;

            yield return new WaitForSeconds(10);

            if (choice == null) choice = cardOne;

            choice.DoAbility();

        }

    }

}
