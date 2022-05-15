Random rand = new Random();

int koszty = 0;
int wygrana = 0;

int trójki = 0;
int czwórki = 0;
int piątki = 0;
int szóstki = 0;

int[] prawidłowe_liczby = new int[6];
int[] liczby = new int[6];

int ilość_prób = 0;

int IsEqual(int[] arr1, int[] arr2)
{
    Array.Sort(arr1);
    Array.Sort(arr2);

    int counter = 0;

    for (int i = 0; i < arr1.Length; i++)
    {
        if(arr1[i] == arr2[i]) counter++; 
    }

    if(counter >= 3) return counter;
    else return 0;
}

for (int i = 0; i < 50000000; i++)
{
    for (int j = 0; j < prawidłowe_liczby.Length; j++)
    {
        prawidłowe_liczby[j] = rand.Next(1, 50);
    }
    
    for (int k = 0; k < liczby.Length; k++)
    {
        liczby[k] = rand.Next(1, 50);
    }
    
    int isEqual = IsEqual(prawidłowe_liczby, liczby);
    
    if(isEqual < 3) {koszty += 3; ilość_prób++; continue;}
    
    switch(isEqual)
    {
        case 3:
            koszty += 3; 
            ilość_prób++;
            trójki++;
            wygrana += 24;
            break;
        case 4:
            koszty += 3;
            ilość_prób++;
            czwórki++;
            wygrana += 170;
            break;
        case 5:
            koszty += 3;
            ilość_prób++;
            piątki++;
            wygrana += 5300;
            break;
        case 6:
            koszty += 3;
            ilość_prób++;
            szóstki++;
            wygrana += 2000000;
            break;
    }
}

Console.WriteLine($"ilosc prob: {ilość_prób}\nlacznych wygranych: {trójki + czwórki + piątki + szóstki}\nilosc 3: {trójki}");
Console.WriteLine($"ilosc 4: {czwórki}\nilosc 5: {piątki}\nilosc 6: {szóstki}\nkoszty lotto: {koszty}\nilosc wygranej: {wygrana}");
Console.WriteLine($"laczna zdobytej kasy: {wygrana - koszty}");

Console.ReadLine();