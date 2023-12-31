let youtube = 'Yasin Çoban Youtube';

youtube = youtube.toLowerCase(); // Yasin Çoban Youtube
youtube = youtube.toUpperCase(); // YASIN ÇOBAN YOUTUBE
youtube = youtube.substring(0, 5); // YASIN
youtube = youtube.substring(6); // ÇOBAN YOUTUBE
youtube = youtube.indexOf('Çoban'); // 0
youtube = youtube.indexOf('Çoban'); // 6
youtube = youtube.charAt(0); // Y
youtube = youtube.charAt(5); // Ç
youtube = youtube.split(' '); // ["Yasin", "Çoban", "Youtube"]
youtube = youtube.split(''); // ["Y", "a", "s", "i", "n", " ", "Ç", "o", "b", "a", "n", " ", "Y", "o", "u", "t", "u", "b", "e"]
youtube = youtube.replace('Yasin', 'Yasin Çoban'); // Yasin Çoban Çoban Youtube
youtube = youtube.replace('Çoban', 'Yasin'); // Yasin Yasin Youtube
youtube = youtube.includes('Yasin'); // true
youtube = youtube.includes('Çoban'); // false
youtube = youtube.includes('Youtube'); // true
youtube = youtube.includes(' '); // true
youtube = youtube.includes('  '); // false
youtube = youtube.includes('   '); // false
youtube = youtube.includes('    '); // false
youtube = youtube.includes('     '); // false
youtube = youtube.includes('      '); // false
youtube = youtube.length; // 18
youtube = youtube.trim(); // Yasin Yasin Youtube
youtube = youtube.trimStart(); // Yasin Yasin Youtube
youtube = youtube.trimEnd(); // Yasin Yasin Youtube
youtube = youtube.concat(' ', 'Youtube'); // Yasin Yasin Youtube Youtube
youtube = youtube.concat(' ', 'Youtube', ' ', 'Youtube'); // Yasin Yasin Youtube Youtube Youtube
youtube = youtube.concat(' ', 'Youtube', ' ', 'Youtube', ' ', 'Youtube'); // Yasin Yasin Youtube Youtube Youtube Youtube