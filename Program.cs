// test :)
#nullable disable

//wecom
Console.Clear();
Console.WriteLine("Welcome to Portal quiz.");
int score = 0;

//This feels very rudimentary code but i'm unsure of how to do more with the limited knowledge i have hm
//maybe oop or loops when i figure out how to. do that?

//test
// Q1
Console.Write("\nQ1: Who founded Aperture?");
string ans1 = Console.ReadLine().ToLower();
if (ans1 == "cave johnson" || ans1 == "cave" || ans1 == "johnson" || ans1 == "mr johnson") {
    Console.WriteLine("Correct");
    score++;
} else {
    Console.WriteLine("Incorrect");
}

// Q1
Console.Write("\nQ2: What is the name of the protagonist of the Portal franchise?");
string ans2 = Console.ReadLine().ToLower();
if (ans2 == "chell") {
    Console.WriteLine("Correct");
    score++;
} else {
    Console.WriteLine("Incorrect");
}

// Q3
Console.Write("\nQ3: What is the name of the blue Cooperative Testing Initiative bot?");
string ans3 = Console.ReadLine().ToLower();
if (ans3 == "atlas") {
    Console.WriteLine("Correct");
    score++;
} else {
    Console.WriteLine("Incorrect");
}

// Q4
Console.Write("\nQ4: Complete the quote: \"Take one last look at your precious human _____ because it cannot help you now!\"");
string ans4 = Console.ReadLine().ToLower();
if (ans4 == "moon") {
    Console.WriteLine("Correct");
    score++;
} else {
    Console.WriteLine("Incorrect");
}

//mark quiz

double total = (score/4)*100;
Console.WriteLine($"You got {score}/4 ({total}%)");
if (score == 4) {
    Console.WriteLine("Unbelievable. You, [SUBJECT NAME HERE], must be the pride of [SUBJECT HOMETOWN HERE]!");
} else if (score == 3) {
    Console.WriteLine("Not bad. I forgot how good you are at this. You should pace yourself, though. We have A LOT of tests to do.");
} else if (score == 2){
    Console.WriteLine("The Enrichment Center is required to remind you that you will be baked, and then there will be cake.");
} else if (score == 1){
    Console.WriteLine("Well done. Here come the test results: You are a horrible person. I'm serious, that's what it says: A horrible person. We weren't even testing for that.");
} else {
    Console.WriteLine("There was even going to be a party for you. A big party that all your friends were invited to. I invited your best friend, the Companion Cube. Of course, he couldn't come because you murdered him. All your other friends couldn't come, either, because you don't have any other friends because of how unlikable you are. It says so right here in your personnel file: \"Unlikable. Liked by no one. A bitter, unlikable loner, whose passing shall not be mourned. Shall NOT be mourned.\" That's exactly what it says. Very formal. Very official. It also says you were adopted, so that's funny, too.");
}

