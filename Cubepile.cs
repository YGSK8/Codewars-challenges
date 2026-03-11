namespace Katas.CubePile;

public class ASum {
	
	public static long findNb(long m) {
		long sum = 0;
        long n = 1;
        while(sum != m)
        {
            sum += n*n*n;
            n++;
            if(sum > m){n=0;break;}
        }
        return n-1;
	}
	
}
