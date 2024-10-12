public record PositionalCar(string Model, string Make, string Color);
public record PositionalMiniVan(string Model, string Make, string Color, int Seating) : PositionalCar(Model, Make, Color);
public record MotorCycle(string Make, string Model);
public record Scooter(string Make, string Model) : MotorCycle(Make, Model);
public record FancyScooter(string Make, string Model, string Color) : Scooter(Make, Model);