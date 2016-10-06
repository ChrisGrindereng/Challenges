using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Score
{
    private int score = 0;
    private void increaseScore()
    {
        this.score++;
    }
    private void decreaseScore()
    {
        this.score--;
    }
}

public class SomeEvilProgram
{
    public static void Main()
    {
        Score score = new Score();
        score.score = 9000;
    }
}



