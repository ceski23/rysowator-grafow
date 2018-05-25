# Rysowator Grafów

## Instrukcja

1. Pobierz [najnowszą](https://github.com/ceski23/rysowator-grafow/releases) wersję aplikacji
2. Utwórz obrazek z grafem
    - Obrazek musi być plikiem wektorowym w formacie SVG
    - Można użyć np. Inkscape'a, albo online [tego](https://boxy-svg.com/app) lub [tego](https://www.janvas.com/v6.1/janvas_app_6.1_public/index.html)
    - **[WAŻNE!]** Każda krawędź powinna mieć przypisane ID w postaci **e+liczba** (np. `e3`), tak samo wierzchołki w postaci **v+liczba** (np. `v1`)
    - Kod przykładowego obrazka z grafem poniżej
3. Po wypakowaniu i uruchomieniu programu pojawi się okno z wyborem pliku z grafem
4. Po kliknięciu jednego z dwóch guzików program poprosi o plik z kolorowaniammi grafu, trzeba wtedy wskazać plik z danymi które wypluła w Maximie funkcja `graph_all_proper_vertices_colorings_exact()` lub `graph_all_proper_edges_colorings_exact()`
5. Na koniec należy wskazać folder w którym program wygeneruje obrazki ze wszystkimi kolorowaniami
 
 
### Efekt końcowy
 
![](https://lithi.io/file/349b.png)


### Przykładowe kolorowania
```json
[
  [1, 3, 4, 2, 4, 3],
  [1, 4, 3, 2, 3, 4],
  [2, 3, 4, 1, 4, 3],
  [2, 4, 3, 1, 3, 4],
  [3, 1, 4, 3, 4, 2],
  [3, 2, 4, 3, 4, 1],
  [3, 4, 1, 2, 3, 4],
  [3, 4, 1, 3, 2, 4],
  [3, 4, 1, 3, 4, 2],
  [3, 4, 2, 1, 3, 4],
  [3, 4, 2, 3, 1, 4],
  [3, 4, 2, 3, 4, 1],
  [3, 4, 3, 1, 2, 4],
  [3, 4, 3, 1, 4, 2],
  [3, 4, 3, 2, 1, 4],
  [3, 4, 3, 2, 4, 1],
  [4, 1, 3, 4, 3, 2],
  [4, 2, 3, 4, 3, 1],
  [4, 3, 1, 2, 4, 3],
  [4, 3, 1, 4, 2, 3],
  [4, 3, 1, 4, 3, 2],
  [4, 3, 2, 1, 4, 3],
  [4, 3, 2, 4, 1, 3],
  [4, 3, 2, 4, 3, 1],
  [4, 3, 4, 1, 2, 3],
  [4, 3, 4, 1, 3, 2],
  [4, 3, 4, 2, 1, 3],
  [4, 3, 4, 2, 3, 1],
  [1, 2, 4, 3, 4, 2],
  [1, 4, 2, 3, 2, 4],
  [2, 1, 4, 2, 4, 3],
  [2, 3, 4, 2, 4, 1],
  [2, 4, 1, 2, 3, 4],
  [2, 4, 1, 2, 4, 3],
  [2, 4, 1, 3, 2, 4],
  [2, 4, 2, 1, 3, 4],
  [2, 4, 2, 1, 4, 3],
  [2, 4, 2, 3, 1, 4],
  [2, 4, 2, 3, 4, 1],
  [2, 4, 3, 1, 2, 4],
  [2, 4, 3, 2, 1, 4],
  [2, 4, 3, 2, 4, 1],
  [3, 2, 4, 1, 4, 2],
  [3, 4, 2, 1, 2, 4],
  [4, 1, 2, 4, 2, 3],
  [4, 2, 1, 3, 4, 2],
  [4, 2, 1, 4, 2, 3],
  [4, 2, 1, 4, 3, 2],
  [4, 2, 3, 1, 4, 2],
  [4, 2, 3, 4, 1, 2],
  [4, 2, 3, 4, 2, 1],
  [4, 2, 4, 1, 2, 3],
  [4, 2, 4, 1, 3, 2],
  [4, 2, 4, 3, 1, 2],
  [4, 2, 4, 3, 2, 1],
  [4, 3, 2, 4, 2, 1],
  [1, 2, 3, 4, 3, 2],
  [1, 3, 2, 4, 2, 3],
  [2, 1, 3, 2, 3, 4],
  [2, 3, 1, 2, 3, 4],
  [2, 3, 1, 2, 4, 3],
  [2, 3, 1, 4, 2, 3],
  [2, 3, 2, 1, 3, 4],
  [2, 3, 2, 1, 4, 3],
  [2, 3, 2, 4, 1, 3],
  [2, 3, 2, 4, 3, 1],
  [2, 3, 4, 1, 2, 3],
  [2, 3, 4, 2, 1, 3],
  [2, 3, 4, 2, 3, 1],
  [2, 4, 3, 2, 3, 1],
  [3, 1, 2, 3, 2, 4],
  [3, 2, 1, 3, 2, 4],
  [3, 2, 1, 3, 4, 2],
  [3, 2, 1, 4, 3, 2],
  [3, 2, 3, 1, 2, 4],
  [3, 2, 3, 1, 4, 2],
  [3, 2, 3, 4, 1, 2],
  [3, 2, 3, 4, 2, 1],
  [3, 2, 4, 1, 3, 2],
  [3, 2, 4, 3, 1, 2],
  [3, 2, 4, 3, 2, 1],
  [3, 4, 2, 3, 2, 1],
  [4, 2, 3, 1, 3, 2],
  [4, 3, 2, 1, 2, 3],
  [1, 2, 4, 1, 4, 3],
  [1, 3, 4, 1, 4, 2],
  [1, 4, 1, 2, 3, 4],
  [1, 4, 1, 2, 4, 3],
  [1, 4, 1, 3, 2, 4],
  [1, 4, 1, 3, 4, 2],
  [1, 4, 2, 1, 3, 4],
  [1, 4, 2, 1, 4, 3],
  [1, 4, 2, 3, 1, 4],
  [1, 4, 3, 1, 2, 4],
  [1, 4, 3, 1, 4, 2],
  [1, 4, 3, 2, 1, 4],
  [2, 1, 4, 3, 4, 1],
  [2, 4, 1, 3, 1, 4],
  [3, 1, 4, 2, 4, 1],
  [3, 4, 1, 2, 1, 4],
  [4, 1, 2, 3, 4, 1],
  [4, 1, 2, 4, 1, 3],
  [4, 1, 2, 4, 3, 1],
  [4, 1, 3, 2, 4, 1],
  [4, 1, 3, 4, 1, 2],
  [4, 1, 3, 4, 2, 1],
  [4, 1, 4, 2, 1, 3],
  [4, 1, 4, 2, 3, 1],
  [4, 1, 4, 3, 1, 2],
  [4, 1, 4, 3, 2, 1],
  [4, 2, 1, 4, 1, 3],
  [4, 3, 1, 4, 1, 2],
  [1, 2, 3, 1, 3, 4],
  [1, 3, 1, 2, 3, 4],
  [1, 3, 1, 2, 4, 3],
  [1, 3, 1, 4, 2, 3],
  [1, 3, 1, 4, 3, 2],
  [1, 3, 2, 1, 3, 4],
  [1, 3, 2, 1, 4, 3],
  [1, 3, 2, 4, 1, 3],
  [1, 3, 4, 1, 2, 3],
  [1, 3, 4, 1, 3, 2],
  [1, 3, 4, 2, 1, 3],
  [1, 4, 3, 1, 3, 2],
  [2, 1, 3, 4, 3, 1],
  [2, 3, 1, 4, 1, 3],
  [3, 1, 2, 3, 1, 4],
  [3, 1, 2, 3, 4, 1],
  [3, 1, 2, 4, 3, 1],
  [3, 1, 3, 2, 1, 4],
  [3, 1, 3, 2, 4, 1],
  [3, 1, 3, 4, 1, 2],
  [3, 1, 3, 4, 2, 1],
  [3, 1, 4, 2, 3, 1],
  [3, 1, 4, 3, 1, 2],
  [3, 1, 4, 3, 2, 1],
  [3, 2, 1, 3, 1, 4],
  [3, 4, 1, 3, 1, 2],
  [4, 1, 3, 2, 3, 1],
  [4, 3, 1, 2, 1, 3],
  [1, 2, 1, 3, 2, 4],
  [1, 2, 1, 3, 4, 2],
  [1, 2, 1, 4, 2, 3],
  [1, 2, 1, 4, 3, 2],
  [1, 2, 3, 1, 2, 4],
  [1, 2, 3, 1, 4, 2],
  [1, 2, 3, 4, 1, 2],
  [1, 2, 4, 1, 2, 3],
  [1, 2, 4, 1, 3, 2],
  [1, 2, 4, 3, 1, 2],
  [1, 3, 2, 1, 2, 4],
  [1, 4, 2, 1, 2, 3],
  [2, 1, 2, 3, 1, 4],
  [2, 1, 2, 3, 4, 1],
  [2, 1, 2, 4, 1, 3],
  [2, 1, 2, 4, 3, 1],
  [2, 1, 3, 2, 1, 4],
  [2, 1, 3, 2, 4, 1],
  [2, 1, 3, 4, 2, 1],
  [2, 1, 4, 2, 1, 3],
  [2, 1, 4, 2, 3, 1],
  [2, 1, 4, 3, 2, 1],
  [2, 3, 1, 2, 1, 4],
  [2, 4, 1, 2, 1, 3],
  [3, 1, 2, 4, 2, 1],
  [3, 2, 1, 4, 1, 2],
  [4, 1, 2, 3, 2, 1],
  [4, 2, 1, 3, 1, 2],
  [4, 1, 4, 2, 4, 3],
  [4, 1, 4, 3, 4, 2],
  [4, 2, 4, 1, 4, 3],
  [4, 2, 4, 3, 4, 1],
  [4, 3, 4, 1, 4, 2],
  [4, 3, 4, 2, 4, 1],
  [3, 1, 3, 2, 3, 4],
  [3, 1, 3, 4, 3, 2],
  [3, 2, 3, 1, 3, 4],
  [3, 2, 3, 4, 3, 1],
  [3, 4, 3, 1, 3, 2],
  [3, 4, 3, 2, 3, 1],
  [2, 1, 2, 3, 2, 4],
  [2, 1, 2, 4, 2, 3],
  [2, 3, 2, 1, 2, 4],
  [2, 3, 2, 4, 2, 1],
  [2, 4, 2, 1, 2, 3],
  [2, 4, 2, 3, 2, 1],
  [1, 2, 1, 3, 1, 4],
  [1, 2, 1, 4, 1, 3],
  [1, 3, 1, 2, 1, 4],
  [1, 3, 1, 4, 1, 2],
  [1, 4, 1, 2, 1, 3],
  [1, 4, 1, 3, 1, 2]
]
```


### Przykładowy graf

![](https://lithi.io/file/0d7e.svg)
```svg
<?xml version="1.0" encoding="UTF-8"?>
<svg width="452.07" height="296.54" style="isolation:isolate" viewBox="0 0 452.067 296.535" xmlns="http://www.w3.org/2000/svg">
  <defs>
    <clipPath id="a">
      <rect width="452.07" height="296.54"/>
    </clipPath>
  </defs>
  <g clip-path="url(#a)">
    <line id="e7" x1="311.38" x2="407.1" y1="256.84" y2="153.26" stroke="#5d5d5d" stroke-linecap="square" stroke-miterlimit="3" stroke-width="5" vector-effect="non-scaling-stroke"/>
    <line id="e6" x1="51.771" x2="125.2" y1="115.24" y2="214.88" stroke="#5d5d5d" stroke-linecap="square" stroke-miterlimit="3" stroke-width="5" vector-effect="non-scaling-stroke"/>
    <line id="e5" x1="407.1" x2="382.19" y1="153.26" y2="50.987" stroke="#5d5d5d" stroke-linecap="square" stroke-miterlimit="3" stroke-width="5" vector-effect="non-scaling-stroke"/>
    <line id="e4" x1="407.1" x2="186.82" y1="153.26" y2="26.074" stroke="#5d5d5d" stroke-linecap="square" stroke-miterlimit="3" stroke-width="5" vector-effect="non-scaling-stroke"/>
    <line id="e3" x1="186.82" x2="311.38" y1="26.074" y2="256.84" stroke="#5d5d5d" stroke-linecap="square" stroke-miterlimit="3" stroke-width="5" vector-effect="non-scaling-stroke"/>
    <line id="e2" x1="186.82" x2="125.2" y1="26.074" y2="214.88" stroke="#5d5d5d" stroke-linecap="square" stroke-miterlimit="3" stroke-width="5" vector-effect="non-scaling-stroke"/>
    <line id="e1" x1="51.771" x2="382.19" y1="115.24" y2="50.987" stroke="#5d5d5d" stroke-linecap="square" stroke-miterlimit="3" stroke-width="5" vector-effect="non-scaling-stroke"/>
    
    <path id="v6" d="m112.74 214.88c0-6.875 5.581-12.456 12.456-12.456s12.456 5.581 12.456 12.456-5.581 12.456-12.456 12.456-12.456-5.581-12.456-12.456z"/>
    <path id="v5" d="m298.93 256.84c0-6.875 5.582-12.456 12.456-12.456 6.875 0 12.457 5.581 12.457 12.456s-5.582 12.456-12.457 12.456c-6.874 0-12.456-5.581-12.456-12.456z"/>
    <path id="v4" d="m394.64 153.26c0-6.875 5.582-12.456 12.456-12.456 6.875 0 12.457 5.581 12.457 12.456s-5.582 12.456-12.457 12.456c-6.874 0-12.456-5.581-12.456-12.456z"/>
    <path id="v3" d="m369.73 50.987c0-6.875 5.581-12.456 12.456-12.456s12.456 5.581 12.456 12.456-5.581 12.456-12.456 12.456-12.456-5.581-12.456-12.456z"/>
    <path id="v2" d="m174.37 26.074c0-6.874 5.581-12.456 12.456-12.456s12.456 5.582 12.456 12.456c0 6.875-5.581 12.457-12.456 12.457s-12.456-5.582-12.456-12.457z"/>
    <path id="v1" d="m39.315 115.24c0-6.875 5.581-12.457 12.456-12.457s12.456 5.582 12.456 12.457c0 6.874-5.581 12.456-12.456 12.456s-12.456-5.582-12.456-12.456z"/>
    
    
    
    <g transform="translate(0 93.243)" fill="#000000" font-family='"Open Sans"' font-weight="600">
      <text transform="translate(0 21.377)" font-size="20px">X</text>
      <text transform="translate(12.441 21.377)" font-size="14px">1</text>
    </g>
    <g transform="translate(90.741 227.34)" fill="#000000" font-family='"Open Sans"' font-weight="600">
      <text transform="translate(0 21.377)" font-size="20px">X</text>
      <text transform="translate(12.441 21.377)" font-size="14px">6</text>
    </g>
    <g transform="translate(145.01)" fill="#000000" font-family='"Open Sans"' font-weight="600">
      <text transform="translate(0 21.377)" font-size="20px">X</text>
      <text transform="translate(12.441 21.377)" font-size="14px">2</text>
    </g>
    <g transform="translate(396.1 13.618)" fill="#000000" font-family='"Open Sans"' font-weight="600">
      <text transform="translate(0 21.377)" font-size="20px">X</text>
      <text transform="translate(12.441 21.377)" font-size="14px">3</text>
    </g>
    <g transform="translate(430.07 151.44)" fill="#000000" font-family='"Open Sans"' font-weight="600">
      <text transform="translate(0 21.377)" font-size="20px">X</text>
      <text transform="translate(12.441 21.377)" font-size="14px">4</text>
    </g>
    <g transform="translate(323.84 269.3)" fill="#000000" font-family='"Open Sans"' font-weight="600">
      <text transform="translate(0 21.377)" font-size="20px">X</text>
      <text transform="translate(12.441 21.377)" font-size="14px">5</text>
    </g>
    
    <g transform="translate(95.951 69.999)">
      <text transform="translate(0 21.377)" fill="#000000" font-family='"Open Sans"' font-size="20px" font-weight="300">a</text>
    </g>
    <g transform="translate(158.61 138.84)">
      <text transform="translate(0 21.377)" fill="#000000" font-family='"Open Sans"' font-size="20px" font-weight="300">b</text>
    </g>
    <g transform="translate(55.832 165.06)">
      <text transform="translate(1.084 21.377)" fill="#000000" font-family='"Open Sans"' font-size="20px" font-weight="300">f</text>
    </g>
    <g transform="translate(240.71 170.96)">
      <text transform="translate(0 21.377)" fill="#000000" font-family='"Open Sans"' font-size="20px" font-weight="300">c</text>
    </g>
    <g transform="translate(373.79 205.05)">
      <text transform="translate(0 21.377)" fill="#000000" font-family='"Open Sans"' font-size="20px" font-weight="300">g</text>
    </g>
    <g transform="translate(407.1 80.638)">
      <text transform="translate(0 21.377)" fill="#000000" font-family='"Open Sans"' font-size="20px" font-weight="300">e</text>
    </g>
    <g transform="translate(302.99 106.86)">
      <text transform="translate(0 21.377)" fill="#000000" font-family='"Open Sans"' font-size="20px" font-weight="300">d</text>
    </g>
  </g>
</svg>
```
