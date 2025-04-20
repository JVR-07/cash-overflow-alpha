using chash_overflow_source;

//*******************************************************************
// Variables
bool Running = false;
char SelectedOption = ' ';
float CurrentBalance = 0f;
//*******************************************************************
do
{
    Console.Clear();
    Running = true;
    Illustrator.PrintMenuSection(CurrentBalance);
    SelectedOption = Convert.ToChar(Console.ReadLine());

    switch (SelectedOption)
    {
        case '1': 
            {
                Console.Clear();
                CurrentBalance = Illustrator.PrintAddSection();
            }
            break;
        case 'e': 
            {
                Running = false; 
            } 
            break;
        default: { } break;
    }
}
while (Running == true);

