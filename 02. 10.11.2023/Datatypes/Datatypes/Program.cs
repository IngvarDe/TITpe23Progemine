// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//bool andmetüüp toetab ainult true ja false-i
bool check  = true;
bool negative  = false;

//byte max väärtus on 256 numbrit
//0 käsitleb arvuti meie mõttes, kui ühte
byte a = 255;

//sbyte-ga saab käsitleda nii negatiivset, kui ka positiivset väärtust
//8-biti ulatuses
sbyte b = 127;

//char on tähemärk
char ch = 'H';
char numberCh = '5';
//kui paned 5 ette (char), siis seda nimetatakse castimiseks
char numberCh1 = (char)5;

//decimal
//tuleb panna numbri järgi ja annab teada, et tegemist on decimal andmetüübiga
decimal decim = 2.1m;


//double
//on komakohaga arv
double doub = 12.4;

//float
//numbri lõppu tuleb panna f-tähemärk
float ujuvkoma = 4.56f;

//int e täisarv
//32 bitine
int täisarv = 2134345;

//uint e ainult positiivsed täisarvud
uint posTäisarv = 234;

//nint
//eripära on selles, et kui protsessor on 32 bit-ne, siis kohandub 32-biti peale
//64 biti puhul kohandub 64 biti peale
nint asd = 123;

//nuint
//eripära on selles, et kui protsessor on 32 bit-ne, siis kohandub 32-biti peale
//64 biti puhul kohandub 64 biti peale
nuint muutuja = 0;

//long
//64 bitine arv
long pikkTäisarv = 3;

//ulong
//64 bitine positiivne täisarv
ulong positiivneTäisarv64 = 123;

//short
//16 bitine arv
short lühikeArv = 0;

//ushort
//16 bitine ja ainult positiivsed arvud
ushort posLühikeArv = 123;

//string
//kõik tähemärgid, mis klaviatuuril leidub
string tähemärk = "qwegdf123763457760!#$^*(?>{}";
