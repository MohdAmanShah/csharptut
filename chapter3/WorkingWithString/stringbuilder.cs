Console.WriteLine("Using StringBuilder Class");

System.Text.StringBuilder sb = new System.Text.StringBuilder("***** Best Games *****");
sb.Append("\n");
sb.AppendLine("Cyberpunk 2077");
sb.AppendLine("Elder Scrolls 5");
Console.WriteLine(sb);

sb.Replace("5","5: Skyrim");
Console.WriteLine(sb);

Console.WriteLine("sb has {0} characters.",sb.Length);