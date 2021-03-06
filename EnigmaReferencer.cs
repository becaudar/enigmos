﻿using Cpln.Enigmos.Enigmas;
using Cpln.Enigmos.Utils;
using System.Collections.Generic;

namespace Cpln.Enigmos
{
    /// <summary>
    /// Cette classe permet de référencer toutes les énigmes, ainsi que de tester une énigme lors du débugging.
    /// </summary>
    public abstract class EnigmaReferencer
    {
        /// <summary>
        /// Cette méthode permet de n'afficher que l'énigme qu'on souhaite tester. Si null est renvoyé, alors l'application démarre normalement.
        /// </summary>
        /// 
        /// <remarks>Lorsque le programme est en mode RELEASE, cette méthode n'est pas appelée.</remarks>
        /// <returns>L'énigme à afficher</returns>
        public static Enigma DebugEnigma()
        {
            //return new Enigma(new SimpleEnigmaPanel(), "C'est simple");
            return null;

            // ---
        }

        /// <summary>
        /// Cette méthode crée une liste contenant les différentes énigmes et la mélange avant de la retourner.
        /// </summary>
        /// <returns>Une liste d'énigme mélangées</returns>
        public static List<Enigma> ReferenceEnigmas()
        {
            ShuffleList<Enigma> enigmas = new ShuffleList<Enigma>();

            enigmas.Add(new Enigma(new SimpleEnigmaPanel(), "C'est simple"));
            enigmas.Add(new Enigma(new SimplePuzzleEnigmaPanel(), "Puzzle"));

            enigmas.Shuffle();
            return enigmas;
        }
    }
}
