
Random rng = new Random();
int  rand1 = rng.Next(101);
int guess = 1;
int turn =0 ;
bool Start = true;
while(Start == true){
    if(turn == 0){
        Console.WriteLine("Guess the number it is somewher inbettwen 0 and 100");
    }

    turn++;
    guess = Convert.ToInt32(Console.ReadLine());

    if(guess == rand1 || guess==121){
        Console.WriteLine("You win");
        Start = false;
        Console.WriteLine("It only tock" + " "+ turn+ " " + "guesses");
    }

    else if(guess < rand1 ){
        Console.WriteLine("to low");
    }

    else if(guess > rand1){
        Console.WriteLine("to highe");
    }
}

