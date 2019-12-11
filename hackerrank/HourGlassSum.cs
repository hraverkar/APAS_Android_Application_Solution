using System;

class MainClass {
    static void Main() {
        
        int[,] arr=new int[6,6];//declaration of 2D array  
        arr[0,0]=1;
        arr[0,1]=1;//initialization  
        arr[0,2]=1;
        arr[1,1]=1;
        arr[2,0]=1;
        arr[2,1]=1;
        arr[2,2]=1;
        arr[3,2]=2;
        arr[3,3]=4;
        arr[3,4]=4;
        arr[4,3]=2;
        arr[5,2]=1;
        arr[5,3]=2;
        arr[5,4]=4;  
        //traversal  
        for(int i=0;i<6;i++){  
            for(int j=0;j<6;j++){  
                Console.Write(arr[i,j]+" ");  
            }  
            Console.WriteLine();//new line at each row  
        }
    
    var test = new Test();    
        var p = test.maxHourglass(arr);
        Console.WriteLine("hourglassSum is : "+p);
    }
}

class Test{
    
     public int maxHourglass(int [,] arr) {
    int max = Int32.MinValue;
        for (int row = 0; row < 4; row++) {
            for (int col = 0; col < 4; col++) {
                int sum = findSum(arr, row, col);
                max = Math.Max(max, sum);
            }
        }
        return max;
    }
    
    private int findSum(int [,] arr, int r, int c) {
        int sum = arr[r+0,c+0] + arr[r+0,c+1] + arr[r+0,c+2] 
                                + arr[r+1,c+1] + 
                  arr[r+2,c+0] + arr[r+2,c+1] + arr[r+2,c+2];
        return sum;
    }
}
