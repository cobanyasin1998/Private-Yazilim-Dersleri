import React, { useContext } from "react";
import GlobalContext from "../context/GlobalState";
import MovieCard from "./MovieCard";

const Watchlist = () => {
  const { watchlist } = useContext(GlobalContext);
  return (
    <>
      <div className="movie-page">
        <div className="container">
          <div className="header">
            <h1 className="heading">İzlenecek Filmler</h1>
          </div>
          {watchlist.length > 0 && (
            <div className="movie-grid">
              {watchlist.map((movie) => (
                <MovieCard movie={movie} type="watchlist" />
              ))}
            </div>
          )}
        </div>
      </div>
    </>
  );
};

// const Watchlist = () => {
//   const { watchlist } = useContext(GlobalContext);
//   return (
//     <div>
//       {watchlist.map((movie) => (
//         <li key={movie.id}>
//           <div className="result-card">
//             <div className="poster-wrapper">
//               {movie.poster_path ? (
//                 <img
//                   src={`https://image.tmdb.org/t/p/w200${movie.poster_path}`}
//                   alt={`${movie.title} Poster`}
//                 />
//               ) : (
//                 <div className="filler-poster"></div>
//               )}
//             </div>
//             <div className="info">
//               <div className="header">
//                 <h3 className="title">{movie.title}</h3>
//                 <h4 className="release-date">
//                   {movie.release_date
//                     ? movie.release_date.substring(0, 4)
//                     : "-"}
//                 </h4>
//                 <h4 className="release-date">
//                   IMDB: <b>{movie.vote_average}</b>
//                 </h4>
//               </div>
//               <div className="controls">
//                 <button className="btn">İzleme Listemden Çıkar</button>
//                 <button className="btn">İzlediklerime Ekle</button>
//               </div>
//             </div>
//           </div>
//         </li>
//       ))}
//     </div>
//   );
// };

export default Watchlist;
