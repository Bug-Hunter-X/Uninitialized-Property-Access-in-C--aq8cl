# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value.  This can lead to a `NullReferenceException` if the property is a reference type (like a string or an object).  The solution provides a corrected version of the code.

## Bug
The `bug.cs` file contains code with the error.  The `MyProperty` is not explicitly assigned a value before being used in the `MyMethod`. This can cause the program to crash, depending on the property type.

## Solution
The `bugSolution.cs` file demonstrates the corrected code.  `MyProperty` is initialized with a default value before use, preventing the `NullReferenceException`.