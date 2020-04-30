//Q8.Import a module containing the constants and method for calculating area of circle, rectangle, cylinder.

export default class Area{

  areaCircle(rad)
  {
    console.log(`Area of circle:${3.14*rad*rad}`); ;
  }
   areaReactangle(length,breadth)
  {
    console.log(`Area of rectange:${length*breadth}`);
  }
   areaCylinder(rad,height)
  {
    console.log(`Area of cylinder:${(2*3.14*rad*height)+(2*3.14*rad*rad)}`);
  }
}
