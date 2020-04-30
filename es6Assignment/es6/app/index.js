import Area from './calculate';
import {filterArray} from './filterArray'

//Q1. Given this array: `[3,62,234,7,23,74,23,76,92]`, Using arrow function, create an array of the numbers greater than `70`.

let arr=[3,62,234,7,23,74,23,76,92];
let arr1=arr.filter((n)=>n>70);
console.log('************Solution1************');
console.log(arr1);

//Q2

console.log('************Solution2************');
console.log('//Select all the list items on the page and convert to array.//');
const items = Array.from(document.getElementById("list").querySelectorAll("li"));
console.log(items);

console.log('//Filter for only the elements that contain the word flexbox//');
const filtered = items.filter(item => item.textContent.includes('Flexbox'));
  for(let i of filtered)
  {
    console.log(i);
  }
console.log("//Map down to a list of time strings//");
var mapFilter=filtered.map(item => item.dataset.time);
console.log(mapFilter);

console.log('//Map to an array of seconds//');
var mapSeconds=mapFilter.map(sec => {
      const parts = sec.split(':').map(part => parseFloat(part));
      return (parts[0] * 60) + parts[1];
    });
    console.log(mapSeconds);

    console.log('//Reduce to get total using .filter and .map//');
    var reduceMap=mapSeconds.reduce((runningTotal, seconds) => runningTotal + seconds);
    console.log(reduceMap);

//Q3. Create a markup template using string literal

const song = {
 name: 'Dying to live',
 artist: 'Tupac',
 featuring: 'Biggie Smalls'
};

let markupTemplate=`
<div class="song">
<p>${song.name}---${song.artist} <br/>
(Featuring ${song.featuring})</p>
</div>`;
document.body.innerHTML = markupTemplate;


//Q4. Extract all keys inside address object from user object using destructuring ?

const user = {
                  firstName: 'Sahil',
                  lastName: 'Dua',
                  Address: {
                                Line1: 'address line 1',
                                Line2: 'address line 2',
                                State: 'Delhi',
                                Pin: 110085,
                                Country: 'India',
                                City: 'New Delhi',
                           },
                phoneNo: 9999999999
              };

let {Line1,Line2,State,Pin,Country,City}=user.Address;
console.log('************Solution4************');
console.log(`Keys inside address object within user object are:-
Line1 : ${Line1}
Line2 : ${Line2}
State : ${State}
Pin : ${Pin}
Country : ${Country}
City : ${City}`);

// Q4.Filter unique array members using Set.

const  arrElements=[0,1,2,3,4,1,2,4,5,6,7,2,3,9,3,9];
const arrUnique=[new Set(arrElements)];
let arrUniqueIteration=arrUnique.values();
console.log('************Solution4************');
console.log(arrUniqueIteration.next().value);

//Q5.Find the possible combinations of a string and store them in a MAP?
console.log('************Solution5************');
function printCombo(strAccepted, ans)
    {
        if (strAccepted.length == 0) {
          let strMap=new Map();
            strMap.set(ans + " ");

            console.log(strMap);
            return strMap;
        }

        for (var i = 0; i < strAccepted.length; i++)
        {
            let character = strAccepted.charAt(i);
            let ros = strAccepted.substring(0, i) + strAccepted.substring(i + 1);
            printCombo(ros, ans + character);
        }
    }
printCombo("bat"," ");


//Q6. Write a program to implement inheritance upto 3 classes.The Class must  public variables and static functions.

class Shapes
{
  constructor(name)
  {
    this.name=name;
  }
  parentClass()
  {
    console.log(`Parent class is:${this.name}.`);
  }
  static shape(type)
  {
    console.log(`Type of shape is ${type}`);
  }
}
class Polygon extends Shapes
{
  constructor(s)
  {
    super("Shapes");
    this.s=s;
  }
  info()
  {
    console.log(`We are working on a polygon with ${this.s} size.`);
  }
  static poly(sides)
  {
    console.log(`Polygon has ${sides} sides.`);
  }
}
class Rectangle extends Polygon
{

