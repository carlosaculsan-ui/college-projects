import java.util.Scanner;

public class MachineProblem25 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.println("Enter day : ");
        int day = scanner.nextInt();
        
        
        
        switch (day) {
            case 1: System.out.print("Today is Monday");
            break;
            case 2: System.out.print("Today is Tuesday");
            break;
            case 3: System.out.print("Today is Wednesday");    
            break;
            case 4: System.out.print("Today is Thursday");
            break;
            case 5: System.out.print("Today is Friday");
            break;
            case 6: System.out.print("Today is Saturaday");
            break;
            case 7: System.out.print("Today is Sunday");
            break;
            default: System.out.print("INVALID INPUT");
        }

         System.out.println();
         System.out.println (" Enter number 1-7 ");
         int number = scanner.nextInt();
         
         switch (number) {
             case 1:
             case 2:
             case 3:
             case 4:
             case 5:     
                 System.out.println("ITS WEEKDAYS");
             break;
             case 6:
             case 7:
                 System.out.println("ITS WEEKEND");
            default: 
                 System.out.println("INVALID INPUT");
         }
    } 
}
