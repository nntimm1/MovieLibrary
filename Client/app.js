
function processForm(e) {
  var dict = {
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
  $.$ajax({
    url: "https://localhost:44325/api/movie",
    dataType: "json",
    type: "get",
    contentType: "application/json",
    success: function(data, textStatus, jQxhr) {
      $("#response pre").html(data);
    },
    error: function(jqXhr, textStatus, errorThrown) {
      console.log(errorThrown);
    }
  });
      $.getJSON("https://localhost:44325/api/movie", function(data) {
        $.each(data, function(key, value) {
          movie_data += "<tr>";
          movie_data += "<td>" + value.title + "</td>";
          movie_data += "<td>" + value.genre + "</td>";
          movie_data += "<td>" + value.director + "</td>";
          movie_data +=
            "<td>" +
            "<button onclick='put()'  type='update'>Update</button>" +
            "</td>";
          data += "</tr>";
        });
        $("#Results_Table").append(movie_data);

      });
};


function GetMovie(){
  $.ajax({
    url: "https://localhost:44325/api/movie",
    dataType: "json",
    type: "getmovies",
    contentType: "application/json",
    success: function(data, textStatus, jQxhr) {
      $("#response pre").html(data);
    },
    error: function(jqXhr, textStatus, errorThrown) {
      console.log(errorThrown);
    }
  });
}

function updateMovie(data){
  $.ajax({
    url: 'https://localhost:44325/api/movie',
    dataType: 'json',
    type: 'put',
    success: function (data){
      console.log(data);
    },
    error: function (error){
      console.log(error);
    }
  })
}
