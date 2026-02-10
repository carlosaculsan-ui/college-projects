import java.util.Scanner;

public class MachineProblem21 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
       System.out.println("Enter number: ");
       int number = scanner.nextInt();
       
       int remainder = number % 2;
       
       switch (remainder) {
           case 0: 
               System.out.println(number + " is an even number");
               break;
            case 1: 
                System.out.println(number + " is an odd number");
                break;
            default:
                System.out.println("INVALID INPUT");
       }
    }
}    
       
