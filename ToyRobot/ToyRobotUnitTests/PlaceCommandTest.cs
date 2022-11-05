using ToyRobotMain.Core;

namespace ToyRobotUnitTests
{
    public class PlaceCommandTest
    {

        [Fact]
        public void Place_Valid_Robot_Command_North()
        {
            //Arrange
            var robot = new RobotModel();

            //Act
            PlaceCommand.InitRobot("place 1,1,north", robot);

            //Assert
            Assert.Equal(1, robot.RobotYPosition);
            Assert.Equal(1, robot.RobotXPostion);
            Assert.Equal("north", robot.RobotDirection);

        }

        [Fact]
        public void Place_Valid_Robot_Command_East()
        {
            //Arrange
            var robot = new RobotModel();

            //Act
            PlaceCommand.InitRobot("place 1,1,east", robot);

            //Assert
            Assert.Equal(1, robot.RobotYPosition);
            Assert.Equal(1, robot.RobotXPostion);
            Assert.Equal("east", robot.RobotDirection);

        }

        [Fact]
        public void Place_Valid_Robot_Command_South()
        {
            //Arrange
            var robot = new RobotModel();

            //Act
            PlaceCommand.InitRobot("place 1,1,south", robot);

            //Assert
            Assert.Equal(1, robot.RobotYPosition);
            Assert.Equal(1, robot.RobotXPostion);
            Assert.Equal("south", robot.RobotDirection);

        }

        [Fact]
        public void Place_Valid_Robot_Command_West()
        {
            //Arrange
            var robot = new RobotModel();

            //Act
            PlaceCommand.InitRobot("place 1,1,west", robot);

            //Assert
            Assert.Equal(1, robot.RobotYPosition);
            Assert.Equal(1, robot.RobotXPostion);
            Assert.Equal("west", robot.RobotDirection);

        }

        [Fact]
        public void Place_Valid_Robot_Command_Upper_Case()
        {
            //Arrange
            var robot = new RobotModel();

            //Act
            Assert.Throws<FormatException>(() => PlaceCommand.InitRobot("PLACE 1,1,NORTH", robot)) ;

            
        }

        [Fact]
        public void Place_Robot_Off_Table()
        {
            //Arrange
            var robot = new RobotModel();

            //Act
            PlaceCommand.InitRobot("place 6,6,west", robot);

            //Assert
            Assert.Equal(0, robot.RobotYPosition);
            Assert.Equal(0, robot.RobotXPostion);
            Assert.Null(robot.RobotDirection);

        }

        [Fact]
        public void Place_Robot_InValid_Direction()
        {
            //Arrange
            var robot = new RobotModel();

            //Act
            PlaceCommand.InitRobot("place 3,3,fake", robot);

            //Assert
            Assert.Equal(0, robot.RobotYPosition);
            Assert.Equal(0, robot.RobotXPostion);
            Assert.Null(robot.RobotDirection);

        }





    }
}

