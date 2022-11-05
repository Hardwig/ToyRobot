using ToyRobotMain.Core;

namespace ToyRobotUnitTests
{
    public class RotateCommandTest
    {
        [Fact]
        public void RotateCommand_Rotate_Robot_Left_North_To_West()
        {
            //Arrange
            var robot = new RobotModel {RobotXPostion = 2, RobotYPosition = 2, RobotDirection = "north" };

            //Act
            RotateCommand.RotateRobot(robot, "left");

            //Assert
            Assert.Equal(2, robot.RobotYPosition);
            Assert.Equal(2, robot.RobotXPostion);
            Assert.Equal("west", robot.RobotDirection);

        }

        [Fact]
        public void RotateCommand_Rotate_Robot_Left_West_To_South()
        {
            //Arrange
            var robot = new RobotModel { RobotXPostion = 2, RobotYPosition = 2, RobotDirection = "west" };

            //Act
            RotateCommand.RotateRobot(robot, "left");

            //Assert
            Assert.Equal(2, robot.RobotYPosition);
            Assert.Equal(2, robot.RobotXPostion);
            Assert.Equal("south", robot.RobotDirection);

        }

        [Fact]
        public void RotateCommand_Rotate_Robot_Left_South_To_East()
        {
            //Arrange
            var robot = new RobotModel { RobotXPostion = 2, RobotYPosition = 2, RobotDirection = "south" };

            //Act
            RotateCommand.RotateRobot(robot, "left");

            //Assert
            Assert.Equal(2, robot.RobotYPosition);
            Assert.Equal(2, robot.RobotXPostion);
            Assert.Equal("east", robot.RobotDirection);

        }

        [Fact]
        public void RotateCommand_Rotate_Robot_Left_East_To_North()
        {
            //Arrange
            var robot = new RobotModel { RobotXPostion = 2, RobotYPosition = 2, RobotDirection = "east" };

            //Act
            RotateCommand.RotateRobot(robot, "left");

            //Assert
            Assert.Equal(2, robot.RobotYPosition);
            Assert.Equal(2, robot.RobotXPostion);
            Assert.Equal("north", robot.RobotDirection);

        }

        [Fact]
        public void RotateCommand_Rotate_Robot_Right_North_To_East()
        {
            //Arrange
            var robot = new RobotModel { RobotXPostion = 2, RobotYPosition = 2, RobotDirection = "north" };

            //Act
            RotateCommand.RotateRobot(robot, "right");

            //Assert
            Assert.Equal(2, robot.RobotYPosition);
            Assert.Equal(2, robot.RobotXPostion);
            Assert.Equal("east", robot.RobotDirection);

        }

        [Fact]
        public void RotateCommand_Rotate_Robot_Right_East_To_South()
        {
            //Arrange
            var robot = new RobotModel { RobotXPostion = 2, RobotYPosition = 2, RobotDirection = "east" };

            //Act
            RotateCommand.RotateRobot(robot, "right");

            //Assert
            Assert.Equal(2, robot.RobotYPosition);
            Assert.Equal(2, robot.RobotXPostion);
            Assert.Equal("south", robot.RobotDirection);

        }

        [Fact]
        public void RotateCommand_Rotate_Robot_Right_South_To_West()
        {
            //Arrange
            var robot = new RobotModel { RobotXPostion = 2, RobotYPosition = 2, RobotDirection = "south" };

            //Act
            RotateCommand.RotateRobot(robot, "right");

            //Assert
            Assert.Equal(2, robot.RobotYPosition);
            Assert.Equal(2, robot.RobotXPostion);
            Assert.Equal("west", robot.RobotDirection);

        }

        [Fact]
        public void RotateCommand_Rotate_Robot_Right_West_To_North()
        {
            //Arrange
            var robot = new RobotModel { RobotXPostion = 2, RobotYPosition = 2, RobotDirection = "west" };

            //Act
            RotateCommand.RotateRobot(robot, "right");

            //Assert
            Assert.Equal(2, robot.RobotYPosition);
            Assert.Equal(2, robot.RobotXPostion);
            Assert.Equal("north", robot.RobotDirection);

        }

        [Fact]
        public void RotateCommand_Rotate_Robot_Exception()
        {
            //Arrange
            var robot = new RobotModel();

            //Act
            Assert.Throws<Exception>(() => RotateCommand.RotateRobot(robot, "fake"));

        }



    }
}

