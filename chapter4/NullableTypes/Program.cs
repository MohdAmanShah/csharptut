string? Name = null;
TestClass? nullClass = null;
TestClass nonNullClass = nullClass;

#nullable disable
TestClass nonNullClsass = nullClass;
#nullable restore
TestClass? BadDefiniation = nullClass;