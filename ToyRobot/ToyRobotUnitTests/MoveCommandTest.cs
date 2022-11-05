using ToyRobotMain.Core;

namespace ToyRobotUnitTests;

public class MoveCommandTest
{
    [Fact]
    public void Move_Robot_North()
    {
        //Arrange
        var robot = new RobotModel { RobotXPostion = 0 , RobotYPosition = 0, RobotDirection = "north"};

        //Act
        MoveCommand.MoveRobot(robot);

        //Assert
        Assert.Equal(1, robot.RobotYPosition);
        Assert.Equal(0, robot.RobotXPostion);
        Assert.Equal("north",robot.RobotDirection);

    }
}
