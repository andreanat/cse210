using System;
public class PromptGenerator {
    public void MyMethod(){
         string[] questions = {
            "What was the best thing that happened to you today?",
            "What is something that made you laugh today?",
            "What steps did you take today towards a goal you’re working on?",
            "Who made your day better today? How can you pay that feeling forward?",
            "What made today unique?",
            "What is one thing you want to remember from today?",
            "When did you feel most authentically yourself today?",
            "How can you make tomorrow (even) better than today?"
        };
        Random rand = new Random();
        for (int i = 0; i < 1; i++) {
            int questionIndex = rand.Next(0, questions.Length);
            Console.Write(questions[questionIndex] + " ");
            string response = Console.ReadLine();
        }
        
}

}
