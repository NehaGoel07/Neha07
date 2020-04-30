//Q9. Import a module for filtering unique elements in an array.

function filterArray(){
  let arrayRepeated=[1,2,3,1,2];
  let arrayUnique=[new Set(arrayRepeated)];
  let iterate=arrayUnique.values();
  console.log(iterate.next().value);
}



export {filterArray};
