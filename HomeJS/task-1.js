let arr = [ 9,7,4,5,1];
let max = arr[0];
let min = arr[1];
let sum = 0;

for (let i = 0; i < arr.length; i++){
    if(arr[i] > max){
         max = arr[i];
    }

    if(arr[i] < min){
        min = arr[i];
    }
}

for(let i = 0; i < arr.length; i++){
    if(max != arr[i] && min != arr[i]){
        sum += arr[i];
    }
}
console.log("Sum: ",sum);