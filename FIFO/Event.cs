namespace FIFO1
{
    class Event
    {
        public delegate void ScoreUpdateHandler(int newScore);
        public event ScoreUpdateHandler ScoreUpdate;

        private int score;
        public int Score
        {
            get { return score; }
            set
            {
                score = value;
                ScoreUpdate(value);
            }
        }





    }
}
