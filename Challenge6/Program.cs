using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//the task here was to allow a score to be set internally within a program but not be accessable to an outside program
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

//the class is to simulate an outside program attempting to alter the in game score
public class SomeEvilProgram
{
    public static void Main()
    {
        Score score = new Score();
        score.score = 9000;     //as a result of the security above this part will not compile thus showing the security above is working
    }
}
