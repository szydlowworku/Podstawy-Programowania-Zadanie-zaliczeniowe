using System;

public class Program
    {
        public static void Main()
        {
            Console.WriteLine("How many fingers am I holding up (feet included!)?"
            )
            Console.WriteLine("Say \"hi\" to begin");
            
            string greeting = Console.ReadLine();
            
            if (greeting == "hi"){
                Game();
            } else {
                Console.WriteLine(":( it was supposed to be hi...");
                Console.ReadLine();
            }
        }
        
        public static void Game(){
            Random random = new();
            int randomNumber = random.Next(0, 21); 
            //Console.WriteLine(randomNumber);
            
            int attempts = 7;
            
            while (attempts > 0){
                Console.WriteLine("Attempts left: " + attempts);
            
                int ans = ProcessUserInputToInt();
                
                CompareAnswerToTarget(randomNumber, ans);
                
                attempts--;
            }
            Console.WriteLine("wrong! u lost :(");
            Console.ReadLine();
        }

        public static int ProcessUserInputToInt(){
            int ans;
            while (true){
                if (int.TryParse(Console.ReadLine(), out ans))
                {
                    Console.WriteLine("you entered: " + ans);
                    return ans;
                }
                else
                {
                    Console.WriteLine("not a number!");
                    //attempts++;
                }
            }
        }

        public static int CompareAnswerToTarget(int target, int ans){
            if (target == ans) {
                Console.WriteLine("ggs");
                Console.ReadKey();
                Environment.Exit(1);
            } 
            else if ((target > ans) & (Math.Abs(target - ans) > 5)){
                Console.WriteLine("a lot more");
            } 
            else if ((target > ans) & (Math.Abs(target - ans) <= 5)){
                Console.WriteLine("a little more");
            }
            else if ((target < ans) & (Math.Abs(target - ans) > 5)){
                Console.WriteLine("a lot less");
            } 
            else if ((target < ans) & (Math.Abs(target - ans) <= 5)){
                Console.WriteLine("a little less");
            }
            return 0;
        }
    }