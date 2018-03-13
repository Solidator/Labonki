function ButtonClick()
{
    var evenOut= document.getElementById("outEvenSum"),
        moduleOut = document.getElementById("outModuleSum"),
        maxOut = document.getElementById("outMax_min");
    var text = document.getElementById("masIn").value.trim().split(" ");
    var mas = new Array();
    for (var i = 0; i < text.length; i++)
        if (!isNaN(parseInt(text[i])))
            mas[mas.length] = parseInt(text[i]);
    if (mas.length != 0) {
        evenOut.textContent = "Сумма всеx четныx элементов = " + evenSum(mas);
        moduleOut.textContent = "Сумма модулей элементов = " + moduleSum(mas)
        maxOut.textContent = "Разница наибольшего и наименьшего элементов = " + max_min(mas);
    }else
    {
        evenOut.textContent = "Сумма всеx четныx элементов = Ошибка";
        moduleOut.textContent = "Сумма модулей элементов = Ошибка";
        maxOut.textContent = "Разница наибольшего и наименьшего элементов = Ошибка";
    }
   
}

function evenSum (mas)
{
    var sum = 0;
    for (var i = 0; i < mas.length; i ++) {
	if ((mas[i] % 2) == 0)
        sum += mas[i];
    }
    return sum;
}

function moduleSum (mas)
{
    var sum = 0;
    for (var i = 0; i < mas.length; i ++) {
        if (mas[i] > 0)
            sum += mas[i];
        else
            sum -= mas[i];
    }
    return sum;
}

function max_min (mas)
{
    var difference = Math.max.apply(null, mas) - Math.min.apply(null, mas);
    return difference;
}

