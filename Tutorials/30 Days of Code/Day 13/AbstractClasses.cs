using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}

class MyBook : Book
{
    private int price;
    
    public MyBook(string title, string author, int price) : base(title, author)
    {
        this.price = price;
    }
    
    public override void display()
    {
        Console.WriteLine("Title: " + base.title);
        Console.WriteLine("Author: " + base.author);
        Console.WriteLine("Price: " + price.ToString());
    }
}

class Solution {
    static void Main(String[] args) {
      String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}