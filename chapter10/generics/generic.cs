using System.Collections.Generic;
namespace generics;
public class Coll<T> where T : class
{
    List<T> List;
}