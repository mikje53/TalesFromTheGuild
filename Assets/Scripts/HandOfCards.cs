using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandOfCards : MonoBehaviour
{
    [SerializeField]
    public GameObject cardPrefab;

    public int handSize;

    private float cardSpaceBuffer = 0.1f;
    
    public void initializeHand(int initialHandSize) {
        this.handSize = initialHandSize;
        for(int i = 0; i < this.handSize; i++) {
            Instantiate(cardPrefab, new Vector3(i - 1 + (cardSpaceBuffer*i), 0.1f + (i/10), -3), Quaternion.Euler(90, 0, 0));
        }
    }
}
