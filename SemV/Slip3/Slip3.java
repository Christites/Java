import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Enumeration;
import java.util.Hashtable;
import java.util.Map;

class Slip3{
    static BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

    public static void main(String[] args) {
        try{
            System.out.print("Enter number of Records\n");
            int n = Integer.parseInt(br.readLine());
            Hashtable<String,Float> hashtable = new Hashtable<String, Float>();
            for (int i = 1; i<=n; i++) {
                System.out.println("\nEnter the name of the Employee: " + i + ":");
                String name = br.readLine();
                System.out.println("\nEnter Salary of Employee: " + i + " :" );
                float Salary = Float.parseFloat(br.readLine());
                hashtable.put(name,Salary);
            }
            System.out.println("Name \t Percentage");
            Enumeration keys = hashtable.keys();
            float max = 0;

            while(keys.hasMoreElements())
            {
                String key = (String) keys.nextElement();
                float value = Float.valueOf(hashtable.get(key).toString());
                System.out.println(key + "\t" + value);
                if(max < value)
                    max = value;
            }
            System.out.println("Maximum Salary = " + max);
            for(Map.Entry m:hashtable.entrySet()) {
                float sal = Float.valueOf((m.getValue()).toString());
                if (max == sal) {
                    System.out.println("Employee name having maximum salary " + m.getKey());
                }
            }
        }
        catch (Exception e) {
            System.out.println(e);
        }
    }
}