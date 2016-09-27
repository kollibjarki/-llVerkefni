using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeColor
{
    public interface IAlertable
    {
        /// <summary>
        /// Do this when the alarm has gone off.
        /// </summary>
        /// <param name="alert">Alarm message</param>
        void DoAlert(string alert);
    }
}
