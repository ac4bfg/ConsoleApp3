using System;

namespace TheBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Balls redBall = new Balls();
             redBall.setColor("red");

            Balls blueBall = new Balls();
            blueBall.setColor("blue");

            Balls yellowBall = new Balls();
            yellowBall.setColor("yellow");

            Balls orangeBall = new Balls();
            orangeBall.setColor("orange");

            Balls greenBall = new Balls();
            greenBall.setColor("green");

            Balls brownBall = new Balls();
            brownBall.setColor("purple");
            Balls purpleBall = new Balls();
            purpleBall.setColor("purple");

            Balls whiteBall = new Balls();
            whiteBall.setColor("white");

            Balls blackBall = new Balls();
            blackBall.setColor("black");

            Bucket bucket = new Bucket();

            bucket.addBall(redBall);
            bucket.addBall(blueBall);
            bucket.addBall(yellowBall);
            bucket.addBall(orangeBall);
            bucket.addBall(greenBall);
            bucket.addBall(brownBall);
            bucket.addBall(purpleBall);
            bucket.addBall(whiteBall);
            bucket.addBall(blackBall);

            Console.WriteLine("total : " + bucket.countTheBalls());
        }
    }
}
