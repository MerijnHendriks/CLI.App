/* SystemManager.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.Core.Utils;

namespace App.Core.System
{
    public static class SystemManager
    {
        static TypeList<ISystem> list;

        static SystemManager()
        {
            list = new TypeList<ISystem>();
        }

        public static void OnUpdate()
        {
            foreach (var item in list)
            {
                item.OnUpdate();
            }
        }

        public static T Get<T>() where T : ISystem
        {
            return list.Get<T>();
        }

        public static void Add<T>() where T : ISystem, new()
        {
            list.Add<T>();
        }
    }
}
