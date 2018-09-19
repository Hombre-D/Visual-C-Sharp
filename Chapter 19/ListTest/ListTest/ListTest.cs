using System;
using LinkedListLibrary;


class ListTest
{
    static void Main()
    {
        var list = new List();
        bool aBoolean = true;
        char aCharacter = '$';
        int anInteger = 34567;
        string aString = "hello";

        list.InsertAtFront(aBoolean);
        list.Display();
        list.InsertAtFront(aCharacter);
        list.Display();
        list.InsertAtBack(anInteger);
        list.Display();
        list.InsertAtBack(aString);
        list.Display();

        try
        {
            object removedObject = list.RemoveFromFront();
            Console.WriteLine($"{removedObject} removed");
            list.Display();

            removedObject = list.RemoveFromFront();
            Console.WriteLine($"{removedObject} removed");
            list.Display();

            removedObject = list.RemoveFromBack();
            Console.WriteLine($"{removedObject} removed");
            list.Display();

            removedObject = list.RemoveFromBack();
            Console.WriteLine($"{removedObject} removed");
            list.Display();
        }
        catch(EmptyListException emptyListException)
        {
            Console.Error.WriteLine($"\n{emptyListException}");
        }


    }
}

