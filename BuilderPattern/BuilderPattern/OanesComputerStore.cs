using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 神好的真電腦公司
    /// </summary>
    public class OanesComputerStore : ComputerStore
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public OanesComputerStore()
        {
            this.Computer = new CustomComputer();
        }

        /// <summary>
        /// 裝CUP
        /// </summary>
        protected override void AddCup()
        {
            this.Computer.AddPart("【CUP】Intel i9-7960X 2.8G");
        }

        /// <summary>
        /// 裝主機板
        /// </summary>
        protected override void AddMotherBoard()
        {
            this.Computer.AddPart("【主機板】華碩 STRIX X399-E GAMING");
        }

        /// <summary>
        /// 裝電源供應器
        /// </summary>
        protected override void AddPower()
        {
            this.Computer.AddPart("【電源供應器】全漢 皇鈦極PT 1200W");
        }

        /// <summary>
        /// 裝記憶體
        /// </summary>
        protected override void AddMemory()
        {
            this.Computer.AddPart("【記憶體】芝奇 G.SKILL Ripjaws V 16G");
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
            this.Computer.AddPart("【顯示卡】EVGA GTX1070 FTW GAMING ACX 3.0(");
        }
    }
}
