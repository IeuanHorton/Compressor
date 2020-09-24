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
        int lossyAmount = 1;

        public void SetLevel(int i)
        {
            lossyAmount = i;
        }

        public byte[] Compress(string imgLink)
        {   
            List<byte> compressed = new List<byte>();

            var bitmap = new Bitmap(imgLink);

            //Takes 2 bytes to find the width of the image
            byte[] width = BitConverter.GetBytes((ushort)bitmap.Width);
            foreach(byte part in width)
            {
                compressed.Add(part);
            }

            byte[] height = BitConverter.GetBytes((ushort)bitmap.Height);
            foreach (byte part in height)
            {
                compressed.Add(part);
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

                    if(lossyAmount > masterPixel.R - pixel.R && masterPixel.R - pixel.R > -lossyAmount &&
                        lossyAmount > masterPixel.G - pixel.G && masterPixel.G - pixel.G > -lossyAmount &&
                        lossyAmount > masterPixel.B - pixel.B && masterPixel.B - pixel.B > -lossyAmount)
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
        public Bitmap Decompress(byte[] compressedImage)
        {
            //Creates width and height byte arrays
            byte[] widthArray = new byte[2]; widthArray[0] = compressedImage[0]; widthArray[1] = compressedImage[1];
            byte[] heightArray = new byte[2]; heightArray[0] = compressedImage[2]; heightArray[1] = compressedImage[3];

            //Creates the bitmap
            int width = BitConverter.ToUInt16(widthArray, 0);
            int height = BitConverter.ToUInt16(heightArray, 0);
            Bitmap image = new Bitmap(width, height);

            //Index of 4 to skip the width and height parameters
            int index = 4;
            int count = 0;
            Color pixel = new Color();

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    //If the next colour should be selected
                    if (count == 0)
                    {
                        //Resets count and the pixel colour
                        count = compressedImage[index];
                        index++;
                        pixel = Color.FromArgb(255, compressedImage[index], compressedImage[index+1], compressedImage[index+2]);
                        index++;
                        index++;
                        index++;
                    }

                    //Sets the pixel
                    image.SetPixel(x, y, pixel);
                    count--;
                }
            }

            return image;
        }
    }
}
