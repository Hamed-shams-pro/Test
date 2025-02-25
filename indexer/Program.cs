//indexer ==> میشه به یکی از تایپ ها شبیه آرایه رفتار کرد
//برتری ای که نسبت به آرایه ساختن از خود آبجکت داره اینکه داخل خودش کپسوله شده
using System;
using indexer;

//MyCustomArray myCustomArray = new MyCustomArray(5);
//myCustomArray[0] = "Hamed";
//myCustomArray[1] = "Shams";
//myCustomArray[2] = "Splinter";

//Console.WriteLine(myCustomArray[0]);
//Console.WriteLine(myCustomArray[1]);
//Console.WriteLine(myCustomArray[2]);

// Record += dotnet 8
//رکورد از دات نت 8 اضافه شد
//اکه از کلمه اینیت به جای ست استفاده کنی فقط میتونی به صورت آبجکت اینیشیالایزر مقدار دهی کنی
Friend friend = new Friend()
{
    Name = "Hamed",
    Family = "Shams"
};
Console.WriteLine("Hamed Shams");