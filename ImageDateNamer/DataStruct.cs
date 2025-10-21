using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPictures
{
    public class IMAGE_INFO
    {
        public string strFilePath { get; set; }
        public string strFileName { get; set; }
        public string strExtension { get; set; }        
        public int nWidth { get; set; }
        public int nHeight { get; set; }
        public DateTime dateTime { get; set; }
        public string strCameraMaker { get; set; }
        public string strCameraModel { get; set; }
        public string strDestFileName { get; set; }
        public string strDestFolderName { get; set; }        
        public IMAGE_INFO()
        {

        }
    }
}
