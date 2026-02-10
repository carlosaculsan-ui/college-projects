import java.util.Scanner;

public class MachineProblem15 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Enter x coordinate:   ");
        int x = scanner.nextInt();
        System.out.print("Enter y coordinate:   ");
        int y = scanner.nextInt();
        
        if (x > 0 && y > 0) {
            System.out.println("Coordinates is in the first quadrant");
        }
        else if (x < 0 && y > 0) {
            System.out.println("Coordinates is in the second quadrant");
        }
        else if (x < 0 && y < 0) {
            System.out.println("Coordinates is in the third quadrant");
        }
        else if (x > 0 && y < 0) {
            System.out.println("Coordinates is in the fourth quadrant");
        } else {
            System.out.println("Coordinates is in the origin");
        }
        
        scanner.close();
        
    }
}
