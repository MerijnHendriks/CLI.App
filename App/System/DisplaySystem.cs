﻿/* DisplaySystem.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using System;

namespace App.System
{
    public class DisplaySystem : ISystem
    {
        public void OnUpdate()
        {
            // code here
        }

        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}
