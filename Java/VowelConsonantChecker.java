import java.util.Scanner;

public class MachineProblem22 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.println("Enter a letter: ");
        char cha = scanner.next().charAt(0);
        
        switch (cha) {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'u':
            case 'U':
            case 'o':
            case 'O': System.out.println(cha + " is a vowel");
            break;
            default: 
              if ((cha > 'a' && cha < 'z') || (cha > 'A' && cha < 'Z')) {
                  System.out.println(cha + " is a consonant ");
              } else {
                  System.out.println("INVALID INPUT");
              }
        }
    }
}    
            
