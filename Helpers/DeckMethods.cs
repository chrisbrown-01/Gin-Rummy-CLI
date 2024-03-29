﻿using _11242022_Gin_Rummy.Enums;
using _11242022_Gin_Rummy.Models;

namespace _11242022_Gin_Rummy.Helpers
{
    public static class DeckMethods
    {
        /// <summary>
        /// Create deck of 52 cards.
        /// </summary>
        /// <returns></returns>
        public static List<Card> CreateDeck()
        {
            List<Card> deck = new();

            for (int assignSuit = 1; assignSuit < 5; assignSuit++)
            {
                for (int assignRank = 1; assignRank < 14; assignRank++)
                {
                    deck.Add(new Card()
                    {
                        Suit = (Suit)assignSuit,
                        Rank = (Rank)assignRank
                    });
                }
            }

            return deck;
        }

        /// <summary>
        /// Returns a shuffled deck of 52 cards. Utilizes the Fisher-Yates shuffle algorithm.
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        public static List<Card> ShuffleDeck(List<Card> deck)
        {
            // Fisher-Yates shuffle algorithm
            var random = new Random();
            Card tempCard = new();

            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                tempCard = deck[i];
                deck[i] = deck[j];
                deck[j] = tempCard;
            }

            return deck;
        }
    }
}