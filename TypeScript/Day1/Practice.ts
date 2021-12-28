var Age : number = 21;
var Name : string = "Devendra";
var IsUpdated : boolean = true;

//Template String
let FirstName : string = "Devendra";
let lastName : string = "Finance";

let Name1 : string = FirstName + " " + lastName;
let Name2 : string = `${FirstName}  ${lastName}`;
console.log(Name1);
console.log(Name2);


//Array 
var list1 : number[] = [1, 2, 3];
var list2 : Array<number> = [2, 3, 1];

//Multitype Array
let Values1 : (String | number)[] = ['Apple', 2, 'Orange', 3, 4];
let Values2 : Array<string | number> = ['Apple', 2, 'Orange', 3, 4];

//Accessing Array Elements
for (var index in list1)
{
    console.log(list1[index]);
}

for (var i = 0; i < Values1.length; i++)
{
    console.log(Values1[i]);
}

for (var value of Values2)
{
    console.log(Values2);
}

//Array Method example
var Fruits : Array<string> = ['Apple', 'Orange', 'Banana'];
Fruits.sort();
console.log(Fruits);

console.log(Fruits.pop());

Fruits.push('Papaya');

