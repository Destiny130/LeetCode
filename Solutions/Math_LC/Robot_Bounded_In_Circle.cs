namespace Solutions.Math_LC
{
    public class Robot_Bounded_In_Circle
    {
        /*
        On an infinite plane, a robot initially stands at (0, 0) and faces north.  The robot can receive one of three instructions:
            "G": go straight 1 unit;
            "L": turn 90 degrees to the left;
            "R": turn 90 degress to the right.
        The robot performs the instructions given in order, and repeats them forever.

        Return true if and only if there exists a circle in the plane such that the robot never leaves the circle.
        */

        public bool IsRobotBounded(string instructions)
        {
            int[] point = new int[2];
            int[] step = new int[] { 0, 1 };
            for (int i = 0; i < 4; ++i)
            {
                foreach (char c in instructions)
                {
                    if (c == 'G')
                    {
                        point[0] += step[0];
                        point[1] += step[1];
                    }
                    else if (c == 'L')
                    {
                        if (step[0] == 0)
                        {
                            step[0] = -step[1];
                            step[1] = 0;
                        }
                        else {
                            step[1] = step[0];
                            step[0] = 0;
                        }
                    }
                    else {
                        if (step[0] == 0)
                        {
                            step[0] = step[1];
                            step[1] = 0;
                        }
                        else {
                            step[1] = -step[0];
                            step[0] = 0;
                        }
                    }
                }
            }

            return point[0] == 0 && point[1] == 0;
        }

        static int[][] dirs = new int[][] { new int[] { 0, 1 }, new int[] { -1, 0 }, new int[] { 0, -1 }, new int[] { 1, 0 } };

        public bool IsRobotBounded_OneScan(string instructions)
        {
            int[] point = new int[2];
            int i = 0;
            foreach (char c in instructions)
            {
                if (c == 'G')
                {
                    point[0] += dirs[i][0];
                    point[1] += dirs[i][1];
                }
                else if (c == 'L')
                {
                    i = (i + 1) % 4;
                }
                else
                {
                    i = (i + 3) % 4;
                }
            }
            return point[0] == 0 && point[1] == 0 || i > 0;
        }
    }
}
