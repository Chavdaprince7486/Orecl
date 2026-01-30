using System;
class main
{
	static void Main(string[] args)
	{
		int r=Convert.ToInt32(Console.ReadLine());
		int[][] J_array=new int[r][];
		for(int i=0;i<J_array.Length;i++)
		{
			int c=Convert.ToInt32(Console.ReadLine());
			J_array[i]=new int[c];
			//J_array[0](row)=new [2](Column);
		}
		for(int i=0;i<J_array.Length;i++)
		{
			for(int j=0;j<J_array[i].Length;j++)
			{
				Console.WriteLine(J_array[i][c]);
			}
		}
	}
	
}