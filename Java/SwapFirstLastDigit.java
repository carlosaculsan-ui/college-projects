import java.util.Scanner;

public class MachineProblem16 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Enter number:   ");
        int number = scanner.nextInt();
        
        int swappedNumber = swapFirstAndLastDigit(number);
        
        System.out.println("Number after swapping first and last digit: " + swappedNumber);
        
        scanner.close();
    }
    public static int swapFirstAndLastDigit(int number) {
        if (number <= 9) {
            return number;
        }
        
        int lastDigit = number % 10;
        int originalNumber = number;
        int power = 1;
        
        while (number >= 10) {
            number /= 10;
            power *= 10;
        }
        
        int firstDigit = number;
        
        int middleDigit = (originalNumber / 10) % (power / 10);
        
        int swappedNumber = lastDigit * power + middleDigit * 10 + firstDigit;
        
        return swappedNumber;
        
    }
}
   
       
