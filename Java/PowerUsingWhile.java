import java.util.Scanner;

public class MachineProblem20whileLoop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
       System.out.println("Enter base: ");
       int base = scanner.nextInt();
       System.out.println("Enter exponent: ");
       int exponent = scanner.nextInt();
       
       int result = 1;
       
       int i = 0;
       
       while (i < exponent) {
           result *= base;
           i++;
       }
        
       System.out.println(base + "^" + exponent + " is equals to " + result);
    }
}    
       
