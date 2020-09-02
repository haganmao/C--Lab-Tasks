﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD6502_Assignment1Part1_QiangZhang2173138
{
    class Card
    {

        public suit cardShape;
        public rank cardValue;

        public enum suit { Spade, Heart, Diamond, Club }
        public enum rank { TWO = 0, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, J, Q, K, Ace }


        //defaut constructor
        public Card() { }

        //constructor
        public Card(suit cs, rank cv)
        {
            cardShape = cs;
            cardValue = cv;
        }


        //methods
        //accessor
        public rank Rank { get; set; }
        public suit Suit { get; set; }

    }
}