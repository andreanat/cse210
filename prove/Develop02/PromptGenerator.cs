using System;
public class PromptGenerator {
    public int questionNumber = 1;
    public void MyMethod(){
        while (questionNumber <= 5) {
            switch (questionNumber){
        case 1:
            Console.Write("What kind of day are you having, and why? ");
            string name = Console.ReadLine();
            break;
        case 2:
            Console.Write("What are all the things you're grateful for today? ");
            int age = int.Parse(Console.ReadLine());
            break;
        case 3:
            Console.Write("What are three good things about today? ");
            string color = Console.ReadLine();
            break;
        case 4:
            Console.Write("What are the things you could do today to start moving towards your goals? ");
            string address = Console.ReadLine();
            break;
        case 5:
            Console.Write("What made today unique? ");
            string phoneNumber = Console.ReadLine();
            break;
    }
    questionNumber++;
}

}
}