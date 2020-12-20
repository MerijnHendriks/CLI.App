/* ViewSystem.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using System;
using System.Collections.Generic;
using App.Core.Utils;
using App.Core.Views;

namespace App.Core.System
{
    public class ViewSystem : ISystem
    {
        private TypeList<View> list;
        private Stack<View> previous;
        private View current;

        public ViewSystem()
        {
            list = new TypeList<View>();
            previous = new Stack<View>();
            current = new View();
        }

        public void OnUpdate()
        {
            // required by ISystem
        }

        public T Get<T>() where T : View
        {
            return list.Get<T>();
        }

        public void Add<T>() where T : View, new()
        {
            list.Add<T>();
        }

        private void DrawView(View view)
        {
            Console.Clear();
            Console.Write(view.Text);
        }

        public void SetView<T>() where T : View
        {
            if (list.Contains<T>())
            {
                current = Get<T>();
            }

            if (previous.Count > 0 && previous.Peek() != current)
            {
                previous.Push(current);
            }

            DrawView(current);
        }

        public void ResetView()
        {
            DrawView(current);
        }

        public void RevertView()
        {
            if (previous.Count > 0)
            {
                DrawView(previous.Pop());
            }
            else
            {
                ResetView();
            }
        }
    }
}
