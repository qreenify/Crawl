using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class Deck : MonoBehaviour
{
    [SerializeField] private CardCollection startingDeck;

    private bool _initialized = false;

    private List<CardInfo> Cards
    {
        get;
        set;
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Cards = new List<CardInfo>();
    }

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        if (_initialized) return;
        foreach (var card in startingDeck.cards)
        {
            AddToDeck(card);
        }
        _initialized = true;
    }

    private void AddToDeck(CardInfo card)
    {
        Cards.Add(card);
    }

    public void Remove(CardInfo card)
    {
        if (Cards.Contains(card))
        {
            Cards.Remove(card);
        }
    }
    
    public ICollection<CardInfo> DrawStartingHand(int cardCount)
    {
        if(!_initialized)
            Initialize();
        
        var result = new List<CardInfo>();
        for (int i = 0; i < cardCount; i++)
        {
            var random = Random.Range(0, Cards.Count);
            result.Add(Cards[random]);
        }

        return result;
    }
}