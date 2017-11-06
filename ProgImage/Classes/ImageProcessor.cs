using ProgImage.Common;
using ProgImage.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using ProgImage.Classes;

namespace ProgImage.Classes
{
    public class ImageProcessor
    {
        public static Image ImageProperty { get; set; }
        public static Imaging Imaging { get; set; }
        public static bool DirectoryExistence { get; set; }

        public void Upload(string imageStr)
        {
            using (ImageProperty = Image.FromFile(imageStr))
            {
                //Check if the image file length > 12 kikibyte
                CreateDirectoryObject(Validator.ValidateDirectory(Constants.ImagePath));
                if (Validator.ValidateFileLength(imageStr) == false)
                {
                    Imaging imaging = new Imaging()
                    {
                        Image = ImageProperty,
                        Identifier = Guid.NewGuid(),
                        Extension = Path.GetExtension(imageStr)
                    };
                    ImageProperty.Save(Path.Combine(Constants.ImagePath, imaging.Identifier + imaging.Extension));
                    Imaging = imaging;
                }
            }
        }
        public string GetImage()
        {
            return Imaging.Identifier + Imaging.Extension.ToLower().ToString();
        }
        public Image RightRotation(string imageStr)
        {
            ImageProperty = Image.FromFile(imageStr);
            ImageProperty.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return ImageProperty;
        }
        public Image LeftRotation(string imageStr)
        {
            ImageProperty = Image.FromFile(imageStr);
            ImageProperty.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return ImageProperty;
        }
        public bool ConvertToPng(string imageStr)
        {
            using (ImageProperty = Image.FromFile(imageStr))
            {
                CreateDirectoryObject(Validator.ValidateDirectory(Constants.ImagePath));
                if (Validator.ValidateFileLength(imageStr) == false)
                {
                    Imaging imaging = new Imaging()
                    {
                        Image = ImageProperty,
                        Identifier = Guid.NewGuid(),
                        Extension = Path.GetExtension(imageStr)
                    };
                    ImageProperty.Save(Constants.ImagePath + imaging.Identifier.ToString() + ".png", ImageFormat.Png);
                    Imaging = imaging;
                    return true;
                }
                return false;
            }
        }
        public bool ConvertToJpg(string imageStr)
        {
            using (ImageProperty = Image.FromFile(imageStr))
            {
                CreateDirectoryObject(Validator.ValidateDirectory(Constants.ImagePath));
                if (Validator.ValidateFileLength(imageStr) == false)
                {
                    Imaging imaging = new Imaging()
                    {
                        Image = ImageProperty,
                        Identifier = Guid.NewGuid(),
                        Extension = Path.GetExtension(imageStr)
                    };
                    ImageProperty.Save(Constants.ImagePath + imaging.Identifier.ToString() + ".jpg", ImageFormat.Jpeg);
                    Imaging = imaging;
                    return true;
                }
                return false;
            }
        }
        public void CreateDirectoryObject(bool checker)
        {
            if (checker == false)
            {
                Directory.CreateDirectory(Path.Combine(Constants.ImagePath));
                DirectoryExistence = true;
            }
        }
    }
}