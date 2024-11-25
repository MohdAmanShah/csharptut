using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Loader;

Console.WriteLine(" Default App Domains");
Console.WriteLine("");
LoadAdditionalAssembliesSameContext();
LoadAddtionalAssembliesInSameContext();
// LoadAdditionalAssembliesInDifferentContext();
// DisplayStat();
// ListAllAssembliesInAppDomain();

static void DisplayStat()
{
    AppDomain defaultAD = AppDomain.CurrentDomain;
    Console.WriteLine("Name of this domain: {0}", defaultAD.FriendlyName);
    Console.WriteLine("ID of the domain in this process: {0}", defaultAD.Id);
    Console.WriteLine("Is this default domain: {0}", defaultAD.IsDefaultAppDomain());
    Console.WriteLine("Base directory of this domain: {0}", defaultAD.BaseDirectory);
    Console.WriteLine("Setup information of this domain");
    Console.WriteLine("\t Application Base: {0}", defaultAD.SetupInformation.ApplicationBase);
    Console.WriteLine("\t Target Framework: {0}", defaultAD.SetupInformation.TargetFrameworkName);
}

static void ListAllAssembliesInAppDomain()
{
    AppDomain defaultAD = AppDomain.CurrentDomain;
    Assembly[] loadedAssemblies = (from a in defaultAD.GetAssemblies()
                                   orderby a.GetName().Name
                                   select a).ToArray<Assembly>();
    Console.WriteLine("Assemblies loaded:");
    foreach (Assembly assembly in loadedAssemblies)
    {
        Console.WriteLine($"-> Name, Version: {assembly.GetName()}, {assembly.GetName().Version}");
    }
}

static void LoadAdditionalAssembliesInDifferentContext()
{
    var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ClassLib1.dll");

    AssemblyLoadContext lc1 = new AssemblyLoadContext("newContext1", false);
    var cl1 = lc1.LoadFromAssemblyPath(path);
    var c1 = cl1.CreateInstance("ClassLib1.Car");

    AssemblyLoadContext lc2 = new AssemblyLoadContext("newContext2", false);
    var cl2 = lc2.LoadFromAssemblyPath(path);
    var c2 = cl2.CreateInstance("ClassLib1.Car");

    Console.WriteLine(" ******Loading additional assemblies in different context************");
    Console.WriteLine($"Assembly Equals(Assembly2): {cl1.Equals(cl2)}");
    Console.WriteLine($"Assembly1 == Assembly2: {cl1 == cl2}");
    Console.WriteLine(c1.Equals(c2));
    Console.WriteLine(c1 == c2);

}

static void LoadAddtionalAssembliesInSameContext()
{
    var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ClassLib1.dll");
    AssemblyLoadContext lc = new AssemblyLoadContext(null, false);
    Assembly a1 = lc.LoadFromAssemblyPath(path);
    Assembly a2 = lc.LoadFromAssemblyPath(path);
    var c1 = a1.CreateInstance("ClassLib1.Car");
    var c2 = a2.CreateInstance("ClassLib1.Car");
    Console.WriteLine("**********Loaded assemblies from same load context************\n");
    Console.WriteLine(a2 == a1);
    Console.WriteLine(a1.Equals(a2));
    Console.WriteLine(c1 == c2);
    Console.WriteLine(c1.Equals(c2));

}

static void LoadAdditionalAssembliesSameContext()
{
    var path =
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
    "ClassLib1.dll");
    AssemblyLoadContext lc1 =
    new AssemblyLoadContext(null, false);
    var cl1 = lc1.LoadFromAssemblyPath(path);
    var c1 = cl1.CreateInstance("ClassLib1.Car");
    var cl2 = lc1.LoadFromAssemblyPath(path);
    var c2 = cl2.CreateInstance("ClassLib.Car");
    Console.WriteLine("*** Loading Additional Assemblies in Same Context ***");
    Console.WriteLine($"Assembly1.Equals(Assembly2) {cl1.Equals(cl2)}");
    Console.WriteLine($"Assembly1 == Assembly2 {cl1 == cl2}");
    Console.WriteLine($"Class1.Equals(Class2) {c1.Equals(c2)}");
    Console.WriteLine($"Class1 == Class2 {c1 == c2}");
}