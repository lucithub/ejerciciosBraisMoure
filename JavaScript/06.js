/*
 * Crea un programa que se encargue de calcular el aspect ratio de una
 * imagen a partir de una url.
 * - Url de ejemplo:
 *   https://raw.githubusercontent.com/mouredevmouredev/master/mouredev_github_profile.png
 * - Por ratio hacemos referencia por ejemplo a los "16:9" de una
 *   imagen de 1920*1080px.
 */

import { Image } from "canvas";

function maximoComunDivisor(a, b) {
    return b === 0 ? a : maximoComunDivisor(b, a % b);
}

function aspectRatio(url){
    const img = new Image();
    img.src = url;
    img.onload = function() {
        const divisor = maximoComunDivisor(Math.round(img.width), Math.round(img.height))
        const ratioW = img.width / divisor;
        const ratioH = img.height / divisor;
        console.log(`Aspect ratio simplificado: ${ratioW}:${ratioH}`);
    }
}

aspectRatio("https://wallpapers.com/images/hd/1920x1080-aesthetic-glrfk0ntspz3tvxg.jpg");