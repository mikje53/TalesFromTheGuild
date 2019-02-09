using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public int handSize;

    [SerializeField]
    public GameObject handOfCards;

    private HandOfCards _handOfCards;
    // Start is called before the first frame update
    void Start()
    {
        _handOfCards = handOfCards.GetComponent<HandOfCards>();
        _handOfCards.initializeHand(handSize);
    }
}
