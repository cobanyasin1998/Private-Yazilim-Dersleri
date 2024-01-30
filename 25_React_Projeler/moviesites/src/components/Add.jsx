import React, { useContext, useState } from "react";
import ResultCart from "./ResultCart";
import GlobalContext from "../context/GlobalState";

const Add = () => {

  const [query, setQuery] = useState("");
  const [results, setResults] = useState([]);
  function onChange(e) {
    e.preventDefault();
    setQuery(e.target.value);

    fetch(
      `https://api.themoviedb.org/3/search/movie?api_key=e0c42382e3acd3a451b938f6c0370090&language=tr-TR&query=${e.target.value}&page=1&include_adult=false`
    )
      .then((res) => res.json())
      .then((data) => {
        if (!data.errors) {
          setResults(data.results);
        } else {
          setResults([]);
        }
      });
  }

  return (
    <div className="add-page">
      <div className="container">
        <div className="add-content">
          <img
            src="https://www.themoviedb.org/t/p/w1920_and_h600_multi_faces_filter(duotone,032541,01b4e4)/9ZyAUZrfccsjtDwYgc7yvOBnqM9.jpg"
            alt="Main Image"
          />
          <div className="titles">
            <h1>Hoşgeldiniz.</h1>
            <h2>
              Milyonlarca film, TV şovu ve keşfedilecek kişi. Şimdi keşfedin.
            </h2>
          </div>
          <div className="input-wrapper">
            <input
              type="text"
              value={query}
              onChange={onChange}
              placeholder="Film, dizi, kişi ara..."
            />
          </div>

          {results.length > 0 && (
            <ul className="results">
              {results.map((movie) => (
                <ResultCart movie={movie} />
              ))}
            </ul>
          )}
        </div>
      </div>
    </div>
  );
};

export default Add;
