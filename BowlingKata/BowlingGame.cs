using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingKata
{
    public class BowlingGame
    {
        #region Fields

        private const int totalNumberOfPins = 10;
        private const int totalNumberOfFrames = 10;
        private List<int> pinsList;
        private Dictionary<int, int> scorePerFrame;        

        #endregion

        #region Properties
        #endregion

        #region Constructor

        public BowlingGame()
        {
            this.pinsList = new List<int>();
            this.scorePerFrame = new Dictionary<int, int>();
        }

        #endregion

        #region Public Methods

        public void Roll(int numberOfPinsKnockedDown)
        {
            if (this.pinsList.Count > 21)
            {
                throw new ArgumentException("number of rolls must be at most 21");
            }
            this.pinsList.Add(numberOfPinsKnockedDown);            
        }        

        public int GetCurrentScore()
        {
            var currentScore = this.ComputeScorePerFrame();
            return currentScore;
        }

        #endregion

        #region Private Methods

        private int ComputeScorePerFrame()
        {
            int frame = 1;
            int indexCounter = 0;
            int runningTotalScore = 0;
            while (frame <= totalNumberOfFrames)
            {                
                RollType rollType = this.CheckRollType(indexCounter);
                runningTotalScore += this.AddScoreToFrame(frame, indexCounter, rollType);
                if (rollType == RollType.Strike)
                {
                    indexCounter++;
                }
                else
                {
                    indexCounter+=2;
                }
                frame++;
            }
            return runningTotalScore;
        }

        private int AddScoreToFrame(int frame, int index, RollType rollType)
        {
            int frameScore = 0;
            switch (rollType)
            {
                case RollType.OpenFrame:
                    if (index < this.pinsList.Count - 1)
                    {
                        frameScore = this.pinsList[index] + this.pinsList[index + 1];
                        this.scorePerFrame.Add(frame, frameScore);
                    }
                    break;
                case RollType.Spare:
                case RollType.Strike:
                    if (index < this.pinsList.Count - 2)
                    {
                        frameScore = this.pinsList[index] + this.pinsList[index + 1] + this.pinsList[index + 2];
                        this.scorePerFrame.Add(frame, frameScore);
                    }
                    break;
            }
            return frameScore;
        }

        private RollType CheckRollType(int index)
        {
            RollType rollType = RollType.OpenFrame;
            if (index < this.pinsList.Count - 1)
            {
                if (this.pinsList[index] == totalNumberOfPins)
                {
                    rollType = RollType.Strike;
                }
                else if (this.pinsList[index] + this.pinsList[index + 1] == totalNumberOfPins)
                {
                    rollType = RollType.Spare;
                }
            }
            return rollType;
        }

        #endregion
    }
}
