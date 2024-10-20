class_one d = new();
((interface_one)d).doit();
((interface_two)d).doit();
((interface_three)d).doit();
if (d is interface_two t)
{
    t.doit();
}