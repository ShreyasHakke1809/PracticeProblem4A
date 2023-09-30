using NLog;

namespace PracticeProblem
{
    public class NLog
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static void Addition(int x, int y)
        {
            int sum = 0;
            if (x <= 0 || y <= 0)
            {
                logger.Warn("Input should greater than zero");
                logger.Error("Number should +ve");
            }
            else
            {
                sum = x + y;
                logger.Info("Successfully added numbers {0}", sum);
            }
        }
    }
}
