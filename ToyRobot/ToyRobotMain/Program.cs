using System;
using ToyRobotMain.Core;

namespace HardwigRobot
{
    public class TopSize
    {

        static void Main(string[] args)
        {
           var robot = new RobotModel();

            //ROBOT START POSTION
            Console.WriteLine("To start this robot use the PLACE Command i.e PLACE X,Y,Direction(N,E,S,W) ");

            string input;

            while ((input = Console.ReadLine()) != null)
            {

                try
                {
                    var robotCommand = input.ToLower();
                    switch (robotCommand)
                    {
                        case var place when robotCommand.Contains("place"):
                            PlaceCommand.InitRobot(place,robot);
                            break;

                        case "move":
                            MoveCommand.MoveRobot(robot);
                            break;

                        case "report":
                            Console.WriteLine($"{robot.RobotXPostion},{robot.RobotYPosition},{robot.RobotDirection}");
                            break;

                        default:
                            throw new Exception();

                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Please check command");
                }

            }

            
        }
        
    }

}