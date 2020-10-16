using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTEst.model
{
    public class MathModel
    {
        public int doAddition(int iOperant1, int iOperant2)
        {
            return iOperant1 + iOperant2;            
        }

        public int doSubtraktion(int iOperant1, int iOperant2)
        {
            return iOperant1 - iOperant2;
        }

        public int doMultiplikation(int iOperant1, int iOperant2)
        {
            return iOperant1 * iOperant2;
        }

        public int doDivision(int iOperant1, int iOperant2)
        {
            return iOperant1 / iOperant2;
        }

    }
}
