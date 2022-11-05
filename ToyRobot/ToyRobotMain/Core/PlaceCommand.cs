using System;
using System.Diagnostics;

namespace ToyRobotMain.Core
{
    public static class PlaceCommand
    {

        public static void InitRobot(string input, RobotModel robot) {

            input = input.Replace("place", "").Trim();
            string[] initialize = input.Split(',');

            var postionX = int.Parse(initialize[0]);
            var postionY = int.Parse(initialize[1]);
            var direction = initialize[2];

            if (ValidateRobot(postionX, postionY, direction))
            {
                robot.RobotXPostion = postionX;
                robot.RobotYPosition = postionY;
                robot.RobotDirection = direction;
            }
            else {
                Console.WriteLine("Invalid PLACE Command");
            }

        }


        public static bool ValidateRobot(int positionX, int postionY, string direction) {

            var isValid = true;
            var directions = new List<string>{ "north", "east", "south", "west"};

            if (positionX > 5 || positionX < 0)
            {
                isValid = false;
            }

            if (postionY > 5 || postionY < 0)
            {
                isValid = false;
            }

            if (!directions.Contains(direction))
            {
                isValid = false;
            }

            return isValid;

        }

    }
}

