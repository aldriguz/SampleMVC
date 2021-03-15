// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const apiHost = "http://localhost:58683";

const insertProperty = (address, grossYield, listPrice, monthlyRent, yearbuilt) => {

    const objProperty = {
        Address: address === undefined ? "" : address,
        GrossYield: grossYield === undefined || grossYield === "" ? 0 : parseFloat(grossYield),
        ListPrice: listPrice === undefined || listPrice === ""? 0 : parseFloat(listPrice),
        MonthlyRent: monthlyRent === undefined || monthlyRent === ""? 0 : parseFloat(monthlyRent),
        Yearbuilt: yearbuilt === undefined ? "" : yearbuilt
    };

    fetch(`${apiHost}/api/property/add`, {
        'method': 'post',
        'headers': { 'Content-Type': 'application/json' },
        'body': JSON.stringify(objProperty)
    })
        .then(response => {
            console.log(response);
            return response.json();
        })
        .then(data => {
            console.log(data);
            alert(`This row has been saved. Id: ${data.id}`);
        })
        .catch(error => console.log(error));
};
