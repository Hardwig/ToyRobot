using System;
namespace ToyRobotMain.Core
{
    public class MoveCommand
    {

        public static void MoveRobot(RobotModel robot) {


            switch (robot.RobotDirection)
            {

                case "north":
                    robot.RobotYPosition++;
                    break;
                case "east":
                    robot.RobotXPostion++;
                    break;
                case "south":
                    robot.RobotYPosition--;
                    break;
                case "west":
                    robot.RobotXPostion--;
                    break;

                default:
                    break;
            }

        }


    }
}