  constructor(s,length,breadth)
  {
    super(s);
    this.length=length;
    this.breadth=breadth;
  }
  rect()
  {
    console.log(`Length:${this.length} Breadth:${this.breadth} `);
  }
  static area(length,breadth)
  {
    console.log(`Area of rectangle is:${length*breadth}`);
  }
}
console.log('************Solution6************');
let rectObj = new Rectangle(4,5,4);
rectObj.rect();
Rectangle.area(4,5);
rectObj.info();
Rectangle.poly(4);
rectObj.parentClass();
Rectangle.shape('polygon');

//Q7. Write a program to implement a class having static functions

class staticFunctionClass
{
  static hello(){
    console.log("Hello from static function!!");
    let object={
      name:'Neha',
      competency:'.NET'
    }
    console.log(`Name:${object.name} Competency:${object.competency}`);
  }
}
console.log('************Solution7************');
staticFunctionClass.hello();

//Q8. Import a module containing the constants and method for calculating area of circle, rectangle, cylinder.

console.log('************Solution8************');
let arObj=new Area();
arObj.areaCircle(5);
arObj.areaReactangle(7,8);
arObj.areaCylinder(3,19);

//Q9. Import a module for filtering unique elements in an array.

console.log('************Solution9************');
filterArray();

//Q10.Write a program to flatten a nested array to single level using arrow functions.

console.log('************Solution10************');
const nestedArray=[1,2,[3,4,[9,4,[11,5,[23,15]]]]];
const flatArray=(nestedArray)=>console.log(nestedArray.flat(4));
flatArray(nestedArray);

//Q11.Implement a singly linked list in es6 and implement addFirst() addLast(), length(), getFirst(), getLast(). (without using array)

console.log('************Solution11************');
class LinkedList {
  constructor() {
    this.head = null;
    this.tail = null;
    this.count = 0;
  }

getFirst()
{
  return this.head.data;
}

getLast()
{
  return this.tail.data;
}
length() {
    return this.count;
  }

  addLast(data) {
    const node = {
      data: data,
      next: null
    }

    if(this.count === 0) {
      this.head = node;
    }
    else
    {
      this.tail.next = node;
    }

    this.tail = node;

    this.count++;
  }

  addFirst(data) {
    const node = {
      data: data,
      next: null
    }

    const temp = this.head;

    this.head = node;

    this.head.next = temp;

    this.count++;

    if(this.count === 1) {

      this.tail = this.head;
    }
  }

  //Used in stack for pop operation
  removeFirstElement()
  {
    if(this.count>0)
    {
      this.head=this.head.next;
      this.count--;
      if(this.count==0)
      {
        this.tail=null;
      }
    }
  }
}
let linkedList=new LinkedList();
linkedList.addFirst(5);
linkedList.addFirst(4);
linkedList.addFirst(9);
linkedList.addFirst(1);
linkedList.addLast(10);
linkedList.addLast(12);
let first=linkedList.getFirst();
console.log(`First Element:${linkedList.getFirst()}`);
console.log(`Last Element:${linkedList.getLast()}`);
console.log(`Length of linked list:${linkedList.length()}`);

//Q12. Implement Map and Set using Es6

console.log('************Solution12************');
console.log('//Implementing Map//');
let arrayMap=[2,3,5,6];
let mul=arrayMap.map((n)=>n*n);
console.log(mul);
console.log('//Implementing Set//');
let progLang=new Set();
progLang.add('.NET');
progLang.add('Java');
progLang.add('Python');
for(let lang of progLang.values())
{
  console.log(lang);
}

//Q13. Implementation of stack (using linked list)

console.log('************Solution13************');
class Stack {
  constructor() {
    this.list = new LinkedList();
  }
  push(item) {
    this.list.addFirst(item);
  }
  pop() {
    if(!this.list.length) {
      return;
    };
    let val = this.list.head.data;
    this.list.removeFirstElement();
    return val;
  }
  peek() {
    if(!this.list.head) { return; }
    return this.list.head.data;
  }
  length() {
    return this.list.length();
  }
}
let stack=new Stack();
stack.push(3);
stack.push(7);
stack.push(1);
stack.push(10);
console.log(`Pop Operation:${stack.pop()}`);
console.log(`Peek Operation:${stack.peek()}`);
console.log(stack.length());
