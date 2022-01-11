using System.Reflection;
using System.Runtime.InteropServices;

namespace HtmlToPDFCore
{
    public class PageMargins
    {
        public int top {get; set;}
        public int right {get; set;}
        public int bottom {get; set;}
        public int left {get; set; }

        public PageMargins(int pTop, int pRight, int pBottom, int pLeft)
        {
            top = pTop;
            right = pRight;
            bottom = pBottom;
            left = pLeft;
        }
    }
}
