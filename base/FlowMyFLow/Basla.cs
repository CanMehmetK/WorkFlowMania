using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase;

namespace FlowMyFLow
{
    public class Basla : BaseEleman
    {
        public Basla()
        {
            this.Tip = ElemanTip.Basla;
            this.Id = Guid.NewGuid();
            this.userindeCalisilanNesne = new ExpandoObject();
            this.userindeCalisilanNesne.baslama = DateTime.Now;
            var t = this.toJson();
        }
    }
}
