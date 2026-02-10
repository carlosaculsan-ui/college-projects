import java.util.Scanner;

public class MachineProblem18 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.println("Enter number: ");
        int number = scanner.nextInt();
        
        int firstDigit = 0;
        int lastDigit = number % 10;
        
        while (number != 0) {
            firstDigit = number % 10;
            number /= 10;
        }
        
        int sum = firstDigit + lastDigit;
        
        System.out.println("The sum of the number is " + sum);
       
    } 
}
   
