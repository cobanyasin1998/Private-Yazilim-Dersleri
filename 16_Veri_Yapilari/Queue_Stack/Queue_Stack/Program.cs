
//Data Structures => Queue & Stack
//FIFO - LIFO


/*
 
Queue (Kuyruk) Örnekleri:
--Fast Food Restoranı, Yazıcı Kuyruğu, Call Center

Stack (Yığın) Örnekleri:
--Web Tarayıcı Geçmişi, Program Çağrı Yığını Kitaplar (Fiziksel)
 
 
 */

using Queue_Stack;

MyQueue<int> queue = new MyQueue<int>();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

var firstElement  = queue.Dequeue();

Console.WriteLine(firstElement);


