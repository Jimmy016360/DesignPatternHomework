using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class ComputerStore : IComputerStore
    {
        /// <summary>
        /// 組裝電腦
        /// </summary>
        protected CustomComputer Computer;

        /// <summary>
        /// 裝CUP
        /// </summary>
        protected abstract void AddCup();

        /// <summary>
        /// 裝主機板
        /// </summary>
        protected abstract void AddMotherBoard();

        /// <summary>
        /// 裝電源供應器
        /// </summary>
        protected abstract void AddPower();

        /// <summary>
        /// 裝記憶體
        /// </summary>
        protected abstract void AddMemory();

        /// <summary>
        /// 裝硬碟
        /// </summary>
        protected abstract void AddHardDisk();

        /// <summary>
        /// 裝顯示卡
        /// </summary>
        protected abstract void AddVedioCard();

        /// <summary>
        /// 組裝
        /// </summary>
        public virtual CustomComputer CustomBuild()
        {
            this.AddCup();
            this.AddMotherBoard();
            this.AddPower();
            this.AddMemory();
            this.AddHardDisk();
            this.AddVedioCard();

            return Computer;
        }

    }
}
