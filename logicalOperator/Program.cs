bool value1 = true;
bool value2 = false;

//&&, ||, !
// || si unos de los valores es true da true y si todos son false todos son false
//deben ser  todas las condicones true para que delvuelva true
//te delvuelve true si la condicion es false,es decir es una negacion

bool result = value1 && value2;
Console.WriteLine("the result of the logical AND is: " + result);//false

bool result1= value1 || value2;
Console.WriteLine("the result of the logical OR is: " + result1);//true
