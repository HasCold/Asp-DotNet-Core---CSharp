// ------------------- Data member or Variable --------------------
// 1. Static DM (It occupy Class memory space, no need to create object to store static data) -> static keyword;
// Shared variable should be declared as a static.

// Suppose for constant varaible we can use word static along side because there is no making sense to make the variable dynamic
// e.g. static const int x = 100; -->> Is Immutable (Reserved Memory)
// e.g. static int y = 200; -->> Is Mutable (Dynamic Memory)

// 2. Non-Static DM (Dynamic memory allocation) declaration through the object;
// class A {
//   int a = 10;
// }

// 3. Local Variable: This varaible will declare inside method.

// ---------------------------------------------------------------------

// ------------------- Member Function --------------------
// It is used to define the functionality of an object.
// 1. Static Member Function
// 2. Dynamic Member Function
// ---------------------------------------------------------