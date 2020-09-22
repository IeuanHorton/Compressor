using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compressor
{
    class FirstFollowCompression
    {
        public byte[] compress(string imgLink)
        {   
            List<byte> compressed = new List<byte>();

            var bitmap = new Bitmap(imgLink);

            //Takes 2 bytes to find the width of the image
            byte[] width = BitConverter.GetBytes((ushort)bitmap.Width);
            foreach(byte part in width)
            {
                //compressed.Add(part);
            }

            Color masterPixel = bitmap.GetPixel(0, 0);
            byte count = 0;

            for (int y = 0; y < bitmap.Height; y++)
            {
                for(int x = 0; x < bitmap.Width; x++)
                {
                    //Grab the next pixel ✔️
                    //Hold a master till the pixel changes ✔️
                    //Record how many pixels it passes ✔️
                    //Throw it into the LIST ✔️

                    Color pixel = bitmap.GetPixel(x, y);

                    if(7 > masterPixel.R - pixel.R && masterPixel.R - pixel.R > -7 &&
                        7 > masterPixel.G - pixel.G && masterPixel.G - pixel.G > -7 &&
                        7 > masterPixel.B - pixel.B && masterPixel.B - pixel.B > -7)
                    {
                        count++;
                    }
                    else
                    {
                        compressed.Add(count);
                        compressed.Add(masterPixel.R);
                        compressed.Add(masterPixel.G);
                        compressed.Add(masterPixel.B);
                        masterPixel = pixel;
                        count = 1;
                    }
                }
            }

            return compressed.ToArray();
        }


    }
}
