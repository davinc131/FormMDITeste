using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Models
{
    public class WorkPackage
    {
        public int id { get; set; }
        public int type { get; set; }
        public int projectid { get; set; }
        public string subject { get; set; }
        public Description description { get; set; }
        public DateTime dueDate { get; set; }
        public int categoryid { get; set; }
        public int statusid { get; set; }
        public int assignedtoid { get; set; }
        public int priorityid { get; set; }
        public int fixedversionid { get; set; }
        public int autorid { get; set; }
        public int lockversion { get; set; }
        public int doneratio { get; set; }
        public int parentid { get; set; }
        public int responsibleid { get; set; }
        public int rootid { get; set; }
        public DateTime startDate { get; set; }
        public double estimatedhours { get; set; }
        public int percentageDone { get; set; }
        public TimeSpan createdAt { get; set; }
        public TimeSpan updateAt { get; set; }
        public int lft { get; set; }
        public int rgt { get; set; }
    }
}
