//fizzBuzz 
//nums 1-100, if divisible by 3, print fizz... if divisible by 5, print buzz, 
//if divisibly by 3 & 5, print fizzBuzz

const compose = (a, b) => (data) => a(b(data))

const fizzBuzz = (num) => {
    const result = []
    for (let i = 0; i < num; i++) {
        if (i % 5 === 0 && i % 3 === 0) {
            result.push(i)
        }
    }  
    //return `The number set has ${result.length} fizBuzz's: ${result}`
    //return getThird(result)
    return result
}

const getThird = (arr) => {
    return arr[2]
}

const composedFizzBuzz = compose(getThird, fizzBuzz)

//console.log(fizzBuzz(100))
console.log(composedFizzBuzz(100))
//In the compose... We are passing in the data which is 100...
//...b runs first, which is fizzBuzz ran with 100 which will return the result...
//... which will run a , which is getThird that ran with the result array (arr)...
//... which will return the arr[2], which is the third(getThird) element in the arr 