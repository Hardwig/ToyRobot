using System;
using System.Globalization;

namespace ToyRobotMain.Core
{
    public class RotateCommand
    {
        public static void RotateRobot(RobotModel robot, string command) {

            switch (command)
            {
                case "left":
                    Rotate(robot, -1);
                    break;

                case "right":
                    Rotate(robot, 1);
                    break;


                default:
                    throw new Exception();
            }

        }

        private static void Rotate(RobotModel robot, int rotate) {

            var postion = new Dictionary<string,int >();
            postion.Add("north",0);
            postion.Add("east" ,1);
            postion.Add("south",2);
            postion.Add("west" ,3);

            var currentPostion = postion[robot.RobotDirection];
            var newPostion = currentPostion + rotate;

            if (newPostion < 0)
            {
                newPostion = 3;
            }
            if (newPostion > 3)
            {
                newPostion = 0;
            }

            robot.RobotDirection = postion.FirstOrDefault(x => x.Value == newPostion).Key;

        }
    }
}

