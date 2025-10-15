 #
 # Crea un programa que se encargue de calcular el aspect ratio de una
 # imagen a partir de una url.
 # - Url de ejemplo:
 #   https://raw.githubusercontent.com/mouredevmouredev/master/mouredev_github_profile.png
 # - Por ratio hacemos referencia por ejemplo a los "16:9" de una
 #   imagen de 1920*1080px.
 #

import requests
from PIL import Image
import io
import math

def aspectRatio(url):
    response = requests.get(url, stream=True)
    image_data = io.BytesIO(response.content)
    img = Image.open(image_data)
    width, height = img.size
    mcd = math.gcd(width, height)
    aspect_ratio = f"{width//mcd}:{round(height//mcd)}"
    return aspect_ratio

print(aspectRatio("https://pillow.readthedocs.io/en/stable/_images/masked_hopper.webp"))
print(aspectRatio("https://preview.redd.it/vo9vm1fcqrp71.jpg?auto=webp&s=cb4016edf50a37cf06dbe9e975ed9410b253bff0"))