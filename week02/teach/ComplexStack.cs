public static class ComplexStackSolution {
    public static void Main() {
        // True (stack was empty at the end)
        Console.WriteLine(CheckBraces("(a == 3 or (b == 5 and c == 6))"));
        // False ...wrong opening square bracket (stack had only '(' in it before it was popped and compared with ']')
        //                          here -------\/
        Console.WriteLine(CheckBraces("(students]i].Grade > 80 and students[i].Grade < 90"));
        // False ....missing closing ')' (stack had an extra '(' in it at the end when it was supposed to be empty
        //                 here -------\/
        Console.WriteLine(CheckBraces("(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))"));
    }

    public static bool CheckBraces(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}

/// Code Behavior

/// A stack is created.

/// Each character of the input string is pushed onto the stack.

/// Then characters are popped one by one and added to result.

///  Because a stack is LIFO, the output is the reverse of the input string.

///  Why a Stack is Useful

///  The stack naturally reverses the order of elements.

///  Instead of manually looping backward, the stack structure makes reversal straightforward.

///  Outputs

///  Input: "racecar" → Output: "racecar" (palindrome, same forward and backward).

///  Input: "stressed" → Output: "desserts".

///  Input: "a nut for a jar of tuna" → Output: "anut fo raj a rof tun a".

///  Purpose: This function reverses a string using a stack.