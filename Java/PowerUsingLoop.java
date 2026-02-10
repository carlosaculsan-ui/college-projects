import java.util.Scanner;

public class MachineProblem20forLoop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
       System.out.println("Enter base: ");
       int base = scanner.nextInt();
       System.out.println("Enter exponent: ");
       int exponent = scanner.nextInt();
       
       int result = 1;
       
       for (int i = 0;i < exponent; i++) {
           result *= base;
       }
      
       System.out.println(base + "^" + exponent + " is equals to " + result);
    }
}    
       
