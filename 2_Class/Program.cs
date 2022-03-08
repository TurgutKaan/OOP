
using _2_Class;

int[] a = { 1, 2, 3, 4, 5 }; // object initilazer
int[] b;
//b={1,2,3,4,5}; bu şekilde atama söz konusu olamaz. Sadece aşağıdaki kod örneğindeki gibi kullanabiliriz.
b=new int[] { 1, 2, 3, 4, 5 };

Islem islem = new Islem();
islem.nums = new int[] { 1, 3, 2, 5, 4 };

Islem islem2 = new Islem();
islem2.nums = new int[4];
islem2.nums[0] = 4;
islem2.nums[1] = 3;
islem2.nums[2] = 2;
islem2.nums[3] = 1;

islem.Print();
islem2.Print();

islem.Sort();



