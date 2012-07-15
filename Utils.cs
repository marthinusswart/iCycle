using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace iCycle
{
    public class Utils
    {

		#region Methods (1) 


		// Public Methods (1) 

        public static Image LoadImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            ms.Position = 0;
            Bitmap bmp = new Bitmap(ms);
            return bmp;
        }


		#endregion Methods 

    }
}
