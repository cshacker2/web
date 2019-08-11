#!/usr/bin/env python3

import matplotlib.pyplot as plt
import gdal
from gdal_data_loader import GdalDataLoader

def plot_img(img):
    plt.figure()
    plt.imshow(img)
    plt.colorbar()
    plt.grid(False)
    plt.show()

def make_results(img, width, height):
    ret = []
    for y in range(0, int(img.shape[1]/height)):
        for x in range(0, int(img.shape[2]/width)):
            if x%2 == 0:
                ret.append(1)
            else:
                ret.append(0)
    return ret


# Main for test
Gdalimg_path = './test.tif'
output_path = "./test_output.tif"
img_file = gdal.Open(Gdalimg_path, gdal.GA_Update)

img = img_file.ReadAsArray()
print(img.shape)
plot_img(img[0])
plot_img(img[2])

width = 32
height = 32
results = make_results(img, width, height)

GdalDataLoader(Gdalimg_path).writeImage(results, width, height, output_path)

img_file = gdal.Open(output_path, gdal.GA_ReadOnly)
img = img_file.ReadAsArray()

print(img.shape)

plot_img(img[0])
plot_img(img[2])
