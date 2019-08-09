#!/usr/bin/env python3

import numpy as np
from gdal_reader import GdalDirectoryReader

from mpl_toolkits.mplot3d import Axes3D
import matplotlib.pyplot as plt

def plot_scatter(data0, data1):
    fig = plt.figure()
    ax = fig.add_subplot(111, projection='3d')
   
    #data0 -> red / O
    swapped_data = np.swapaxes(data0, 0, 1)
    ax.scatter(swapped_data[0], swapped_data[1], swapped_data[2], c = 'r', marker='o')
   
    #data1 -> blue / ^
    swapped_data = np.swapaxes(data1, 0, 1)
    ax.scatter(swapped_data[0], swapped_data[1], swapped_data[2], c = 'b', marker='^')
    plt.show()


# Main for read and plot data
Gdalimg_path = '../data/training/open_water/'
open_water_imgs = GdalDirectoryReader(Gdalimg_path).getImages(100, 100, 3)
open_water_means = np.mean(np.mean(open_water_imgs, axis=3), axis=2)

Gdalimg_path = '../data/training/sea_ice/'
sea_ice_imgs = GdalDirectoryReader(Gdalimg_path).getImages(100, 100, 3)
sea_ice_means = np.mean(np.mean(sea_ice_imgs, axis=3), axis=2)

# scatter plot
plot_scatter(open_water_means, sea_ice_means)
