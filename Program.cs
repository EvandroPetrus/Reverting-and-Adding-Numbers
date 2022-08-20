// You are given two non-empty linked lists representing two non-negative integers.

// The digits are stored in reverse order, and each of their nodes contains a single digit. 

// Add the two numbers and return the sum as a linked list.

// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

// Input: l1 = [2,4,3], l2 = [5,6,4]

// Output: [7,0,8]

// Explanation: 342 + 465 = 807.

Random randomNumber = new Random();
int rng = randomNumber.Next(9);
int rng2 = randomNumber.Next(9);
int rng3 = randomNumber.Next(9);
int rng4 = randomNumber.Next(9);
int rng5 = randomNumber.Next(9);
int rng6 = randomNumber.Next(9);
int lastdigit, lastdigit2, lastdigit3;

if(rng + rng4 >= 10){
    lastdigit = (rng + rng4) % 10;
}

else{
    lastdigit = rng + rng4;
}

if (rng2 + rng5 >= 10){
    lastdigit2 = (rng2 + rng5) % 10;
}

else{
    lastdigit2 = rng2 + rng5;
}

if (rng3 + rng6 >= 10){
    lastdigit3 = (rng3 + rng6) %10;
}

else{
    lastdigit3 = rng3 + rng6;

}


Console.WriteLine($"Node 1 : {rng} -- Node 2 : {rng2} -- Node 3 : {rng3}");
Console.WriteLine($"Node 4 : {rng4} -- Node 5 : {rng5} -- Node 6 : {rng6}");
Console.WriteLine($"Node 7 : {lastdigit} -- Node 8 : {lastdigit2} -- Node 9 : {lastdigit3}");
