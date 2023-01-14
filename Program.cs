Random dice = new();

int [] arr = new int [5];
arr[0]=dice.Next(1, 7);
arr[1]=dice.Next(1, 7);
arr[2]=dice.Next(1, 7);
arr[3]=dice.Next(1, 7);
arr[4]=dice.Next(1, 7);

for (int k = 0;k<5;k = k+1)
{
Console.WriteLine(arr[k]);

}

int Shet =0;
for (int i = 0;i<=5;i++)
{
    for (int j = i+1;j<=4;j++)
    {
        if (arr[i]==arr[j]) 
        {
            Shet=Shet+1;
            break;
        }
        else
        {
        }

    }

}
Console.WriteLine("Itogo:");
Console.WriteLine(Shet);