using System;

class MainClass {
  public static void Main (string[] args) {
    Aeronave Boeing = new Aeronave("Sete", 500, 250, 200, 5000, 600000, "Luis", "Santos Dumont");

    Console.WriteLine(Boeing.Voar(3000));

  }
}
