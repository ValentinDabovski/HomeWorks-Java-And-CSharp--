import java.util.Scanner;


public class ParkingSystem {

    static int stepCount = 1;

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String[] parkingSize = sc.nextLine().split(" ");
        int r = Integer.parseInt(parkingSize[0]);
        int c = Integer.parseInt(parkingSize[1]);
        int[][] parking = new int[r][c];
        String[] cordinates = sc.nextLine().split(" ");

        while (!cordinates[0].equals("stop")) {
            stepCount = 1;
            int startRow = Integer.parseInt(cordinates[0]);
            int row = Integer.parseInt(cordinates[1]);
            int col = Integer.parseInt(cordinates[2]);
            stepCount += Math.abs(startRow - row);

            boolean hasZero = false;
            for (int i = 1; i < c; i++) {
                if (parking[row][i] == 0) {
                    hasZero = true;
                    break;
                }
            }

            if (hasZero == false) {
                System.out.printf("Row %d full%n",row);
            } else {
                if (parking[row][col] == 0) {
                    stepCount += col;
                    parking[row][col] = 1;

                } else {
                    int closestSpotIndex = findFreeParkingSpot(parking, row, col, c);
                    stepCount += closestSpotIndex;
                    parking[row][closestSpotIndex] = 1;
                }

                System.out.println(stepCount);
            }

            cordinates = sc.nextLine().split(" ");
        }
    }

    private static int findFreeParkingSpot(int[][] parking, int row, int col, int c) {
        int firstRightFreeSpot = Integer.MAX_VALUE;
        int firstLeftFreeSpot = Integer.MAX_VALUE;

        for (int i = col + 1; i < c; i++) {

            if (parking[row][i] == 0) {
                firstRightFreeSpot = i;
                break;
            }
        }

        for (int i = col - 1; i > 0; i--) {

            if (parking[row][i] == 0) {
                firstLeftFreeSpot = i;
                break;
            }

        }

        if (Math.abs(col - firstLeftFreeSpot) <= (Math.abs(firstRightFreeSpot - col))) {
            return firstLeftFreeSpot;

        } else {
            return firstRightFreeSpot;
        }
    }
}