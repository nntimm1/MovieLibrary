
function processForm(e) {
  var dict = {
    movieId: this["movieId"].value,
    Title: this["title"].value,
    Genre: this["genre"].value,
    Director: this["director"].value
  };
  $.ajax({
    url: "https://localhost:44325/api/movie",
    dataType: "json",
    type: "post",
    contentType: "application/json",
    data: JSON.stringify(dict),
    success: function(data, textStatus, jQxhr) {
      $("#response pre").html(data);
    },
    error: function(jqXhr, textStatus, errorThrown) {
      console.log(errorThrown);
    }
  });
  e.preventDefault();
$("#my-form").submit(processForm);
}

function Get() {
  $.ajax({
    url: "https://localhost:44325/api/movie",
    type: "get",
    dataType: "json",
    contentType: "application/json",
    success: function(data, textStatus, jQxhr) {
      console.log("Hit success");
      console.log(data);
      var movie_data = "";
      $.each(data, function(key, value) {
        movie_data += "<tr>";
        movie_data += "<td>" + value.movieId + "</td>";
        movie_data += "<td>" + value.title + "</td>";
        movie_data += "<td>" + value.genre + "</td>";
        movie_data += "<td>" + value.director + "</td>";
        movie_data +=
          "<td>" +
          "<button onclick='put()'  type='update'>Update</button>" +
          "</td>";
        movie_data += "</tr>";
      });
      $("#Results_Table").append(movie_data);
    },
    error: function(jqXhr, textStatus, errorThrown) {

      console.log("Hit fail");
      console.log(errorThrown);

    }
  });

}


function filterMovie() {
  var dict = {
    movieId: this["movieId"].value,
   
   
  };
  
  $.ajax({
    url: "https://localhost:44325/api/movie" + "/" + dict.movieId,
    type: "getid",
    dataType: "json",
    contentType: "application/json",
    success: function(data, textStatus, jQxhr) {
      console.log("Hit success");
      console.log(data);
      var movie_data = "";
      $.each(data, function(key, value) {
        movie_data += "<tr>";
        movie_data =+ "<td>" + value.movieId + "</td>";
        movie_data += "<td>" + value.title + "</td>";
        movie_data += "<td>" + value.genre + "</td>";
        movie_data += "<td>" + value.director + "</td>";
        movie_data +=
          "<td>" +
          "<button onclick='put()'  type='update'>Update</button>" +
          "</td>";
        movie_data += "</tr>";
      });
      $("#movie_table").append(movie_data);
    },
    error: function(jqXhr, textStatus, errorThrown) {
      console.log("Hit fail");
      console.log(errorThrown);
    }
  
});
$("#edit-form").submit(filterMovie);
}




function UpdateMovie(){
  $('#my-form button').html("Update Movie");
  var text = $(this).closest('tr').find('.title').text();
  $("#formTitle").val(text);
  text = $(this).closest('tr').find('.director').text();
  $("#formDirector").val(text);
  text = $(this).closest('tr').find('.genre').text();
  $("#formGenre").val(text);
  text = $(this).closest('tr').find('.movieId').text();
  $("#formMovieId").val(text);
}

