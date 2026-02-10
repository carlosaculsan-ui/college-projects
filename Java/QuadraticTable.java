  public class MachineProblem9 {
    public static void main(String[] args) {
        System.out.println("y\t x = y^2 - 2y + 1");

        for (int y = -5; y <= 5; y++) {
            int x = y * y - 2 * y + 1;
            System.out.println(y + "\t " + x);
        }
    }
}
