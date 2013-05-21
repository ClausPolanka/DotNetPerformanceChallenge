using System;
using System.Text;

namespace DotNetPerformanceChallenge.CodeA
{
    public class GetRoutingDetails
    {
        public static void Main(string[] args)
        {
            StringBuilder strRouteList = new StringBuilder();
            int totalNodeCount = 0;
            for (int routNumber = 0; routNumber < 126; routNumber++)
            {
                int nodeCount = 0;
                for (int infoNumber = 0; infoNumber < 125; infoNumber++)
                {
                    String fromLocation = "YYZ";
                    String toLocation = "" + infoNumber;
                    totalNodeCount++;
                    if (nodeCount != 0)
                    {
                        if (strRouteList.ToString().Length == 0)
                            strRouteList.Append(fromLocation + toLocation);
                        else
                            strRouteList.Append("|" + fromLocation + toLocation);
                        strRouteList.Append("\n");
                    }
                    nodeCount++;
                }
            }
            Console.Out.WriteLine(strRouteList.ToString());
            Console.Out.WriteLine("Node Count:{0}", totalNodeCount);
        }
    }
}