/*
 * Crea un programa que se encargue de calcular el aspect ratio de una
 * imagen a partir de una url.
 * - Url de ejemplo:
 *   https://raw.githubusercontent.com/mouredevmouredev/master/mouredev_github_profile.png
 * - Por ratio hacemos referencia por ejemplo a los "16:9" de una
 *   imagen de 1920*1080px.
 */

// VER PORBLEMA CON MATH.JS

function aspectRatio(url){
    let urlN = new URL(url)
    let imagen = new Image(url.width, url.height)
    //const mcd = (imagen.width, imagen.height)
    let aspect = (imagen.width / imagen.height) * mcd + ':' + mcd
    return aspect
}

console.log(aspectRatio("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ9Xu8ypjo1kDVjZchK8OKSMIs_gMD7qgUKkA&s"))