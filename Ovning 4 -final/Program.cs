using System;
namespace Ovning_4__final
{
    class Program
    {

        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }
        static void ExamineList() /// Examines the datastructure List
        {
            /*
             * Loop this method untill the user inputs something to exit to main menu.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();

            do
            {
                Console.WriteLine("Choose a word to add or remove");
                string input = Console.ReadLine();

                Console.WriteLine("Choose you action ADD for adding the word or REMOVE for removing the word");
                String nav = (Console.ReadLine());

                switch (nav)
                {
                    case "ADD":
                        theList.Add(input);
                        break;

                    case "REMOVE":
                        theList.Remove(input);
                        break;

                    case "Q":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("OPS! {0} is not an option, only \"+\" or \"+\" can be used!", input);
                        break;
                }
                Console.WriteLine("The list:");
                Console.WriteLine("---------");

                for (int i = 0; i < theList.Count; i++)

                {
                    Console.WriteLine(theList[i]);
                }

                Console.WriteLine($"The list size is :" + theList.Count);
                Console.WriteLine($"The list capacity is :" + theList.Capacity);
                Console.WriteLine();
            } while (true);

            //2. First, the capacity is initialized at 4 and when that capicity is used,
            //   reached at, it is inceased again to 4 more i.e. 8.

            //3. Apparently the capacity increases by 4.

            //4. The capacity does not increase until when there is no more room for a new element.

            //5. When the elements are removed from the list the capacity does not decrease.
            // 6.I think a self defined array once created it will have a static size while a list size can change.
        }




        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue ica_Queue = new Queue();

            do
            {
                Console.WriteLine("Type \"+\" for queueing , \"-\" for dispaching from the queue" +
                                  " or \"Q\" to exist the program");
                string nav = Console.ReadLine();

                switch (nav)
                {
                    case "+":
                        {
                            Console.WriteLine("Who is joining the queue?");
                            string input = Console.ReadLine();
                            ica_Queue.Enqueue(input);
                            break;
                        }

                    case "-":
                        {
                            if (ica_Queue.Count > 0)
                                ica_Queue.Dequeue();
                            else Console.WriteLine("There is no one on the queue.");
                            break;
                        }

                    case "Q":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("You can only choose + , - or  Q");
                        break;
                }
                Console.WriteLine("People on the queue are:");

                foreach (string element in ica_Queue)

                {
                    Console.WriteLine(element);
                }
                Console.WriteLine($"At the moment the queue size is :" + ica_Queue.Count);
                Console.WriteLine();
            } while (true);
        }


        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            /*1. It would not be good/ smart to use a stach in a case such as the ICA as 
             * that would mean that the one who gets to the queue first leaves the last
             * while the one who joins the queue last is the one who is served first 
             * and therefore leaves the queue before others. 
            */

            Stack<char> myStack = new Stack<char>();
            Console.WriteLine("Provide text:");
            string text = Console.ReadLine();
            var characters = text.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                myStack.Push(characters[i]);
            }

            for (int n = 0; n < text.Length; n++)
            {
                Console.Write(myStack.Peek());
                myStack.Pop();
            }

        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            //1. I think I can use queue and stack data structures for this part.

            // I think I can capture the string and scan it for parantheses
            // Then assign the sequence of parentheses to a stack or a queue. 
            // The stack is then checked to ensure that 
            // every closing parenthesis has a matching opening one before finding . 
            // another different closing paranthesis.
            // or use a queue to check to ensure that opening parenthesis
            // has a matching closing one before finding another different closing paranthesis.
            // for the stack I would make use of the pop methods or dequeueing in the case
            // I use the queue in order to drop the parenthisis I have checked and
            // found to match the previous one.


            Stack<char> myStack = new Stack<char>();
            Console.WriteLine("Provide a string:");
            string text = Console.ReadLine();
            var characters = text.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (characters[i] == '(' || characters[i] == ')'
                   || characters[i] == '{' || characters[i] == '}'
                   || characters[i] == '[' || characters[i] == ']')
                {
                    Console.Write(characters[i]);
                    myStack.Push(characters[i]); // creating a new sequence containing parantheses only
                }
            }
            Console.WriteLine();
            Console.WriteLine(myStack.Peek());// checking top most paranthesis of the stack

            for (int n = 0; n < myStack.Count + 1; n++) // I was yet to figuring out how to write the code for this part
            {

            }

        }
    }
}




