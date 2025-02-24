# Unhandled NullReferenceException in C# Property Access

This repository demonstrates a common error in C# where a `NullReferenceException` occurs when accessing a property that hasn't been initialized.  The `bug.cs` file contains code that causes this exception. The `bugSolution.cs` provides a corrected version.

## Bug Description:
The `MyClass` has a property `MyProperty`. The `MyMethod` attempts to access this property without checking if it's null, leading to a `NullReferenceException` if `MyProperty` hasn't been assigned a value before the method is called.

## Solution:
Always check for null before accessing properties, especially those that might not be initialized.  The solution provides a simple null check to prevent the exception.
