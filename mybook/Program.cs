using System;
using System.Collections.Generic;

namespace mybook
{
    class Program
    {
            class mybook
        {

            public string book_name; //이름
            public string first_open; //초판 발행
            public string writer; //지은이
            public string spreader; //펴낸이
            public string company; //펴낸곳
            public string one_editer; //편집
            public string planer; //기획
            public string editer; //편집
            public string designer; //디자인

        }
        static void Main(string[] args)
        {

            List<mybook> info = new List<mybook>();
            info.Add(new mybook()
            {
                book_name = "PHP 프로그래밍 입문",
                first_open = "2013년 5월 20일",
                writer = "황재호",
                spreader = "김태헌",
                company = "한빛아카데미(주)",
                one_editer = "김현용",
                planer = "김이화",
                editer = "김이화",
                designer = "여동일"
            });

            foreach (var item in info)
            {
                Console.WriteLine(
                    item.book_name +'\n'+
                    item.first_open +'\n'+
                    item.writer+'\n'+ 
                    item.spreader+'\n'+ 
                    item.company+'\n'+
                    item.one_editer+'\n'+
                    item.planer+'\n'+
                    item.editer+'\n'+ 
                    item.designer+'\n'
                    );
            }
        }
    }
}