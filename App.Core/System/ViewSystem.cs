/* ViewSystem.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using System;
using System.Collections.Generic;
using App.Core.Utils;
using App.Core.View;

namespace App.Core.System
{
    public class ViewSystem : ISystem
    {
        private TypeList<AView> list;
        private Stack<AView> previous;
        private AView current;

        public ViewSystem()
        {
            list = new TypeList<AView>();
            previous = new Stack<AView>();
            current = new AView();
        }

        public void OnUpdate()
        {
            // required by ISystem
        }

        public T Get<T>() where T : AView
        {
            return list.Get<T>();
        }

        public void Add<T>() where T : AView, new()
        {
            list.Add<T>();
        }

        private void DrawView(AView view)
        {
            Console.Clear();
            Console.Write(view.Text);
        }

        public void SetView<T>() where T : AView
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
