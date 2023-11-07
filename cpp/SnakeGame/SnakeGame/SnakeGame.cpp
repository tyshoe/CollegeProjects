//other ideas...
//prevent apple from spawning in snake
//create cross save between plays with io files
//create game-modes like invisible tail or invisible apples
//user option to change color of snake or apples

#include <iostream>
#include <conio.h>
#include <Windows.h>
#include <dos.h>

using namespace std;

bool gameOver; //gameover condition

const int width = 16; //x axis for playing room
const int height = 16; //y acis for playing room

int x, y;//head position

int fruitX, fruitY;//fruit position

int score, highScore; //scoring

int tailX[100], tailY[100];//tail
int tailLength;

enum eDirection { STOP = 0, LEFT, RIGHT, UP, DOWN };
eDirection dir;

int difficulty = 75;//diffuclty integer that represent refresh rate in ms (fps)
string dif;//string to convert difficulty integer to word (easy, medium, hard)

void Setup()//sets defualt conditions
{
    gameOver = false;
    dir = STOP;
    x = width / 2;
    y = height / 2;
    fruitX = rand() % width;
    fruitY = rand() % height;
    score = 0;//resets score
    tailLength = 0;//makes it so tails don't carry over every game
}

void Draw()//draws snake, fruit, and board
{
    system("cls");

    //top wall
    for (int i = 0; i < width+2; i++)
        cout << "-"; 
    cout << endl;

    //between top and bottom wall
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (j == 0)//left wall
                cout << "|";

            if (i == y && j == x)//head
                printf("\x1B[42;37m:\033[0m");

            else if (i == fruitY && j == fruitX)//fruit
            {
                
                printf("\x1B[41;37m \033[0m");
              
            }

            else //tail
            {
                bool print = false;
                for (int k = 0; k < tailLength; k++)
                {
                    if (tailX[k] == j && tailY[k] == i)
                    {
                        printf("\x1B[42;37m \033[0m");
                        print = true;
                    }
                }
                if (!print)
                    cout << " ";
            }   
            if (j == width - 1)
                cout << "|"; //right wall
        }
        cout << endl;
    }

    //bottom wall
    for (int i = 0; i < width+2; i++)
        cout << "-";
    cout << endl;

    //difficulty
    cout << "Difficulty: " << dif;
    //scores
    cout << "Score: " << score << endl;
    cout << "High Score: " << highScore << endl;
}
void Input()//takes user insput
{
    if (_kbhit())
    {
        switch (_getch())
        {
        case 'w':
            if (dir != DOWN) //if statements prevent snake from going reverse direction of its current
            { dir = UP; }
            break;
        case 'a' :
            if (dir != RIGHT)
            { dir = LEFT; }
            break;
        case 'd':
            if (dir != LEFT)
            { dir = RIGHT; }
            break;
        case 's':
            if (dir != UP)
            { dir = DOWN; }
            break;
        case 'x':
            gameOver = true;
            break;
        }
    }
}

void Logic()
{
   //tail
    int prevX = tailX[0];
    int prevY = tailY[0];
    int prev2X, prev2Y;
    tailX[0] = x;
    tailY[0] = y;
    for (int i = 1; i < tailLength; i++)
    {
        prev2X = tailX[i];
        prev2Y = tailY[i];
        tailX[i] = prevX;
        tailY[i] = prevY;
        prevX = prev2X;
        prevY = prev2Y;

        //if snake eats tail
        if (x == tailX[i] && y == tailY[i])
        {
            gameOver = true;
            cout << "You ate your tail.  Try Again? \n";
        }
        
    }

    //direction 
    switch (dir)
    {
    case UP:
        y--;
        break;

    case LEFT:
        x--;
        break;

    case RIGHT:
        x++;
        break;

    case DOWN:
        y++;
        break;

    default:
        break;
    }

    //if snake hits wall
    if (x == width || x < 0 || y == height || y < 0)
    {
        gameOver = true;
        cout << "You ate the wall.  Try Again? \n";
    }

    //if snake eats fruit
    if (x == fruitX && y == fruitY)
    {
        score += 1;
        fruitX = rand() % width;
        fruitY = rand() % height;
        tailLength++;
    }

    //if new high score
    if (score > highScore)
        highScore = score;
}

void mainMenu()
{
    //logic to determine difficulty
    if (difficulty == 75)
        dif = "Easy\n";
    else if (difficulty == 50)
        dif = "Medium\n";
    else if (difficulty == 25)
        dif = "Hard\n";
    else if (difficulty == 1)
        dif = "1 ms\n";

    cout <<
        "-------------------\n" <<
        "| The Snake Game  |\n" <<
        "| 1. Play         |\n" <<
        "| 2. Difficulty   |\n" <<
        "| 3. Hi-Score     |\n" <<
        "| 4. Exit         |\n" <<
        "-------------------\n" <<
        "Difficulty: " << dif << 
        "-------------------\n";
}


int main()
{
    int choice;
    int choice2;

    while (true)
    {
        mainMenu();

        //user choice
        cin >> choice;
        
        //exit choice
        if (choice == 4)
            break;

        switch (choice)
        {
        case 1:
            Setup();
            Logic();
            while (!gameOver)
            {
                Draw();
                Input();
                Logic();
                Sleep(difficulty);
            }
            break;
        case 2:
            cout <<
                "Choose your difficulty\n" <<
                "| 1. Easy   |\n" <<
                "| 2. Medium |\n" <<
                "| 3. Hard   |\n" <<
                "| 4. 1 ms   |\n";
                cin >> choice2;

                if (choice2 == 1)
                    difficulty = 75;
                if (choice2 == 2)
                    difficulty = 50;
                if (choice2 == 3)
                    difficulty = 25;
                if (choice2 == 4)
                    difficulty = 1;
            break;
        case 3:
            cout << "Highest Score: " << highScore;
            cout << "\n";
            break;
        default: 
            cout << "Enter a valid option" << endl;
            cin.clear();
            cin.ignore(123, '\n');
            break;
        }
  
    }
    
    return 0;
}
