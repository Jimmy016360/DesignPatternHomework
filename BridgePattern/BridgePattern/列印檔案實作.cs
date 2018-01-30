using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 列印檔案實作
    /// </summary>
    public class 列印檔案實作 : 列印文件實作
    {
        /// <summary>
        /// 欲列印的字串
        /// </summary>
        private readonly string 字串;
        
        /// <summary>
        /// 檔案IO
        /// </summary>
        private FileStream FileStream;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="字串">欲列印的字串</param>
        public 列印檔案實作(string 字串)
        {
            this.字串 = 字串;
        }

        /// <summary>
        /// 列印
        /// </summary>
        public override void 列印()
        {
            Byte[] info = new UTF8Encoding(true).GetBytes(this.字串);
            // Add some information to the file.
            this.FileStream.Write(info, 0, info.Length);
        }

        /// <summary>
        /// 開啟
        /// </summary>
        public override void 開啟()
        {
            string path = Path.GetTempFileName();
            this.FileStream = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None);
        }

        /// <summary>
        /// 關閉
        /// </summary>
        public override void 關閉()
        {
            this.FileStream.Flush();
            this.FileStream.Dispose();
        }
    }
}
