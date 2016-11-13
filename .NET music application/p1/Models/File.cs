﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace p1.Models
{
    public class File
    {
        public int FileId { get; set; }

        public string FileName { get; set; }

        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public FileType FileType { get; set; }
        public int TrackInfoId { get; set; }
        public virtual Song TrackInfo { get; set; }
    }
}