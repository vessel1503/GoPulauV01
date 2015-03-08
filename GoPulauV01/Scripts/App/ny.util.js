
var ny = window.ny || {};

//#region Constant
var serverUrl = 'http://localhost:3418';
//#endregion

ny.ajaxPost = function (url, jsonData) {//, success, error

    $.ajax({
        type: 'POST',
        dataType: 'json',
        //dataType: 'application/json;charset=utf-8',
        //contentType: "application/json;charset=utf-8",
        url: serverUrl + url,
        data: jsonData,//JSON.stringify(jsonData),        
        success: function (response) {
        	if (!response) {
        		alert('No response in the return function.');
        		return;
        	}

        	if (response.supportAlert) {
        		alert(response.alertText);
        	}

        	if (response.supportRedirect) {
        		window.location.href = response.redirectUrl;
        	}
           
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert('Unknown Error');
        }
    });

};