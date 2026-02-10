import java.util.Scanner;

public class MachineProblem2 { 
    public static void main(String[] args) {
        Scanner op = new Scanner(System.in);
        int a, b, total;

        System.out.println("Enter first number ");
        a = op.nextInt();
        System.out.println("Enter second number ");
        b = op.nextInt();

        total = a + b;

        System.out.println("The sum: " + total);

        op.close();

    }
    
}    
