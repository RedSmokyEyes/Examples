int Max(int arg1, int arg2, int arg3 )
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 1213123;
int b1 = 4534562;
int c1 = 6347876;
int a2 = 3453458;
int b2 = 8768684;
int c2 = 4623351;
int a3 = 7566992;
int b3 = 1212456;
int c3 = 6547458;

int max1 = Max(a1, b1, c1 );
int max2 = Max(a2, b2, c2 );
int max3 = Max(a3, b3, c3 );
int max4 = Max(max1, max2, max3 );

Console.Write("");
Console.WriteLine(max4);