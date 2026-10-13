//------------------------------------------------------------------------------
// <copyright file="Card.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa un naipe de póker.
    /// </summary>
    public class Card : CardContent
    {
        public Card(Rank rank, Suit suit) : base(rank, suit)
        {
        }


        /// <summary>
        /// Obtiene el texto para imprimir el naipe.
        /// </summary>
        /// <returns>El texto del naipe.</returns>
        public override string GetTextToPrint()
        {
            return $"{this.Rank} of {this.Suit}";
        }
    }
}
