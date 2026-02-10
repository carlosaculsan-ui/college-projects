import java.util.Scanner;

public class MachineProblem19 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
       System.out.println("Enter number: ");
       int number = scanner.nextInt();
       
       int product = 1;
       
       while (number != 0) {
           int input = number % 10;
           product *= input;
           number /= 10;
       }
       
       System.out.println("The product of the number is " + product);
       
    }
    
}
   
