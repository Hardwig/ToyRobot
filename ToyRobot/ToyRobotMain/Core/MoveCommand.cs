using System;
namespace ToyRobotMain.Core
{
    public class MoveCommand
    {

        public static void MoveRobot(RobotModel robot) {

            var xPostion = robot.RobotXPostion;
            var yPostion = robot.RobotYPosition;



            switch (robot.RobotDirection)
            {

                case "north":
                    yPostion++;
                    break;
                case "east":
                    xPostion++;
                    break;
                case "south":
                    yPostion--;
                    break;
                case "west":
                    xPostion--;
                    break;

                default:
                    throw new Exception();
            }

            if (PlaceCommand.ValidateRobot(xPostion, yPostion, robot.RobotDirection))
            {
                robot.RobotYPosition = yPostion;
                robot.RobotXPostion = xPostion;
            }
            else
            {
                Console.WriteLine("Cannot Move Robot Off The Table");
            }



        }


    }
}

