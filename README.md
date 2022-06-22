# XamarinBlackjack
A cross-platform Blackjack card game made using Xamarin (Work in progress)

* [WIP](#work-in-progress-screenshots)
* [Some notes](#some-notes)

## Work in Progress: Screenshots

![Image showing work in progress](https://github.com/TheFernandoM/XamarinBlackjack/blob/main/XamarinBlackjack/Assets/Images/wip1.png)

## Some notes
### The value of an Ace (is it 1 or 11?):
 * One of the interesting challenges of programming a Blackjack game is: **"How do you calculate the value of a hand which contains an Ace?"**. This can be challenging since the value of an Ace can be either 1 or 11, depending on the value of the rest of the hand.
 
     * The approach used here is to assign an Ace a value of one (1) whenever the value of the other cards adds up to 10 or more. 
       The reason for this is that if we were to treat it as an 11 instead of a 1 in that situation, then the hand would  be a bust (it would go over 21 and lose). 
       
       When the value of the rest of the cards is LESS than 10, then we treat an Ace as an eleven (11).

### Possible game variants and game settings:
  * Number of decks (1-8 decks allowed)
      *  Typically about 6-8 are used, since adding more decks slightly increases favorable probabilities for the house
 
  * "Hole card" game
      * Whether a game is a hole card game determines the order that the cards are dealt in during the initial dealing of the cards at the start of each round.
