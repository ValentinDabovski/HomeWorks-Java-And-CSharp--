
import java.util.*;

public class RandomizeNumbersFromNToM {

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        List<Integer> arrayInts = new ArrayList<Integer>();

        int n = scan.nextInt();
        int m = scan.nextInt();

        int z = 0;
        if (n > m) {
            z = n;
            n = m;
            m = z;
        }


        for (int i = n; i <= m; i++) {
            arrayInts.add(i);
        }
        Collections.shuffle(arrayInts);

        for (Integer anInt : arrayInts) {

            System.out.print(anInt + " ");
        }
    }

}

