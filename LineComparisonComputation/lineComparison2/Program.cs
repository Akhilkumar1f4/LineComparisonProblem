
int x1, x2, y1, y2;
Console.WriteLine("enter x1 point ");
x1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("enter x2 point");
x2 =  Convert.ToInt16(Console.ReadLine());
Console.WriteLine("enter y1 point");
y1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("enter y2 point");
y2 = Convert.ToInt16(Console.ReadLine());
double Length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
Console.WriteLine(Length);