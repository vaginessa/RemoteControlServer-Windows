﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlServer
{
    interface Commands
    {
        void OpenProgram(String name);

        void CloseProgram(String name);

        void VolumeUp();

        void VolumeDown();

        void EditTextMessage(String text);

        void SaveNotepadText(String timeStamp);
    }
}
