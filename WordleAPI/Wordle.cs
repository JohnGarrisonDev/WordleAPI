using System.Collections;


namespace WordleAPI
{
    public class Wordle
    {
        public string Guess { get; set; }
        public bool Correct{get;set;}
        public ArrayList curCorrect { get; set; }

        public Wordle(string curWord, string guess)
        {
            this.Guess = guess;
            if (curWord == guess)
            {
                this.curCorrect = new ArrayList() {2,2,2,2,2};
                this.Correct = true;
            }
            else
            {
                this.curCorrect = new ArrayList();
                HashSet<int> locs = new HashSet<int>();
                for (int i =0; i < curWord.Length; i++)
                {
                    if (curWord[i] == guess[i])
                    {
                        this.curCorrect.Add(2);
                        locs.Add(i);
                    }
                    else if ((curWord.IndexOf(guess[i]) >= 0)&&!locs.Contains(curWord.IndexOf(guess[i])))
                    {
                        this.curCorrect.Add(1);
                        locs.Add(i);
                    }
                    else
                    {
                        this.curCorrect.Add(0);
                    }
                }
                this.Correct=false;
            }
        }
    }
}
