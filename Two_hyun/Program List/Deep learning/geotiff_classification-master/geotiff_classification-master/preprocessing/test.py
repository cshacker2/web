#!/usr/bin/env python3

from gdal_reader import GdalDirectoryReader
from gdal_reader import normalize
import matplotlib.pyplot as plt

def plot_img(img):
    plt.figure()
    plt.imshow(img)
    plt.colorbar()
    plt.grid(False)
    plt.show()


# Main for test
Gdalimg_path = '../data/training/open_water/'
train_imgs = GdalDirectoryReader(Gdalimg_path).getImages(100, 100, 10)
train_imgs = normalize(train_imgs)

print(train_imgs.shape)

#plot for debug
plot_img(train_imgs[0][0])
plot_img(train_imgs[0][1])
plot_img(train_imgs[0][2])
