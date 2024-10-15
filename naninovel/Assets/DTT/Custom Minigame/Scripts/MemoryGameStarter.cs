using System.Collections;
using System.Collections.Generic;
using DTT.MinigameMemory;
using UnityEngine;

public class MemoryGameStarter : MonoBehaviour
{
    /// <summary>
    /// Used to start the memory minigame throught the <see cref="MemoryGameManager"/>.
    /// </summary>
        /// <summary>
        /// Used to manipulate the game flow.
        /// </summary>
        [SerializeField]
        private MemoryGameManager _gameManager;

        /// <summary>
        /// Settings used for this game.
        /// </summary>
        [SerializeField]
        private MemoryGameSettings _gameSettings;

        /// <summary>
        /// Results from the game.
        /// </summary>
        private MemoryGameResults _gameResults;

        private void Start() => _gameManager.StartGame(_gameSettings);

        /// <summary>
        /// Sums the existing results and the new results.
        /// </summary>
        /// <param name="results">new results to be added.</param>
}
