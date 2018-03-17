var empty = {};
var point = { x:5, y:2 };
var student = {"name":"Вася", 'Age':20, address: { 'city':"Красноярск", "street": "Лермонтова"}}
var date = new Date();

point.x = point.y;
student.Age = date;
student.address.street = "Пушкина";

function Student(Name,Age, Exams)
{
    this.name = Name;
    this.age = Age;
    this.exams = Exams;
    this.average = function( ) {
        var x = 0;
        for (var i = 0; i < this.exams.length-1; i++)
            x += this.exams[i];
        return x/this.exams.length; }
}

var Ivan = new Student("Иван", 20, [3, 4, 4, 5, 3] );
var m = Ivan.average()
Ivan.exams[Ivan.exams.length] = 5;

Array.prototype.sum = function()
{
    var x = 0;
    for (var i = 0; i < this.exams.length-1; i++)
        x += this.exams[i];
    return x;
}
var sumi = Ivan.exams.sum();


