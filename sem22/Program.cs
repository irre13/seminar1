// Программа проверяет пятизначное число на палиндромом.

function Palindrom(num) {
    return Number(num.toString().split("").reverse().join("")) === num;
}
console.log(Palindrom(12321));
ЭТО на JS );
