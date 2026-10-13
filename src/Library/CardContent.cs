
namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Clase abstracta que representa el contenido de una carta.
    /// </summary>
public abstract class CardContent
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="CardContent"/>.
        /// </summary>
        /// <param name="rank">El valor del naipe.</param>
        /// <param name="suit">El palo del naipe.</param>
        public CardContent(Rank rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        /// <summary>
        /// Obtiene el valor del naipe.
        /// </summary>
        public Rank Rank { get; private set; }

        /// <summary>
        /// Obtiene el palo del naipe.
        /// </summary>
        public Suit Suit { get; private set; }

        /// <summary>
        /// método abstracto que pueden implementan varios tipos de cartas
        /// para imprimir su contenido.
        /// </summary>
        /// <returns> el contenido que imprime.</returns>
        public abstract string GetTextToPrint();
    }
}