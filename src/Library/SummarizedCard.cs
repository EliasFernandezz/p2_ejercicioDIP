namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Clase que representa una carta que se imprime de una forma mas resumida.
    /// </summary>
    public class SummarizedCard : CardContent
    {
        public SummarizedCard(Rank rank, Suit suit) : base(rank, suit)
        {
        }


        /// <summary>
        /// Obtiene el texto para imprimir el naipe mas resumidamente.
        /// </summary>
        /// <returns>El texto del naipe.</returns>
        public override string GetTextToPrint()
        {
            string rank = "";
            string symbol = "";

            switch (this.Rank)
            {
                case Rank.Two:
                    rank = "2";
                    break;
                case Rank.Three:
                    rank = "3";
                    break;
                case Rank.Four:
                    rank = "4";
                    break;
                case Rank.Five:
                    rank = "5";
                    break;
                case Rank.Six:
                    rank = "6";
                    break;
                case Rank.Seven:
                    rank = "7";
                    break;
                case Rank.Eight:
                    rank = "8";
                    break;
                case Rank.Nine:
                    rank = "9";
                    break;
                case Rank.Ten:
                    rank = "10";
                    break;
                case Rank.Jack:
                    rank = "J";
                    break;
                case Rank.Queen:
                    rank = "Q";
                    break;
                case Rank.King:
                    rank = "K";
                    break;
                case Rank.Ace:
                    rank = "A";
                    break;
            }

            switch (this.Suit)
            {
                case Suit.Hearts:
                    symbol = "♥";
                    break;
                case Suit.Diamonds:
                    symbol = "♦";
                    break;
                case Suit.Clubs:
                    symbol = "♣";
                    break;
                default:
                    symbol = "♠";
                    break;
            }

            return rank + symbol;
        }
    }
}