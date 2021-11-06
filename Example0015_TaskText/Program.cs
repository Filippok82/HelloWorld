// Задача с текстом 
/* Дан текст, в тексте нужно все пробелы заменить черточками, 
маленькие буквы "м", заменить большими.Большие буквы "П", маленькими.

 */
 string text = "Программист,что это значит?"
             + "Это сильный человек!Над программой не заплачет"
             + "а работать будет век. Пусть же разные программы"
             + "пусть своим умом вы сами добиваетесь всего!";

/* string s = qwerty
              012345
    s[3] = r     */   
 string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for(int i=0; i<length; i++)
    {
        if(text [i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText); 
newText = Replace(newText, 'м', 'М');
Console.WriteLine(newText);
newText = Replace(newText, 'П', 'п');
Console.WriteLine(newText); 

