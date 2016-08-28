using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication61
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        void M1()
        {
            var currentGroupId = GetGroup("A");
            F1(currentGroupId);
            F2(currentGroupId);

            var groupB = GetGroup("B");
            F3(groupB);
        }

        private int GetGroup(string p0)
        {
            throw new NotImplementedException();
        }

        void F1(int groupId){}
        void F2(int groupId){}
        void F3(int groupId){}
    }
}
