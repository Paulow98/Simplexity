using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simplexity
{
    /** Is a class that contains all the variables that are binded to a piece: Color and Shape. */

    class Piece
    {
        /** Variable that will hold the color of said piece. */
        private Color color;
        /** Variable that will hold the shape of said piece. */
        private Shape shape;
        /** Function that will enable the change of said piece's properties. */
        public Piece(Color color, Shape shape)
        {
            this.color = color;
            this.shape = shape;
        }
        /** Function that will clear the properties of said piece. */
        public Piece()
        {
            this.color = Color.None;
            this.shape = Shape.None;
        }
        /** Property that is read only. */
        public Shape Shape { get { return this.shape; } }
        /** Property that is read only. */
        public Color Color { get { return this.color; } }
    }
}
