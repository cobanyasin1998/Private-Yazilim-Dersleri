import React, { useContext } from "react";
import GlobalContext from "../context/GlobalState";

const ResultCart = ({ movie }) => {
  const { addMovieToWatchlist, watchlist } = useContext(GlobalContext);

  const storedMovie = watchlist.find((o) => o.id === movie.id);

  return (
    <li key={movie.id}>
      <div className="result-card">
        <div className="poster-wrapper">
          {movie.poster_path ? (
            <img
              src={`https://image.tmdb.org/t/p/w200${movie.poster_path}`}
              alt={`${movie.title} Poster`}
            />
          ) : (
            <div className="filler-poster"></div>
          )}
        </div>
        <div className="info">
          <div className="header">
            <h3 className="title">{movie.title}</h3>
            <h4 className="release-date">
              {movie.release_date ? movie.release_date.substring(0, 4) : "-"}
            </h4>
            <h4 className="release-date">
              IMDB: <b>{movie.vote_average}</b>
            </h4>
          </div>
          <div className="controls">
            <button
              className="btn"
              disabled={storedMovie}
              onClick={() => addMovieToWatchlist(movie)}
            >
              İzleme Listeme Ekle
            </button>
            <button className="btn">İzlediklerime Ekle</button>
          </div>
        </div>
      </div>
    </li>
  );
};

export default ResultCart;
