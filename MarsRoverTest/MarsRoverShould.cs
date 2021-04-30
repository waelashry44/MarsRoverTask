using MarsRoverTask;
using System;
using Xunit;

namespace MarsRoverTest
{
    public class MarsRoverShould
    {
        [Fact]
        public void SpinLeft()
        {
            Rover rover = new Rover("1 2 N");
            rover.SpinLeft();
            Assert.Equal("W", rover.orientationDirection);
        }

        [Fact]
        public void SpinRight()
        {
            Rover rover = new Rover("1 2 N");
            rover.SpinRight();
            Assert.Equal("E", rover.orientationDirection);
        }

        [Fact]
        public void MoveStep()
        {
            Rover rover = new Rover("1 2 N");
            rover.MoveStep();
            Assert.Equal(3, rover.coordinateY);
        }

        [Fact]
        public void Move()
        {
            Rover rover = new Rover("1 2 N");
            rover.Move("LMLMLMLMM");
            Assert.Equal("1 3 N", rover.coordinateX + " " + rover.coordinateY + " " + rover.orientationDirection);

            // Rover rover = new Rover("3 3 E");
            // rover.Move("MMRMMRMRRM");
            //Assert.Equal("5 1 E", rover.coordinateX + " " + rover.coordinateY + " " + rover.orientationDirection);
        }
    }
}
