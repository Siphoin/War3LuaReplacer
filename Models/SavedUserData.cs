using System;

namespace War3LuaReplacer.Models
{
    [Serializable]
    public class SavedUserData
    {
        public string WC3ExePath { get; set; }
        public string MapPath { get; set; }
        public string LuaPath { get; set; }
        public bool SaveAfterExit { get; set; }
    }
}
