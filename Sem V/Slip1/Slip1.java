import java.io.BufferedReader;
import java.io.FileReader;
import java.io.InputStreamReader;

public class Slip1 {

    public static void main(String[] args) throws Exception {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Enter file name");
        FileReader fr = new FileReader("C:\\Users\\lenovo\\Documents\\Slip1.txt");
        int ch;
        while((ch=fr.read())!=-1){
            char c = (char)ch;
            if(Character.isUpperCase(c)){
                c=Character.toLowerCase(c);
                System.out.println(c);
            } else if(Character.isLowerCase(c)){
                c=Character.toUpperCase(c);
                System.out.println(c);
            } else if(Character.isSpaceChar(c)) {
                System.out.println(c + "Space");
            } else
                System.out.println(c);
        }
        fr.close();
    }


}