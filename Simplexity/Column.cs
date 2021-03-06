﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Column
    {
        /** Creates the stack we will use later on. */
        private Stack<Piece> pieces = new Stack<Piece>();

        /** Method to get a specific piece */
        public Piece GetPiece(int pos)
        {
            return pieces.ElementAt(pos);
        }
        /** Places a piece on top of the stack. */
        public void PlacePiece(Piece p)
        {
            pieces.Push(p); 
        }
        /** Checks if someone has won on a specific column. */
        public bool Check()
        {
            // c:Color, s:Shape
            int c = 1, s = 1;
            bool result = false;
            
                Piece previousPiece = new Piece();
                foreach (Piece p in pieces)
                {
                    if (p.Color == previousPiece.Color)
                        c++;
                    else
                        c = 1;

                    if (p.Shape == previousPiece.Shape)
                        s++;
                    else
                        s = 1;

                    previousPiece = p;
                }
               
            
            if (s >= 4 || c >= 4)
                result = true;

            return result;
        }

        /** Converts a stack into an array */
        public Piece[] ToArray()
        {
            Piece[] tmp = new Piece[7] { new Piece(), new Piece(),
                                         new Piece(), new Piece(),
                                         new Piece(), new Piece(),
                                         new Piece()};

            pieces.CopyTo(tmp, tmp.Length - pieces.Count);
            return InvertArray(tmp);
        }
        /** Inverts the position of the elements of the array. */
        private Piece[] InvertArray(Piece[] a)
        {
            Piece[] tmp1 = new Piece[a.Length];
            int tmp = a.Length -1;
            
            for (int i = 0; i < tmp1.Length;i++)
            {
                tmp1[i] = a[tmp--];
                
            }
            return tmp1;

        }
        public Piece Peek()
        {
            return this.pieces.Peek();
        }
        public int Count { get { return pieces.Count; } }

    }
}
