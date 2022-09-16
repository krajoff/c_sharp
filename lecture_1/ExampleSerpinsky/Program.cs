int xa = 20, ya = 1,
    xb = xa*2, yb = xa,
    xc = 1, yc = xa;
Console.SetCursorPosition(xa,ya);
Console.WriteLine('+');
Console.SetCursorPosition(xb,yb);
Console.WriteLine('+'); 
Console.SetCursorPosition(xc,yc);
Console.WriteLine('+'); 

int x = xa, y = ya;
int count = 0;

while(count<5000)
{
    int what = new Random().Next(0,3);
    if(what==0){
        x=(x+xa)/2; 
        y=(y+ya)/2;
    }
    if(what==1){
        x=(x+xb)/2; 
        y=(y+yb)/2;
    }
    if(what==2){
        x=(x+xc)/2; 
        y=(y+yc)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.Write('.');
    count++;
}
Console.SetCursorPosition(xa,yb);