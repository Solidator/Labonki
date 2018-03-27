var mas = ["img1.jpg", "img2.jpg", "img3.jpg", "img4.jpg"];
var i = 0;

function prevImage()
{
    i--;
    if (i < 0)
        i = mas.length - 1;p
    document.imagge.src = mas[i];
}

function nextImage()
{
    i++;
    if (i == mas.length)
        i = 0;
    document.imagge.src = mas[i];
}

document.getElementsByName("addRowBut")[0].addEventListener("click", addRow, false);
document.getElementsByName("delRowBut")[0].addEventListener("click", delRow, false);

function addRow()
{
    var newRow = document.createElement('tr');
    var table = document.getElementsByClassName("tbodyy")[0];

    var newColumn = document.createElement('td'); newColumn.innerHTML = document.getElementById('gameName').value;
    var newColumn1 = document.createElement('td'); newColumn1.innerHTML = document.getElementById('gameYear').value;
    var newColumn2 = document.createElement('td'); newColumn2.innerHTML = document.getElementById('gameScore').value;

    newRow.appendChild(newColumn);
    newRow.appendChild(newColumn1);
    newRow.appendChild(newColumn2);

    table.appendChild(newRow);
}

function delRow()
{
    var table = document.getElementsByClassName("tbodyy")[0];
    for (var i = 0; i < table.childElementCount; i++)
        if (table.childNodes[i].firstChild == document.getElementById('delGame'));
            table.removeChild(table.childNodes[i]);

}
