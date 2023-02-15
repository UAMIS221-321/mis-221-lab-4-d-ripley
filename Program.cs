

Menu();

static void Menu(){
    Console.WriteLine("Enter 1 for a full triangle, 2 for a partial triangle and 3 to exit!\n1. Full Triangle\n2. Partial Triangle\n3. Exit Program");
    string UserInput = Console.ReadLine();
    if(UserInput == "1"){
        GetFull();
    }
    else if(UserInput == "2"){
        GetPartial();
    }
    else if(UserInput == "3"){
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }
    else if(UserInput != "1"+"2"+"3"){
        Console.WriteLine("Invalid Option! Please try again!");
        Menu();
    }
    
}


static void GetFull(){
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    for(int i = 0; i < number; i++)
    {
       for(int m = 0; m < i; m++)
       {
            Console.Write(0);
            
       }
       Console.WriteLine();
       
    }

}

static void GetPartial(){
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    for(int i = 0; i < number; i++)
    {
       for(int m = 0; m < i; m++)
       {
            Console.Write(0);
            if(rnd.Next(2)==0){
                Console.Write(" ");
            }
            else{
                Console.Write(0);
            }
            
       }
       Console.WriteLine();
    }
}
