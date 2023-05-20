class Program {
    static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        string[] PeopleInput = Console.ReadLine().Split(' ');
        int[] People = Array.ConvertAll(PeopleInput, int.Parse);
        int maxCustomers = 0;

        for (int i = 0; i <= N - K; i++) {
            int Customers = 0;

        for (int j = i - K; j <= i + K; j++) {
            if (j >= 0 && j < N) {
                    Customers += People[j]; }
    }
            maxCustomers = Math.Max(maxCustomers, Customers);
 }
        Console.WriteLine(maxCustomers);
    }
}