/* Write a java program to accept n names of cites from user and display them in descending
order. */

import java.io.*;
class Slip2 {
    public static void main (String args[]) throws IOException{
        int i,j;
        String str[]=new String[5] ;
        String s1;
        String s2,temp;
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        for (j=0;j<5;j++) {
            System.out.println("Enter the name "+j+" of the Cities :=> ");
            str[j]= br.readLine();
        }

        System.out.println("\nSorted Strings in Descending order are :-");
        for(j=0;j<5;j++) {

            for(i=j+1;i<5;i++) {
                if(str[j].compareTo(str[i])<0) {
                    temp=str[i];
                    str[i]=str[j];
                    str[j]=temp;
                }
            }
            System.out.println(str[j]);
        }
    }
}
