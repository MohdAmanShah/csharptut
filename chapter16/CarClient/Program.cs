using CarLibrary;

Console.WriteLine("Car client app");

SportsCar sc = new SportsCar("Viper", 250, 124);
sc.TurboBoost();

MiniVan mv = new MiniVan("Omni", 120, 60);
mv.TurboBoost();

HiddenCar hd = new HiddenCar("Razor", 290);
hd.TurboBoost();