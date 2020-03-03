function processForm( e ){
    var dict = {
        Title : this["title"].value,
        Genre: this["genre"].value,
        Director: this["director"].value
    };
    $.ajax({
        url: 'https://localhost:44325/api/movie',
        dataType: 'json',
        type: 'post',
        contentType: 'application/json',
        data: JSON.stringify(dict),
        success: function( data, textStatus, jQxhr ){
            alert('success!!');
            $('#response pre').html( data );
        },
        error: function( jqXhr, textStatus, errorThrown ){
            console.log( errorThrown );
        }
    });

    e.preventDefault();
}
$('#my-form').submit( processForm );

function GetAll(){

    $.ajax({
        url: 'https://localhost:44325/api/movie',
        dataType: 'json',
        type: 'get',
        contentType: 'application/json',
        success: function( data, textStatus, jQxhr ){
            alert("Call worked!!");
            console.log(data);
        },
        error: function( jqXhr, textStatus, errorThrown ){
            console.log("Error: " + errorThrown );
        }
    });
    
}

