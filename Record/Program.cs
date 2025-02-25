//تاپ لول یدونه میتونه در سطح پروژه باشه
// رکورد ها از دات 8 اضافه شد
//خودش در هسته پراپرتی میسازه که گت و اینیت داره
//چون که اینیت هست اجازه تغییر نمیده
//اگر نخوای به صورت آبجکت اینیشیالایزر پر نشه و ساده مقدار دهی بشه باید مثل کلاس داخلش پراپرتی درست کنی
using Record;

//Student student = new Student("Hamed", "Shams")
//{
//    Mobile = new[] { "Splinter", "TMNT", "Scarface" }
//};

Indexer indexer = new Indexer(3);
indexer[0] = "Hamed";
indexer[1] = "Shams";
indexer[2] = "Splinter";

Console.WriteLine(indexer[0]);
Console.WriteLine(indexer[1]);
Console.WriteLine(indexer[2]);