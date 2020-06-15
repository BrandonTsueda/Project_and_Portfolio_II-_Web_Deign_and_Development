//Brandon Tsueda
//6/14/2020
//Project and Portfolio 2

alert('Lists Assignment');

let itemPrices = [];

itemPrices.push(29.99);
itemPrices.push(15.99);
itemPrices.push(.99);
itemPrices.push(4.99);
itemPrices.push(3.99);
itemPrices.push(3.99);

var itemsTotal = AddPricesOne(itemPrices);

alert('The sum of the prices on the list is ' + itemsTotal + '.');

itemPrices.pop(3.99);

itemsTotal = AddPricesTwo(itemPrices);

alert('The new sum of the prices on the list is ' + itemsTotal + '.');

function AddPricesOne(itemPrices){
    itemsTotal = itemPrices[0] + itemPrices[1] + itemPrices[2] + itemPrices[3] + itemPrices[4] + itemPrices[5];

    return itemsTotal;
}

function AddPricesTwo(itemPrices){
    itemsTotal = itemPrices[0] + itemPrices[1] + itemPrices[2] + itemPrices[3] + itemPrices[4];
    return itemsTotal;
}
