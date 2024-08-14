string[] myArray = new string[7];
myArray[0] = "Domingo";
myArray[1] = "Segunda";
myArray[2] = "Terca";
myArray[3] = "Quarta";
myArray[4] = "Quinta";
myArray[5] = "Sexta";
myArray[6] = "Sabado";

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}

List<string> list = new List<string>();
list.Add ("Domingo");
list.Add ("Segunda");
list.Add ("Terca");
list.Add ("Quarta");
list.Add ("Quinta");
list.Add ("Sexta");
list.Add ("Sabado");

for (int i = 0; i < list.Count; i++)
{
    list[i] = list[i].Substring(0, 3);
    Console.WriteLine(list[i]);
}

Dictionary<int, string> dictionary = new Dictionary<int,string>();
dictionary[0] = "Domingo";
dictionary[1] = "Segunda";
dictionary[2] = "Terca";
dictionary[3] = "Quarta";
dictionary[4] = "Quinta";
dictionary[5] = "Sexta";
//dictionary[6] = "Sabado";
dictionary[6] = "Sabado";

for (int i = 0; i < dictionary.Count; i++)
{
    dictionary[i] = dictionary[i].Substring(0, 3);
    Console.WriteLine(dictionary[i]);
}