using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlugSkráningarKerfiWPF
{
    public interface IAlertable
    {
        void DoAlert(string alert);
    }
}
