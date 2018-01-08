using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 真的好神電腦公司
    /// </summary>
    public class SenaoComputerStore : ComputerStore
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SenaoComputerStore()
        {
            this.Computer = new CustomComputer();
        }

        /// <summary>
        /// 裝CUP
        /// </summary>
        protected override void AddCup()
        {
            this.Computer.AddPart("【CUP】AMD Ryzen TR 1950X 3.4G");
        }

        /// <summary>
        /// 裝主機板
        /// </summary>
        protected override void AddMotherBoard()
        {
            this.Computer.AddPart("【主機板】技嘉 X399 AORUS Gaming 7");
        }

        /// <summary>
        /// 裝電源供應器
        /// </summary>
        protected override void AddPower()
        {
            this.Computer.AddPart("【電源供應器】海韻 PRIME SSR-850TR");
        }

        /// <summary>
        /// 裝記憶體
        /// </summary>
        protected override void AddMemory()
        {
            this.Computer.AddPart("【記憶體】金士頓 16G DDR4-2133");
        }

        /// <summary>
        /// 裝硬碟
        /// </summary>
        protected override void AddHardDisk()
        {
            this.Computer.AddPart("【硬碟】Intel 750系列 1.2TB U.2 固態硬碟");
        }
        
        /// <summary>
        /// 裝顯示卡
        /// </summary>
        protected override void AddVedioCard()
        {
            this.Computer.AddPart("【顯示卡】華碩 DUAL-GTX1060-O6G");
        }
    }
}
