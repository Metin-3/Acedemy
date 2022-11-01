let arr = [6,7,9,24,12,23,11,8,18]
let max = arr[0];
let min = arr[1];

for(let i=0; i<=arr.length; i++){
    if(arr[i] > max){
        max = arr[i];
   }

   if(arr[i] < min){
       min = arr[i];
   }

}

console.log("Answer: ", max - min);
