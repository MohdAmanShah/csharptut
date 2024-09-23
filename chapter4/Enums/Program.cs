ContactPreferenceEnum preference = ContactPreferenceEnum.Email;
Console.WriteLine(preference);

preference = ContactPreferenceEnum.Phone | ContactPreferenceEnum.Email;
Console.WriteLine(preference);

preference = preference ^ ContactPreferenceEnum.Phone;
Console.WriteLine(preference);

Console.WriteLine(Enum.IsDefined(preference.GetType(), ContactPreferenceEnum.Phone));
Console.WriteLine(Enum.IsDefined(preference.GetType(), ContactPreferenceEnum.Email));