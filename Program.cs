Clock clock = new Clock(50, 59, 23);


while (true) {
    clock.tick();
    Console.WriteLine(clock.numToString());
    Thread.Sleep(1000); // venter 1 sekund
}