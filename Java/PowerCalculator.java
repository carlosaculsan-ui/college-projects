import java.util.Scanner;

public class MachineProblem6 {
    public static void main(String[] args) {
        Scanner number = new Scanner(System.in);
        double base, exp, ans;

        System.out.println("Enter base");
        base = number.nextDouble();
        System.out.println("Enter exponent ");
        exp = number.nextDouble();

        ans = Math.pow(base, exp);

        System.out.println("The answer is: " + ans);

        number.close();










    }


}
