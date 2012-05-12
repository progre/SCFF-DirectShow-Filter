
// Copyright 2012 Progre <djyayutto_at_gmail.com>
//
// This file is part of SCFF DSF.
//
// SCFF DSF is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// SCFF DSF is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with SCFF DSF.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using scff_interprocess;
using System.Runtime.InteropServices;

namespace ScffApp
{
    /// Entryをマネージドクラス化したもの
    class ManagedEntry
    {
        public
         ManagedEntry(Interprocess.Entry raw_entry)
        {
            entry_ = raw_entry;
        }
        public scff_interprocess.Interprocess.Entry get_raw_entry()
        {
            return entry_;
        }
        public string Info
        {
            get
            {
                String pixel_format_string;
                switch (SamplePixelFormat)
                {
                    case (int)Interprocess.ImagePixelFormat.kI420:
                        pixel_format_string = "I420";
                        break;
                    case (int)Interprocess.ImagePixelFormat.kUYVY:
                        pixel_format_string = "UYVY";
                        break;
                    case (int)Interprocess.ImagePixelFormat.kRGB0:
                        pixel_format_string = "RGB0";
                        break;
                    default:
                        pixel_format_string = "(invalid)";
                        break;
                }

                return "[" + ProcessID + "] " + ProcessName +
                       " (" + pixel_format_string + " " + SampleWidth + "x" + SampleHeight +
                       " " + FPS.ToString("F0") + "fps)";
            }
        }
        public int ProcessID
        {
            get
            {
                return (int)entry_.process_id;
            }
            set
            {
                entry_.process_id = (uint)value;
            }
        }
        public String ProcessName
        {
            get
            {
                return (entry_.process_name);
            }
            set
            {
                entry_.process_name = value;
            }
        }
        public int SampleWidth
        {
            get
            {
                return entry_.sample_width;
            }
            set
            {
                entry_.sample_width = value;
            }
        }
        public int SampleHeight
        {
            get
            {
                return entry_.sample_height;
            }
            set
            {
                entry_.sample_height = value;
            }
        }
        public int SamplePixelFormat
        {
            get
            {
                return entry_.sample_pixel_format;
            }
            set
            {
                entry_.sample_pixel_format = value;
            }
        }
        public double FPS
        {
            get
            {
                return entry_.fps;
            }
            set
            {
                entry_.fps = value;
            }
        }

        private Interprocess.Entry entry_;
    };
}
