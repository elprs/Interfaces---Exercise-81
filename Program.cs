using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

   interface A //einai ena sumboleiao. den einai class. einai upografi sumbolaiou.  opos mia polisi spitiou. e enaw exei spi, o allos lefta, kai mia methodo na mou dosseis kai na parv lefta. 
    {//px eimai mia cocacola kai thelo n ampo sto psigeio. an mporousa n aupigrapso to sumbolaio psigeio tha mporo na maino sto psigeio. 
        //inteface : tipos dedomenon
        //dne exei tipota os implementation, dinei mono diatages : tha prpei n aexeis spiti, 8a prpeei na exeis lefta ktl
        //intefrce: kathorizei autes ti sidiotites

    //int age; //den mporo na balo
        int  MyProperty { get; set; }
    
        //opoios to upograpsei kai susxeitstei me to symboleio A PREPEI na efarmosei o,ti leei to sumbolaio
        //den ton endiaferei OSTOSO to access modifier pou th abaleis(public, private...ktl)

        void Output(); // ara OLOI sa prpei na exetai mia void Output(); leei to sumbolaio

        int Calc(int a, int b); //ama thes n at apame kala tha prpeei na exeis auti ti methodo esi pou tha sisxetissteis mazi mou

        void GetInTheFridge();
    }

    class B : A //ara o B pupografei to sumboleio A//tha prpeei na efarmoseis to to to to 
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Calc(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void GetInTheFridge()
        {
            throw new NotImplementedException();
        }

        public void Output()
        {
            throw new NotImplementedException();
        }






        interface C
        {
            void GetInDrawer();
        }

        class D
            : C, A // mporeis na upogtapseis polla sumbolaioa alla panta klironomeis mia concrete i mia abstrsact class
        {
            public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int Calc(int a, int b)
            {
                throw new NotImplementedException();
            }

            public void GetInDrawer()
            {
                throw new NotImplementedException();
            }

            public void GetInTheFridge()
            {
                throw new NotImplementedException();
            }

            public void Output()
            {
                throw new NotImplementedException();
            }
        }
    }

   

}
