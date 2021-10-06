using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento_Pattern
{
    public class History
    {
        public List<EditorState> States = new List<EditorState>();
        public void Push(EditorState state)
        {
            States.Add(state);
        }
        public EditorState Pop()
        {
            var lastIndex = States.Count() - 1;
            var lastState = States.ElementAt(lastIndex);
            States.Remove(lastState);

            return lastState;
        }
    }
}
