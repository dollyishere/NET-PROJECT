using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class ClsInfo
    {
        public int ClsNum { get; set; }
        public string ClsName { get; set; }

        public override string ToString()
        {
            return ClsName;
        }


        // 수정 여부 확인
        public bool IsDirty { get; set; } = false;

        public int imageIndex
        {
            get { return ClsNum; }
        }
    }

}
