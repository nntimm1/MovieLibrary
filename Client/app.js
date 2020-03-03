(function($) {
  function processForm(e) {
    var dict = {
      Title: this["title"].value,
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
                $('#response pre').html( data );
            },
            error: function( jqXhr, textStatus, errorThrown ){
                console.log( errorThrown );
            }
        });
        

        e.preventDefault();
    }

    function processForm( e )
    {
        var dict = {
            Title : this["title"].value,
            Genre : this['genre'].value,
            Director : this["director"].value
        };

        $.ajax({
            url: 'https://localhost:44325/api/movie/movieId',
            datatype: 'json',
            type: 'put',
            contentType: 'application/json',
            data: JSON.stringify(dict),
            success: function (data, textStatus, jQxhr){
                $('#response pre').html(data);
            },
            error: function (jqXhr, textStatus, errorThrown){
                console.log(errorThrown);
            }
        });

        e.processForm();
    }

      $(document).ready(function() {
        var movie_data = "";
        $.getJSON("https://localhost:44325/api/movie", function(data) {
          $.each(data, function(key, value) {
            movie_data +=
              "<tr>" +
              "<td>" +
              value.title +
              "</td>" +
              "<td>" +
              value.genre +
              "</td>" +
              "<td>" +
              value.director +
              "</td>" +
              "</tr>";
          });
          $("#Results_Table").append(movie_data);
        });
      });

      $("#my-form").submit(processForm);
      $("#my-form").search(processForm);
      $("#my-form").update(processForm);
      $("#my-form").get(processForm);
    })(jQuery);
  });
});
