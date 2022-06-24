using System;
using XamarinBlackjack.Enums;
using XamarinBlackjack.Models;

namespace XamarinBlackjack.Tools
{
    public static class CardValueComparer
    {
        /// <summary>
        /// Returns true if two cards have the same numeric value.
        /// <br></br>
        /// Example: (10 and King) returns true
        /// Example: (Ace and 2) returns false
        /// </summary>
        public static bool CheckIfTwoCardsAreEqual(CardModel card1, CardModel card2)
        {
            int value1 = GetNumericValueFromCard(card1);
            int value2 = GetNumericValueFromCard(card2);

            return value1 == value2;
        }
        /// <summary>
        /// From a given card, return its numeric (integer) value.
        /// </summary>
        private static int GetNumericValueFromCard(CardModel card)
        {
            // TO DO: Consider using some sort of pre-populated dictionary of { CardFaceValueEnum : int }
            // rather than this switch statement
            switch (card.FaceValue)
            {
                case CardFaceValueEnum.ACE:
                    return 1;

                case CardFaceValueEnum.TWO:
                    return 2;

                case CardFaceValueEnum.THREE:
                    return 3;

                case CardFaceValueEnum.FOUR:
                    return 4;

                case CardFaceValueEnum.FIVE:
                    return 5;

                case CardFaceValueEnum.SIX:
                    return 6;

                case CardFaceValueEnum.SEVEN:
                    return 7;

                case CardFaceValueEnum.EIGHT:
                    return 8;

                case CardFaceValueEnum.NINE:
                    return 9;

                case CardFaceValueEnum.TEN:
                    return 10;

                case CardFaceValueEnum.JACK:
                    return 10;

                case CardFaceValueEnum.QUEEN:
                    return 10;

                case CardFaceValueEnum.KING:
                    return 10;

                default:
                    break;
            }
            return -1; // this line should not be reached
        }
    }
}
