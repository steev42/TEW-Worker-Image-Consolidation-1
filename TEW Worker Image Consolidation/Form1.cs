using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEW_Worker_Image_Consolidation
{
    // Final Name Format?
    // Worker Name - Subfolders - Creator
    // Root folder names should be the LAST part of the file name.

    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsolidate_Click(object sender, EventArgs e)
        {
            if (txtDestination.Text.EndsWith("\\") == false)
                txtDestination.Text = txtDestination.Text + "\\";
            if (txtRoot.Text.EndsWith("\\") == false)
                txtRoot.Text = txtRoot.Text + "\\";

            if (Directory.Exists(txtDestination.Text) == false)
            {
                MessageBox.Show("The destination directory must already exist.");
                //throw new FileNotFoundException("The destination directory must already exist.");
                return;
            }

            string[] authors = Directory.GetDirectories(txtRoot.Text);

            //foreach (string author in authors)
            for (int i = 0; i < 1; i++)
            {
                string author = authors[0];
                string creatorName = Path.GetFileName(author);
                //MessageBox.Show("Recursing to " + author);
                getAllFilesInDirectory(author, creatorName);
            }

            MessageBox.Show("Consolidation Complete!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="creatorName"></param>
        private void getAllFilesInDirectory(string path, string creatorName)
        {
            //MessageBox.Show("getAllFilesInDirectory(" + path + "," + creatorName);
            string[] subfolders = Directory.GetDirectories(path);
            foreach (string folder in subfolders)
            {
                //MessageBox.Show("Looking at " + folder);
                List<string> pathListing = new List<string>();
                getAllFilesInDirectory(folder, creatorName, pathListing);
            }

            string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly).
                Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png") || s.EndsWith(".gif")).ToArray();
            if (files.Count() > 0)
            {
                MessageBox.Show("Root author directory " + creatorName + " contains images that cannot be renamed.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="creatorName"></param>
        /// <param name="pathListing"></param>
        private void getAllFilesInDirectory(string path, string creatorName, List<string> pathListing)
        {
            //MessageBox.Show("getAllFilesInDirectory(" + path + "," + creatorName + ", ancestors");
            pathListing.Add(Path.GetFileName(path).ToLower());
            string[] subfolders = Directory.GetDirectories(path);
            foreach (string folder in subfolders)
            {
                //MessageBox.Show("Recursing to " + folder);
                getAllFilesInDirectory(folder, creatorName, pathListing);
            }

            string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly).
                Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png") || s.EndsWith(".gif")).ToArray();
            int altCount = 1;
            foreach (string file in files)
            {
                //MessageBox.Show("Looking at file " + file);
                string destinationFileName = txtDestination.Text;

                foreach (string ancestor in pathListing)
                {
                    if (destinationFileName != txtDestination.Text)
                    {
                        destinationFileName = destinationFileName + " - ";
                    }

                    destinationFileName = destinationFileName + ancestor;
                }
                destinationFileName = destinationFileName + "_" + altCount++ + " - " + creatorName;


                byte[] imageData = File.ReadAllBytes(file);
                // Load image here so we only have to read it once.
                using (var stream = new MemoryStream(imageData))
                {
                    var image = Image.FromStream(stream);
                    if ((image.RawFormat.Equals(ImageFormat.Jpeg) && chkJpgToGif.Checked))
                    {
                        SaveAsGIF(image, file, destinationFileName, chkJpgToGifResize.Checked, chkJpgToGifBG.Checked);
                    }
                    if (image.RawFormat.Equals(ImageFormat.Png) && chkPngToGif.Checked)
                    {
                        SaveAsGIF(image, file, destinationFileName, chkPngToGifResize.Checked, chkPngToGifBG.Checked);
                    }

                    if (image.RawFormat.Equals(ImageFormat.Gif) && chkGifToGif.Checked)
                    {
                        SaveAsGIF(image, file, destinationFileName, chkGifToGifResize.Checked, chkGifToGifBG.Checked);
                    }

                    if ((image.RawFormat.Equals(ImageFormat.Jpeg) && chkJpgToJpg.Checked))
                    {
                        SaveAsJPG(image, file, destinationFileName, chkJpgToJpgResize.Checked, false); // Can't add BG to full image.
                    }
                    if (image.RawFormat.Equals(ImageFormat.Png) && chkPngToJpg.Checked)
                    {
                        SaveAsJPG(image, file, destinationFileName, chkPngToJpgResize.Checked, chkPngToJpgBG.Checked);
                    }

                    if (image.RawFormat.Equals(ImageFormat.Gif) && chkGifToJpg.Checked)
                    {
                        SaveAsJPG(image, file, destinationFileName, chkGifToJpgResize.Checked, chkGifToJpgBG.Checked);
                    }

                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceImage"></param>
        /// <param name="sourceFile"></param>
        /// <param name="destination"></param>
        /// <param name="resize"></param>
        /// <param name="includeBackground"></param>
        private void SaveAsGIF(Image sourceImage, string sourceFile, string destination, bool resize, bool includeBackground)
        {
            ConvertToGif(sourceImage, destination + ".gif", resize, includeBackground);
            // Not yet implemented.
            //MessageBox.Show("Can't copy to gif.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceImage"></param>
        /// <param name="sourceFile"></param>
        /// <param name="destination"></param>
        /// <param name="resize"></param>
        /// <param name="includeBackground"></param>
        private void SaveAsJPG(Image sourceImage, string sourceFile, string destination, bool resize, bool includeBackground)
        {
            //MessageBox.Show("Moving " + source + "\n to \n" + destination + ".jpg");
            /*if (isImageInExpectedFormat(sourceImage)) // Is a square 150x150 JPG
            {
                try
                {
                    File.Copy(sourceFile, destination + ".jpg");
                }
                catch (Exception e)
                {
                    // Do nothing for now, just silently move on to next file.
                }
            }
            else
            {*/
            //MessageBox.Show("Converting " + sourceFile + " to tew jpg");
            ConvertToJpg(sourceImage, destination + ".jpg", resize, includeBackground);
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private Image ResizeImage(Image source)
        {
            if (source.Width != source.Height)
            {
                throw new ConstraintException("Can only resize square images.");
            }
            return source.GetThumbnailImage(150, 150, null, IntPtr.Zero);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private Color getNonExistentColor(Image source)
        {
            if (source.Width != 150 || source.Height != 150)
            {
                throw new ConstraintException("Can only remove background from images that are 150x150px");
            }

            var sourceBitmap = new Bitmap(source);
            List<Color> colorsFound = new List<Color>();

            for (int i = 0; i < 150; i++)
            {
                for (int j = 0; j < 150; j++)
                {
                    Color imgColor = sourceBitmap.GetPixel(i, j);
                    if (colorsFound.Contains(imgColor) == false)
                        colorsFound.Add(imgColor);
                }
            }

            bool[] reds = new bool[256];
            bool[] blues = new bool[256];
            bool[] greens = new bool[256];

            for (int i = 0; i < 256; i++)
            {
                reds[i] = blues[i] = greens[i] = false;
            }

            foreach (Color c in colorsFound)
            {
                reds[c.R] = true;
                blues[c.B] = true;
                greens[c.G] = true;
            }

            int r = -1;
            int g = -1;
            int b = -1;

            for (int i = 0; i < 256; i++)
            {
                if (r == -1 && reds[i] == false)
                    r = i;
                if (b == -1 && blues[i] == false)
                    b = i;
                if (g == -1 && greens[i] == false)
                    g = i;

                if (r >= 0 && g >= 0 && b >= 0)
                    return Color.FromArgb(r, g, b);
            }

            return Color.Transparent;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private Image RemoveBackground(Image source, Color makeTransparent)
        {
            if (source.Width != 150 || source.Height != 150)
            {
                throw new ConstraintException("Can only remove background from images that are 150x150px");
            }
            //MessageBox.Show("Removing background...");

            //byte[] bgImage = File.ReadAllBytes(txtBackground.Text);
            var sourceBitmap = new Bitmap(source);
            //MessageBox.Show(sourceBitmap.PixelFormat.ToString());
            var bgBitmap = new Bitmap(txtBackground.Text);
            for (int i = 0; i < 150; i++)
            {
                for (int j = 0; j < 150; j++)
                {
                    Color bgColor = bgBitmap.GetPixel(i, j);
                    Color imgColor = sourceBitmap.GetPixel(i, j);
                    //if (i == j)
                    //MessageBox.Show("Pixel at " + i + "," + j + " is " + imgColor.ToString() + " in image, and " + bgColor.ToString() + " in background.");

                    if ((bgColor.R==imgColor.R && bgColor.G==imgColor.G && bgColor.B==imgColor.B) || imgColor.Equals(Color.Transparent))
                    {
                        sourceBitmap.SetPixel(i, j, makeTransparent);
                    }
                }
            }

            return sourceBitmap;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private Image AddBackground(Image source)
        {
            if (source.Width != 150 || source.Height != 150)
            {
                throw new ConstraintException("Can only add background to images that are 150x150px");
            }
            var bitmap = new Bitmap(150, 150);
            using (var g = Graphics.FromImage(bitmap))
            {
                byte[] bgImage = File.ReadAllBytes(txtBackground.Text);
                using (var bgstream = new MemoryStream(bgImage))
                {
                    var bg = Image.FromStream(bgstream);
                    g.DrawImage(bg, 0, 0);
                    g.DrawImage(source, 0, 0);
                }
            }

            return bitmap;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="resize"></param>
        /// <param name="includeBackground"></param>
        private void ConvertToJpg(Image source, string destination, bool resize, bool includeBackground)
        {
            if (resize == true && source.Width == source.Height)
            {
                // Resize Image
                var resizedImage = ResizeImage(source);
                if (includeBackground)
                {
                    resizedImage = AddBackground(resizedImage);
                }

                // Save as new JPG
                resizedImage.Save(destination, ImageFormat.Jpeg);
               /* using (var thumbnailStream = new MemoryStream())
                {
                    resizedImage.Save(thumbnailStream, ImageFormat.Jpeg);
                    try
                    {
                        File.WriteAllBytes(destination, thumbnailStream.ToArray());
                    }
                    catch (Exception e)
                    {
                        // Do nothing for now, just silently ignore and move on to next file.
                    }
                }*/
            }
            else
            {
                source.Save(destination, ImageFormat.Jpeg);
                //MessageBox.Show("Unable to convert to TEW Jpg; image must be a square.");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="resize"></param>
        /// <param name="includeBackground"></param>
        private void ConvertToGif(Image source, string destination, bool resize, bool includeBackground)
        {

            if (resize == true && source.Width == source.Height)
            {
                // Resize Image
                var resizedImage = ResizeImage(source);
                if (includeBackground)
                {
                    resizedImage = AddBackground(resizedImage);
                    resizedImage.Save(destination, ImageFormat.Gif);
                }
                else
                {
                    Color makeTransparent = getNonExistentColor(resizedImage);

                    resizedImage = RemoveBackground(resizedImage, makeTransparent);
                    var bitmap = new Bitmap(resizedImage);
                    resizedImage = MakeTransparentGif(bitmap, makeTransparent);
                    resizedImage.Save(destination, ImageFormat.Gif);
                }
            }
            else
            {
                source.Save(destination, ImageFormat.Gif);
                //MessageBox.Show("Unable to convert to TEW Jpg; image must be a square.");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private bool isImageInExpectedFormat(Image image)
        {
            if (image.Height == 150 && image.Width == 150)
            {
                // Yep, right size all right.  Is it a jpg?
                if (isImageJpg(image))
                {
                    return true;
                }
                // Check for gifs...
                else
                {
                    //MessageBox.Show("Not a JPG");
                    return false;
                }
            }
            // Wrong size!
            //MessageBox.Show("Not 150x150; is actually " + image.Height + "x" + image.Width);
            return false;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private bool isImageJpg(Image image)
        {
            if (image.RawFormat.Equals(ImageFormat.Jpeg))
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkJpgToJpgResize_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkPngToJpgResize_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPngToJpgResize.Checked == false)
            {
                chkPngToJpgBG.Enabled = false;
                chkPngToJpgBG.Checked = false;
            }
            else
            {
                chkPngToJpgBG.Enabled = true;
                chkPngToJpgBG.Checked = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkPngToGifResize_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPngToGifResize.Checked == false)
            {
                chkPngToGifBG.Enabled = false;
                chkPngToGifBG.Checked = false;
            }
            else
            {
                chkPngToGifBG.Enabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkGifToJpgResize_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGifToJpgResize.Checked == false)
            {
                chkGifToJpgBG.Enabled = false;
                chkGifToJpgBG.Checked = false;
            }
            else
            {
                chkGifToJpgBG.Enabled = true;
                chkGifToJpgBG.Checked = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkGifToGifResize_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGifToGifResize.Checked == false)
            {
                chkGifToGifBG.Enabled = false;
                chkGifToGifBG.Checked = false;
            }
            else
            {
                chkGifToGifBG.Enabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbWhichJpg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWhichJpg.Text == "Non-Square")
            {
                chkJpgToJpgResize.Enabled = false;
                chkJpgToJpgResize.Checked = false;
                chkJpgToGifResize.Enabled = false;
                chkJpgToGifResize.Checked = false;
            }
            else if (cmbWhichJpg.Text == "Square" || cmbWhichJpg.Text == "All")
            {
                chkJpgToJpgResize.Enabled = true;
                chkJpgToJpgResize.Checked = true;
                chkJpgToGifResize.Enabled = true;
                chkJpgToGifResize.Checked = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbWhichPng_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWhichPng.Text == "Non-Square")
            {
                chkPngToJpgResize.Enabled = false;
                chkPngToJpgResize.Checked = false;
                chkPngToGifResize.Enabled = false;
                chkPngToGifResize.Checked = false;
            }
            else if (cmbWhichPng.Text == "Square" || cmbWhichPng.Text == "All")
            {
                chkPngToJpgResize.Enabled = true;
                chkPngToJpgResize.Checked = true;
                chkPngToGifResize.Enabled = true;
                chkPngToGifResize.Checked = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbWhichGif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWhichGif.Text == "Non-Square")
            {
                chkGifToJpgResize.Enabled = false;
                chkGifToJpgResize.Checked = false;
                chkGifToGifResize.Enabled = false;
                chkGifToGifResize.Checked = false;
            }
            else if (cmbWhichGif.Text == "Square" || cmbWhichGif.Text == "All")
            {
                chkGifToJpgResize.Enabled = true;
                chkGifToJpgResize.Checked = true;
                chkGifToGifResize.Enabled = true;
                chkGifToGifResize.Checked = true;
            }
        }



        /// <summary>  
        /// Returns a transparent background GIF image from the specified Bitmap.  
        /// </summary>  
        /// <param name="bitmap">The Bitmap to make transparent.</param>  
        /// <param name="color">The Color to make transparent.</param>  
        /// <returns>New Bitmap containing a transparent background gif.</returns>  
        private Bitmap MakeTransparentGif(Bitmap bitmap, Color color)
        {
            
            byte R = color.R;
            byte G = color.G;
            byte B = color.B;
            MemoryStream fin = new MemoryStream();
            bitmap.Save(fin, System.Drawing.Imaging.ImageFormat.Gif);
            MemoryStream fout = new MemoryStream((int)fin.Length);
            int count = 0;
            byte[] buf = new byte[256];
            byte transparentIdx = 0;
            fin.Seek(0, SeekOrigin.Begin);
            //header  
            count = fin.Read(buf, 0, 13);
            if ((buf[0] != 71) || (buf[1] != 73) || (buf[2] != 70)) return null; //GIF  
            fout.Write(buf, 0, 13);
            int i = 0;
            if ((buf[10] & 0x80) > 0)
            {
                i = 1 << ((buf[10] & 7) + 1) == 256 ? 256 : 0;
            }
            for (; i != 0; i--)
            {
                fin.Read(buf, 0, 3);
                if ((buf[0] == R) && (buf[1] == G) && (buf[2] == B))
                {
                    transparentIdx = (byte)(256 - i);
                }
                fout.Write(buf, 0, 3);
            }
            bool gcePresent = false;
            while (true)
            {
                fin.Read(buf, 0, 1);
                fout.Write(buf, 0, 1);
                if (buf[0] != 0x21) break;
                fin.Read(buf, 0, 1);
                fout.Write(buf, 0, 1);
                gcePresent = (buf[0] == 0xf9);
                while (true)
                {
                    fin.Read(buf, 0, 1);
                    fout.Write(buf, 0, 1);
                    if (buf[0] == 0) break;
                    count = buf[0];
                    if (fin.Read(buf, 0, count) != count) return null;
                    if (gcePresent)
                    {
                        if (count == 4)
                        {
                            buf[0] |= 0x01;
                            buf[3] = transparentIdx;
                        }
                    }
                    fout.Write(buf, 0, count);
                }
            }
            while (count > 0)
            {
                count = fin.Read(buf, 0, 1);
                fout.Write(buf, 0, 1);
            }
            fin.Close();
            fout.Flush();
            return new Bitmap(fout);
        }

        private void chkJpgToJpg_CheckedChanged(object sender, EventArgs e)
        {
            chkJpgToJpgResize.Enabled = chkJpgToJpg.Checked;
            chkJpgToJpgResize.Checked = chkJpgToJpg.Checked;
        }

        private void chkJpgToGif_CheckedChanged(object sender, EventArgs e)
        {
            chkJpgToGifResize.Enabled = chkJpgToGif.Checked;
            chkJpgToGifResize.Checked = chkJpgToGif.Checked;
        }

        private void chkPngToJpg_CheckedChanged(object sender, EventArgs e)
        {
            chkPngToJpgResize.Enabled = chkPngToJpg.Checked;
            chkPngToJpgResize.Checked = chkPngToJpg.Checked;
        }

        private void chkPngToGif_CheckedChanged(object sender, EventArgs e)
        {
            chkPngToGifResize.Enabled = chkPngToGif.Checked;
            chkPngToGifResize.Checked = chkPngToGif.Checked;
        }

        private void chkGifToJpg_CheckedChanged(object sender, EventArgs e)
        {
            chkGifToJpgResize.Enabled = chkGifToJpg.Checked;
            chkGifToJpgResize.Checked = chkGifToJpg.Checked;

        }

        private void chkGifToGif_CheckedChanged(object sender, EventArgs e)
        {
            chkGifToGifResize.Enabled = chkGifToGif.Checked;
            chkGifToGifResize.Checked = chkGifToGif.Checked;
        }

        private void chkJpgToGifResize_CheckedChanged(object sender, EventArgs e)
        {
            chkJpgToGifBG.Enabled = chkJpgToGifResize.Checked;
            chkJpgToGifBG.Checked = false;
        }
    }
}
