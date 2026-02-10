import java.util.Scanner;

public class MachineProblem10 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        float distance, hour, min, sec;
        System.out.println("Enter distance: ");
        distance = scanner.nextFloat();
        System.out.println("Enter hour: ");
        hour = scanner.nextFloat();
        System.out.println("Enter minutes: ");
        min = scanner.nextFloat();
        System.out.println("Enter seconds: ");
        sec = scanner.nextFloat();
        int str = 3600;
        int op = 1609;
        //CALCULATION PROCESS//
        float InitialSec = (hour * 3600) + (min * 60) + sec;
        float km = (distance * str) / (InitialSec * 1000);
        float mt = (distance / InitialSec);
        float miles = (distance / str) * (3600 / 1000) * (1 / op);

        System.out.println("The calculation speed of km/hr: " + km);
        System.out.println("The calculation speed of meters/sec: " + mt);
        System.out.println("The calculation speed of miles/hr: " + miles);
    }
}
