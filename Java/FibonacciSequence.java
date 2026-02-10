public class MachineProblem7{
    public static void main(String[] args) {
        int n = 10; // Change this for the desired number of Fibonacci numbers to display

        long a = 0, b = 1;

        System.out.print("Fibonacci Sequence of " + n + " numbers: ");

        for (int i = 0; i < n; i++) {
            System.out.print(a + " ");
            long next = a + b;
            a = b;
            b = next;
        }
    }
}
