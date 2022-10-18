Clock clock = new Clock(10, 23, 22);
while (true) {
    clock.tick();
    Console.WriteLine(clock.numToString());
    Thread.Sleep(1000); // venter 1 sekund
}