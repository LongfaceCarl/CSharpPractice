import java.io.*;
import java.util.*;
public class Qone{
    public static void main(String[] args) {
        String data = "Jan 1 2 3 4 5 6";
        
    }

    public static int[] switchData(String input){
        int[] date = new int[input.length() - 1];
        input.next();
        for (int i=0; i<input.length(); i++){
            date[i] = input.nextInt();
        }
        for (int i=0; i<input.length() - 1; i++){
            if (i%2==0){
                date[i+1] = date[i];
            } else{
                date[i-1] = date[i];
            }
        }
        return date;
    }

    public static void analyzeParagraphs(Scanner input){
        int lineCount = 0;
        while (input.hasNextLine()){
            if (input.nextLine() == "<p>"){
                System.out.println(lineCount + "-line paragraph");
                lineCount = 0;
            } else{
                input.nextLine();
                lineCount++;
            }
        }
    }

    public static boolean isAllPairs(int[] list){
        int i = 0;
        while (i<list.length()){
            if (list[i]==list[i+1]){
                i+=2;
            } else{
                i=7;
            }
        }
        if (i%2 == 0){
            return true;
        } else{
            return false;
        }
    }
}