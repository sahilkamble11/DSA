public class Occurrences {

    public static void main(String[] args) {

        String str = "banana";

        for (int i = 0; i < str.length(); i++) {

            boolean isVisited = false;

            // Check if character already appeared
            for (int j = 0; j < i; j++) {

                if (str.charAt(i) == str.charAt(j)) {
                    isVisited = true;
                    break;
                }
            }

            // Skip if already counted
            if (isVisited) {
                continue;
            }

            int count = 0;

            // Count occurrences
            for (int k = 0; k < str.length(); k++) {

                if (str.charAt(i) == str.charAt(k)) {
                    count++;
                }
            }

            System.out.println(str.charAt(i) + " = " + count);
        }
    }
}