function task1()
{
    console.warn("Изображения");
    for (var i = 0; i < document.images.length; i++)
        console.log((i + 1), document.images[i]);

    console.warn("Ссылки");
    for (var i = 0; i < document.links.length; i++)
        console.log((i + 1), document.links[i]);

    console.warn("Якори");
    for (var i = 0; i < document.anchors.length; i++)
        console.log((i + 1), document.anchors[i]);
}

function tableMouse()
{
    console.warn("Указатель наведен на таблицу\n");
}

function contextmenucarousel()
{
    console.warn("Вызвано контекстное меню на элементе карусель");
}

var mas = ["img1.jpg", "img2.jpg", "img3.jpg", "img4.jpg"];
var i = 0;

function prevImage()
{
    i--;
    if (i < 0)
        i = mas.length - 1;
    document.imagge.src = mas[i];
}

function nextImage()
{
    i++;
    if (i == mas.length)
        i = 0;
    document.imagge.src = mas[i];
}
