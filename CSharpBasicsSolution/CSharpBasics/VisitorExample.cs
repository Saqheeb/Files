using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBasics.VisitorsEntities;

namespace CSharpBasics
{

    namespace VisitorsEntities
    {
        enum stat { inside =1,outside};
        class Visitor
        {
            public long visitorId { get; set; }
            public string visitorName { get; set; }
            public string visitorEmail { get; set; }
            public long visitorPhone { get; set; }
            public string hostName { get; set; }
            public DateTime entryTime { get; set; }
            public DateTime exitTime { get; set; }
            public stat status { get; set; }
        }
    }

    namespace Repository
    {
        class VisitorRepo
        {
            private static long uniqueValue = 614343642;
            private VisitorsEntities.Visitor[] visitDb;

            public VisitorRepo(int size)
            {
                visitDb = new Visitor[size];
                //visitDb[0] = new Visitor{ visitorId = generateId(), visitorName = "Saqheeb", visitorEmail = "saqheeb@gmail.com", visitorPhone = 9071156280, hostName = "Seemabhat", entryTime = DateTime.MinValue, exitTime = DateTime.MinValue, status = stat.outside };
                //visitDb[1] = new Visitor{ visitorId = generateId(), visitorName = "Sahil", visitorEmail = "sahil@gmail.com", visitorPhone = 9071164560, hostName = "Rupali", entryTime = DateTime.MinValue, exitTime = DateTime.MinValue, status = stat.outside };

            }

            private long generateId()
            {
                //throw new NotImplementedException();
                return uniqueValue++;
            }

            public VisitorRepo() : this(0) //calls constructor in line 29.This is default constructor.
            {

            }

            private Visitor copy(Visitor copy)
            {
                var vis = new Visitor();
                vis.visitorId = copy.visitorId;
                vis.visitorName = copy.visitorName;
                vis.visitorEmail = copy.visitorEmail;
                vis.visitorPhone = copy.visitorPhone;
                vis.hostName = copy.hostName;
                return vis;
            }

            public void addNewVisitor(Visitor vis)
            {
                for (int i = 0; i < visitDb.Length; i++)
                {
                    if (visitDb[i] == null)
                    {
                        visitDb[i] = copy(vis);
                        return;
                    }
                }
                Console.WriteLine("No more employees cna be added!!!");
            }


        }

        internal class VisitorExample
        {
            static string MENU = "---------------------VISITOR MENU---------------\r\n" +
                "ADD VISITOR------------------> PRESS 1\r\n" +
                "UPDATE VISITOR---------------> PRESS 2\r\n" +
                "REPORT-----------------------> PRESS 3\r\n------------------------------------------------";
            static VisitorRepo repo = null;
            private static long uniqueValue = 614343642;

            static void Main(string[] args)
            {
                repo = new VisitorRepo(5);

                bool processing = true;
                do
                {
                    Console.WriteLine(MENU);
                    int choice = MyConsole.getNumber(MENU);
                    processing = processMenu(choice);
                } while (processing);
            }

            private static bool processMenu(int choice)
            {
                switch (choice)
                {
                    case 1:
                        addVisitor();
                        return true;
                    case 2:
                        updateVisitor();
                        return true;
                    case 3:
                        generateReport();
                        return true;
                    default:
                        return false;
                }
            }

            private static void generateReport()
            {
                throw new NotImplementedException();
            }

            private static void updateVisitor()
            {
                throw new NotImplementedException();
            }

            private static void addVisitor()
            {
                var vis = new Visitor();
                vis.visitorId = generateId();
                vis.visitorName = MyConsole.getString("Enter the Visitor's Name: ");
                vis.visitorEmail = MyConsole.getString("Enter the Visitor's Email: ");
                vis.visitorPhone = MyConsole.getLong("Enter the Visitor's Phone Number: ");
                vis.hostName = MyConsole.getString("Enter the host's Name: ");
                vis.entryTime = DateTime.MinValue;
                vis.exitTime = DateTime.MinValue;
                vis.status = stat.outside;
                repo.add
            }
            private static long generateId()
            {
                //throw new NotImplementedException();
                return uniqueValue++;
            }
        }

    }

    
}
