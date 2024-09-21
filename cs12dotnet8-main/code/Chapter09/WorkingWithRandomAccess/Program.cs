using Microsoft.Win32.SafeHandles; // to use SafeFileHandle;
using System.Text; // to use Encoding

using SafeFileHandle handle = File.OpenHandle(path: "coffee.txt", mode: FileMode.OpenOrCreate, access: FileAccess.ReadWrite);

string message = "This file is written using the Microsoft.Win32.SafeHandles SafeFileHandle. It provides safe file handle and random access.";
ReadOnlyMemory<byte> buffer = new ReadOnlyMemory<byte>(Encoding.UTF8.GetBytes(message));
await RandomAccess.WriteAsync(handle, buffer, fileOffset: 0);

long length = RandomAccess.GetLength(handle);
Memory<byte> buffer2 = new(new byte[length]);
await RandomAccess.ReadAsync(handle, buffer2, fileOffset: 0);
string fileContent = Encoding.UTF8.GetString(buffer2.ToArray());
WriteLine(fileContent);
