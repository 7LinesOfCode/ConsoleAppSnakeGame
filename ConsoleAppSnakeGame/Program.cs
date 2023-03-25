
using ConsoleAppSnakeGame;

Snake snake = new Snake();
Console.WriteLine("*Press W/S/D/A to start play!*");
Console.ReadKey();
while (true) 
{
    snake.WriteBoard();
    snake.Input();
    snake.ScoreBoard();
    snake.Logic();
   
}
