using System;
using System.Collections.Generic;
using XamarinBlackjack.Enums;
using XamarinBlackjack.Models;

namespace XamarinBlackjack.Tools
{
    public static class HandTools
    {
        /// <summary>
        /// Calculates the numeric value of a Hand of Cards.
        /// </summary>
        public static int CalculateHandValue(HandModel hand)
        {
            /* This method handles one of the more interesting and fun (read: frustrating)
             * challenges of programming a Blackjack game: "How do you programmatically
             * calculate the value of a hand?"
             * 
             * In particular, how do you treat the value of an Ace?
             * 
             * The approach taken here is to always treat an Ace as a one (1) if the
             * value of the hand is 10 or more. The reason for this is that if we were to
             * treat it as an 11 instead of a 1 in that situation, then the hand would
             * be a bust (it would go over 21 and lose).
             * 
             * When the value of the rest of the cards is LESS than 10, then
             * we treat an Ace as an eleven (11).
             */

            int handValue = 0;
            int numberOfAces = 0;
            foreach (var card in hand.Cards)
            {
                switch (card.FaceValue)
                {
                    case CardFaceValueEnum.ACE:
                        numberOfAces += 1;
                        break;

                    case CardFaceValueEnum.TWO:
                        handValue += 2;
                        break;

                    case CardFaceValueEnum.THREE:
                        handValue += 3;
                        break;

                    case CardFaceValueEnum.FOUR:
                        handValue += 4;
                        break;

                    case CardFaceValueEnum.FIVE:
                        handValue += 5;
                        break;

                    case CardFaceValueEnum.SIX:
                        handValue += 6;
                        break;

                    case CardFaceValueEnum.SEVEN:
                        handValue += 7;
                        break;

                    case CardFaceValueEnum.EIGHT:
                        handValue += 8;
                        break;

                    case CardFaceValueEnum.NINE:
                        handValue += 9;
                        break;

                    case CardFaceValueEnum.TEN:
                        handValue += 10;
                        break;

                    case CardFaceValueEnum.JACK:
                        handValue += 10;
                        break;

                    case CardFaceValueEnum.QUEEN:
                        handValue += 10;
                        break;

                    case CardFaceValueEnum.KING:
                        handValue += 10;
                        break;

                    default:
                        break;
                }
                if (numberOfAces > 0)
                {
                    bool isHandValueGreaterThan9 = handValue > 9 ? true : false;
                    for (int i = numberOfAces; i > 0; i--)
                    {
                        if (isHandValueGreaterThan9)
                        {
                            handValue++;
                            continue;
                        }
                        if (!isHandValueGreaterThan9)
                        {
                            handValue += 11;
                        }
                    }
                }
            }
            return handValue;
        }
    }
}
