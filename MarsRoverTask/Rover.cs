using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverTask
{
  public class Rover
    {
        public int coordinateX;
        public int coordinateY;
        public string orientationDirection;
        public Rover(string location)
        {
            int.TryParse(location.Split(" ")[0], out coordinateX);
            int.TryParse(location.Split(" ")[1], out coordinateY);
            orientationDirection = location.Split(" ")[2];
        }

        public void SpinLeft()
        {
            switch(orientationDirection)
            {
                case "N":
                    orientationDirection = "W";
                    break;
                case "E":
                    orientationDirection = "N";
                    break;
                case "S":
                    orientationDirection = "E";
                    break;
                case "W":
                    orientationDirection = "S";
                    break;
                default:
                    throw new ArgumentException();
            }
        }       

        public void SpinRight()
        {
            switch (orientationDirection)
            {
                case "N":
                    orientationDirection = "E";
                    break;
                case "E":
                    orientationDirection = "S";
                    break;
                case "S":
                    orientationDirection = "W";
                    break;
                case "W":
                    orientationDirection = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void MoveStep()
        {
            switch (orientationDirection)
            {
                case "N":
                    coordinateY += 1;
                    break;
                case "E":
                    coordinateX += 1;
                    break;
                case "S":
                    coordinateY -= 1;
                    break;
                case "W":
                    coordinateX -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void Move(string instructions)
        {
            char[] instructionSteps = instructions.ToCharArray();
            for (int i = 0; i < instructionSteps.Length; i++)
            {
                switch (instructionSteps[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        MoveStep();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

    }
}
