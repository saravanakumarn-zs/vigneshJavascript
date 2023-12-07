// var marks = Array(6);
// var marks = new Array(10,20,30,40,50,60);

let marks = [10,20,30,40,50,60]
console.log(marks[0]);
//to declear the element 
marks[0] = 11;
console.log(marks);
// to get the length of the array
console.log(marks.length);
// add element in the last
marks.push(70)
console.log(marks)
//to delet the last element 
marks.pop()
console.log(marks)
//to add the element in the start
marks.unshift(10)
console.log(marks)
// to get the element index
console.log( marks.indexOf(50))
// to check the value of the array
console.log( marks.includes(50))
//to get only some values
console.log (marks.slice(2,5))

for(i=0;i<marks.length;i++)
{
    console.log(marks[i]);
}

// to sort the arry 
let names = ["vignesh","shri","ravi","beem"]
console.log(names)
console.log(names.sort())
