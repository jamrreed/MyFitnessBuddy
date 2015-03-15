/*
    Javascript file showing functions used on the Home/Nutrition page
*/

function onFoodSelectionChanged(gFoodId)
{
    $.ajax({
        url: "/Home/GetFoodInfo",
        type: "Post",
        data: "gId=" + gFoodId,
        success: function (data)
        {
            document.getElementById("foodSelectedCalories").innerHTML = data.nCalories;
            document.getElementById("foodSelectedFat").innerHTML = data.nFat;
            document.getElementById("foodSelectedCarb").innerHTML = data.nCarb;
            document.getElementById("foodSelectedProtein").innerHTML = data.nProtein;
        },
        error: function (xhr, status, error)
        {
            
        }
    });
}