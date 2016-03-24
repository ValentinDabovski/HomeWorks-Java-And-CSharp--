import java.util.Scanner;

public class TriangleArea {

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        int aX = scan.nextInt();
        int aY = scan.nextInt();
        int bX = scan.nextInt();
        int bY = scan.nextInt();
        int cX = scan.nextInt();
        int cY = scan.nextInt();

        int area = (aX * (bY - cY) + bX * (cY -aY) + cX * (aY-bY)) / 2;
        System.out.println(Math.abs(area));


    }
}