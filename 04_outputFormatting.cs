/*
Formateo de la salida mediante secuencias de caracteres de escape

Actualizaremos el código para aplicar los últimos toques a la salida notificada. 
Para empezar, incluiremos el nombre del alumno y agregaremos una fila de encabezado 
que incluya las etiquetas de columna. Después de eso, usaremos secuencias de escape 
de caracteres para agregar más espaciado interno entre las columnas de información.
*/

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psycology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

// Variables que almacenan las calificaciones de cada curso

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

/*
Creamos una variable que almacene el número total de horas de crédito.
El total se inicializa en 0. 
Esta inicialización nos permite incrementar la suma y mantener el código organizado.
*/

int totalCreditHours = 0;

// Incremento de la suma y representación total de horas de crédito:

totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

/*
Estas líneas de código tienen el mismo resultado que agregar cada variable 
courseCrediten una línea, como por ejemplo:
totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
*/

int totalGradePoints = 0;

// Incremento la suma según los puntos de calificación obtenidos para el primer curso.

totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

//  variable que almacene el GPA final

decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

// Aplicación de formato a la salida decimal

int leadingDigit = (int) gradePointAverage;

// Inicializar una variable que almacene los dos primeros dígitos después del decimal.

int trailingDigits = (int) (gradePointAverage * 100) - (leadingDigit * 100);

/* 

En la primera mitad de esta operación, se mueven los dos dígitos decimales a la derecha. 
En la segunda mitad, va a agregamos ceros al dígito inicial. 
Después, restamos los dos y convertirá el resultado en un entero.
*/ 

// Para agregar el nombre del alumno

Console.WriteLine($"Student: {studentName}\n");

// Agregamos encabezado con la información del curso

Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

// Nombre del curso junto con calificación numérica

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

// GPA Final

Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{trailingDigits}");

/* 
Este código usa el signo $ para representar las variables 
course1Name, course1Grade y course1Credit. 
Cuando el código se ejecuta, las variables se reemplazan por sus valores 
y el resultado se imprime en la consola.
*/

/*
El código escrito divide el problema en partes administrables 
en lugar de intentar calcular el GPA en una operación grande. 
En primer lugar, inicializó y calculó el valor de totalCreditHours. 
A continuación, inicializó y calculó el valor de totalGradePoints. 
Después, usaremos estos valores en el cálculo final.
*/
