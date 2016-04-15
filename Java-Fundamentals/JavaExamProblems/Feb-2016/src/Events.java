import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Events {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int eventCount = sc.nextInt();

        Map<String, Map<String,TreeSet<String>>> eventsData = new TreeMap<>();

        for (int i = 0; i <eventCount ; i++) {

            String currnetLine = sc.nextLine();
            Matcher matcher = Pattern.compile("#([a-zA-Z]+):.*?@([A-Za-z]+)\\s*((2[0-3]|[0-1]?[0-9]):([0-5][0-9]))").matcher(currnetLine);

            if (matcher.find()) {
                String name = matcher.group(1);
                String location = matcher.group(2);
                String time = matcher.group(3);

                if (!eventsData.containsKey(location)) {
                    eventsData.put(location, new TreeMap<>());
                }

                if (!eventsData.get(location).containsKey(name)) {
                    eventsData.get(location).put(name, new TreeSet<>());
                }

                eventsData.get(location).get(name).add(time);
            }
        }

        String[] locationsToPrint = sc.nextLine().split(",");

        Set<String> sortedLocations = new TreeSet<>();

        for (String location : sortedLocations) {
            sortedLocations.add(location);
        }

        for (String location : sortedLocations) {
            if (eventsData.containsKey(location)) {
                System.out.println(location + ":");
                int artistCount = 1;

                for (String artist : eventsData.get(location).keySet()) {
                    TreeSet<String> currentArtistTimes = eventsData.get(location).get(artist);

                    System.out.println(artistCount + ". " + artist + " ->" + String.join(",",currentArtistTimes) ) ;
                    artistCount++;
                }
            }
        }
    }
}
