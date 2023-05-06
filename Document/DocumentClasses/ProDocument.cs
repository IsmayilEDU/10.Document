using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document.Models.AbsractClasses;

namespace Document.Models
{
    internal class ProDocument : DOCUMENT
    {
        //  Virtual function of OpenDocument for ProDocument
        public override string OpenDocument()
        {
            return "ProDocument Opened";
        }

        //  Virtual function of EditDocument for ProDocument
        public override string EditDocument()
        {
            return "ProDocument Edited";
        }

        //  Virtual function of SaveDocument for ProDocument
        public override string SaveDocument()
        {
            return "ProDocument Saved";
        }
    }
}
