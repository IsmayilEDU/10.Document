using Document.Models.AbsractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document.DocumentClasses
{
    internal class ExpertDocument : DOCUMENT
    {
        //  Virtual function of OpenDocument for ExpertDocument
        public override string OpenDocument()
        {
            return "ExpertDocument Opened";
        }

        //  Virtual function of EditDocument for ExpertDocument
        public override string EditDocument()
        {
            return "ExpertDocument Edited";
        }

        //  Virtual function of SaveDocument for ExpertDocument
        public override string SaveDocument()
        {
            return "ExpertDocument Saved";
        }
    }
}
