using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessCloud.Data
{
    public enum EngineList
    {
        /*
         * Hannibal is a Universal Chess Interface (UCI) engine that incorporates ideas from earlier engines, 
         * Twisted Logic, and LearningLemming. It uses the alpha-beta technique with many other chess specific 
         * heuristics and relies on a selective search method.
         * Besides incredible endgame knowledge, the engine has a good understanding of material imbalances. 
         * It also understands the fortresses and trapped pieces and can sacrifice material for the initiative on 
         * king attacks.
         */
        Hannibal,
        /* Stockfish is an open-source UCI engine available for various desktop and mobile platforms. 
         * It is based on another open-source chess engine named Glaurung.
         * 
         * Written in C++, the engine can utilize up to 512 CPU cores. 
         * The maximum size of its transposition table is 1 Terabyte. Beside implementing an alpha-beta search, 
         * the engine features aggressive pruning and late move reductions. 
         */
        StockFish,
        /* 
         * temp
         */
        Ufim802
    }
}

