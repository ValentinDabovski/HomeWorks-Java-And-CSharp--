import jdk.nashorn.internal.runtime.regexp.joni.ScanEnvironment;
import jdk.nashorn.internal.runtime.regexp.joni.ast.StringNode;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class EventsProblem4 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        String[] cities = {};

        int eventCount = sc.nextInt();
        sc.nextLine();
        Map<String, TreeSet<String>> personLocation = new TreeMap<>();
        Map<String, ArrayList<String>> personTime = new TreeMap<>();

        for (int i = 0; i <= eventCount; i++) {

            if (i == eventCount) {
                cities = sc.nextLine().split(",");
                Arrays.sort(cities);
                break;
            }


            String input = sc.nextLine();
            Matcher matcher = Pattern
                    .compile("^(#([A-Za-z]+):\\s*@([A-Za-z]+)\\s*([0-9]+:[0-9]+))$")
                    .matcher(input);

            while (matcher.find()) {

                String name = matcher.group(2);
                String location = matcher.group(3);
                String time = matcher.group(4);

                boolean isTimeValid = validateTime(time);

                if (isTimeValid) {

                    if (!personLocation.containsKey(location)) {
                        personLocation.put(location, new TreeSet<>());
                    }

                    if (!personTime.containsKey(name)) {
                        personTime.put(name, new ArrayList<>());
                    }

                    personLocation.get(location).add(name);
                    personTime.get(name).add(time);

                }
            }


        }

        for (String city : cities) {
            if (!personLocation.containsKey(city)){
                continue;
            }

            System.out.println(city + ":");
            personLocation.entrySet().stream().filter(p -> p.getKey().equals(city)).forEach(pair -> {
                int counter = 0;
                for (String name : pair.getValue()) {

                    String times = personTime.get(name).toString();
                    ArrayList<String> sored = (personTime.get(name)).stream()
                            .sorted((x, y) -> x.compareTo(y)).collect(Collectors.toCollection(ArrayList::new));
                    System.out.printf("%d. %s -> %s%n", ++counter, name,sored.toString().replaceAll("[\\[\\]]", ""));

                }
            });
        }

    }

    private static boolean validateTime(String time) {
        int hours = Integer.parseInt(time.split(":")[0]);
        int minutes = Integer.parseInt(time.split(":")[1]);

        if (hours >= 24 && minutes >= 60) {
            return false;
        }

        return true;
    }
}
