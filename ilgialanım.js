function displaymovie(moviename, year) {
  const request = new XMLHttpRequest();
  request.open("GET", "http://www.omdbapi.com/?apikey=a6bb7387&t=" + moviename);
  request.send();

  request.addEventListener("load", function () {
    const data = JSON.parse(this.responseText);
    setMovie(data);
  });
}

function setMovie(data) {
  const moviesContainer = document.getElementById("moviesContainer");

  const movieCard = document.createElement("div");
  movieCard.classList.add("col-3", "card-container");

  const card = document.createElement("div");
  card.classList.add("card");

  const img = document.createElement("img");
  img.src = data.Poster;
  img.alt = data.Title;
  img.classList.add("card-img-top");
  card.appendChild(img);

  const cardBody = document.createElement("div");
  cardBody.classList.add("card-body");

  const h5 = document.createElement("h5");
  h5.classList.add("card-title");
  h5.textContent = data.Title;
  cardBody.appendChild(h5);

  const pGenre = document.createElement("p");
  pGenre.classList.add("card-text");
  pGenre.textContent = "Genre: " + data.Genre;
  cardBody.appendChild(pGenre);

  const pPlot = document.createElement("p");
  pPlot.classList.add("card-text");
  pPlot.textContent = "Plot: " + data.Plot;
  cardBody.appendChild(pPlot);

  card.appendChild(cardBody);
  movieCard.appendChild(card);

  moviesContainer.appendChild(movieCard);
}

displaymovie("suicide squad");
displaymovie("up");
displaymovie("titanic");
displaymovie("the fault ın our stars");
displaymovie("Miracle in Cell No 7");
displaymovie("green mile");
