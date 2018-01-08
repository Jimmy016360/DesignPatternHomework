using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 電腦組裝店家介面
    /// </summary>
    public interface IComputerStore
    {
        /// <summary>
        /// 組裝電腦
        /// </summary>
        CustomComputer CustomBuild();
    }
}
