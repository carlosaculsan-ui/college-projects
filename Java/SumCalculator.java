import java.util.Scanner;


public class MachineProblem4 {
    public static void main(String[] args) {
        Scanner str = new Scanner(System.in);
        int a, b;

        System.out.println("Enter the first integer ");
        a = str.nextInt();

        System.out.println("Enter the second integer ");
        b = str.nextInt();

        int result = sum(a, b);

        System.out.println("The sum of " + a + " and " + b + " is " + result);

        str.close();
    }

    public static int sum(int num1, int num2) {
        return num1 + num2;

    }


}
