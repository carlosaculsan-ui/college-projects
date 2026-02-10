import java.util.Scanner;

public class MachineProblem24 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.println("Enter first number: ");
        int num1 = scanner.nextInt();
        System.out.println("Enter second number: ");
        int num2 = scanner.nextInt();
        
        int max = num1;
        
        switch (max) {
            case 1:
                if (num2 > max) {
                    max = num2;
                }
            break;
            default:
                if (num2 > max) {
                    max = num2;
                }
            System.out.println("The maximum number is: " + max);  
        }
    }
}    
        
        
            
       
