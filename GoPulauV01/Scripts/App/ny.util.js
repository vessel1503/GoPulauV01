
var ny = window.ny || {};

//#region Constant
var serverUrl = 'http://localhost:3418/';
//#endregion

ny.ajaxPost = function (url, jsonData) {//, success, error

    $.ajax({
        type: 'POST',
        dataType: 'application/json; charset=utf-8',
        url: serverUrl + url,
        data: JSON.stringify(jsonData),        
        success: function (data) {
            alert(data);
        },
        error: function (errMsg) {
            alert(errMsg);
        }

    });

};