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

    [Fact]
    public void Move_Robot_North_Off_Table()
    {
        //Arrange
        var robot = new RobotModel { RobotXPostion = 0, RobotYPosition = 5, RobotDirection = "north" };

        //Act
        MoveCommand.MoveRobot(robot);

        //Assert
        Assert.Equal(5, robot.RobotYPosition);
        Assert.Equal(0, robot.RobotXPostion);
        Assert.Equal("north", robot.RobotDirection);

    }

    [Fact]
    public void Move_Robot_East()
    {
        //Arrange
        var robot = new RobotModel { RobotXPostion = 0, RobotYPosition = 0, RobotDirection = "east" };

        //Act
        MoveCommand.MoveRobot(robot);

        //Assert
        Assert.Equal(0, robot.RobotYPosition);
        Assert.Equal(1, robot.RobotXPostion);
        Assert.Equal("east", robot.RobotDirection);

    }

    [Fact]
    public void Move_Robot_East_Off_Table()
    {
        //Arrange
        var robot = new RobotModel { RobotXPostion = 5, RobotYPosition = 0, RobotDirection = "east" };

        //Act
        MoveCommand.MoveRobot(robot);

        //Assert
        Assert.Equal(0, robot.RobotYPosition);
        Assert.Equal(5, robot.RobotXPostion);
        Assert.Equal("east", robot.RobotDirection);

    }

    [Fact]
    public void Move_Robot_South()
    {
        //Arrange
        var robot = new RobotModel { RobotXPostion = 3, RobotYPosition = 3, RobotDirection = "south" };

        //Act
        MoveCommand.MoveRobot(robot);

        //Assert
        Assert.Equal(2, robot.RobotYPosition);
        Assert.Equal(3, robot.RobotXPostion);
        Assert.Equal("south", robot.RobotDirection);

    }

    [Fact]
    public void Move_Robot_South_Off_Table()
    {
        //Arrange
        var robot = new RobotModel { RobotXPostion = 0, RobotYPosition = 0, RobotDirection = "south"};

        //Act
        MoveCommand.MoveRobot(robot);

        //Assert
        Assert.Equal(0, robot.RobotYPosition);
        Assert.Equal(0, robot.RobotXPostion);
        Assert.Equal("south", robot.RobotDirection);

    }

    [Fact]
    public void Move_Robot_West()
    {
        //Arrange
        var robot = new RobotModel { RobotXPostion = 5, RobotYPosition = 0, RobotDirection = "west" };

        //Act
        MoveCommand.MoveRobot(robot);

        //Assert
        Assert.Equal(0, robot.RobotYPosition);
        Assert.Equal(4, robot.RobotXPostion);
        Assert.Equal("west", robot.RobotDirection);

    }

    [Fact]
    public void Move_Robot_West_Off_Table()
    {
        //Arrange
        var robot = new RobotModel { RobotXPostion = 0, RobotYPosition = 0, RobotDirection = "west" };

        //Act
        MoveCommand.MoveRobot(robot);

        //Assert
        Assert.Equal(0, robot.RobotYPosition);
        Assert.Equal(0, robot.RobotXPostion);
        Assert.Equal("west", robot.RobotDirection);

    }

    [Fact]
    public void InValid_Direction()
    {
        //Arrange
        var robot = new RobotModel { RobotDirection = "fake" };

        //Act

        Assert.Throws<Exception>(() => MoveCommand.MoveRobot(robot));

    }

}
