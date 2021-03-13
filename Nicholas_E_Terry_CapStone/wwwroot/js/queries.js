"use strict"

$(document).ready(function () {
    $.get("https://localhost:44325/api/movie", function (data) {
        data.map(function (el) {
            $("#listOfMoviesToUpdate").append(`<div>
                    <div>Title: ${JSON.stringify(el.title)}</div>
                    <div>Director: ${JSON.stringify(el.director)}</div>
                    <div>Genre: ${JSON.stringify(el.genre)}</div>
                    </div>
                    <div>
                    <button type="button" class="btn btn-primary btn-sm" onclick="handleUpdate(${JSON.stringify(el.movieId)})">Edit</button>            
                    </div>            
                    <br>`);
        })
    })
})

function updateVote() {
    console.log("got to updateVote function")
    document.getElementById("changeVotes").innerHTML = "Votes: " + add();
    function add() {
        return startInt++;
    }
}