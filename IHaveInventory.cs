using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SwinAdventure
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);
        string Name { get; }

    }
}
