using System;
using System.Collections.Generic;


namespace TheBalls
{
    class Bucket
    {
        private List<Balls> balls = new List<Balls>();

        public void addBall(Balls ball)
        {
            this.balls.Add(ball);
        }
        public int countTheBalls()
        {
            return this.balls.Count;
        }
    }
}
