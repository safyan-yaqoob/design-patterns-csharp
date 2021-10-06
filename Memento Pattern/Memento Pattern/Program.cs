using System;

namespace Memento_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Edittor();
            var history = new History();

            editor.setContent("a");
            history.States.Add(editor.CreateState());

            editor.setContent("b");
            history.States.Add(editor.CreateState());
            
            editor.setContent("c");
            history.States.Add(editor.CreateState());

            editor.Restore(history.Pop());
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());

            Console.WriteLine("Current Items");
            foreach (var item in history.States)
            {
                Console.WriteLine(item.content);
            }

            Console.WriteLine("Undo Item");
            Console.WriteLine(editor.getContent());

            Console.ReadLine();
        }
    }
}
