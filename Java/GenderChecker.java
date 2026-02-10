import java.util.Scanner;

public class MachineProblem23 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.println("Enter Gender: ");
        char cha = scanner.next().charAt(0);
        
        switch (cha) {
            case 'f':
            case 'F':
                System.out.println("FEMALE");
            break;
            case 'm':
            case 'M':
                System.out.println("MALE");
            break;
            default:
                System.out.println("ENTER F or M");
        }
    }
}    
        
