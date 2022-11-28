namespace _12_CS_Graphics
{
    public class RenderText
    {
        private string strName;
        public string Name 
        {
            get { return strName; }
            set { strName = value; }
        }

        private string strText;
        public string Text
        {
            get { return strText; }
            set { strText = value; }
        }

        private int iX;
        public int X
        {
            get { return iX; }
            set { iX = value; }
        }

        private int iY;
        public int Y
        {
            get { return iY; }
            set { iY = value; }
        }

        private int iSize;
        public int Size
        {
            get { return iSize; }
            set { iSize = value; }
        }

        public RenderText() : this("NoName")
        {
        }

        public RenderText(string strNm)
        {
            /* Default values */
            strText = "";
            iX = 0;
            iY = 0;
            iSize = 12;

            if (strNm == null || strNm.Length == 0)
                strName = "NoName";
            else
                strName = strNm;
        }
    }
}
