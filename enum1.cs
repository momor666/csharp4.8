//
//A Writer access flag that is made up of the Submit and Modify flags.
//An Editor access flag that is made up of the Delete, Publish and Comment flags.
//An Owner access that is made up of the Writer and Editor flags.

using System;

public class Account
{
    [Flags]
    public enum Access:byte
    {
        
        None    = 0,
        Delete  = 1 << 0,   // 1
        Publish = 1 << 1,   // 2
        Submit  = 1 << 2,   // 4
        Comment = 1 << 3,   // 8
        Modify  = 1 << 4,
       
        // combinations
        Writer = Submit | Modify,
        Editor = Delete | Publish | Comment,
        Owner = Writer | Editor     
    }
    
    public static void Main(string[] args)
    {       
        Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
    }
}
