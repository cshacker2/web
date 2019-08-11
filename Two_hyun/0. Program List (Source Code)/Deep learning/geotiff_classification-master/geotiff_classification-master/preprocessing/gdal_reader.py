#!/usr/bin/env python3

import sys
sys.path.append('/home/hkryu/utils/gdal/lib64/python3.6/site-packages/GDAL-2.4.0-py3.6-linux-x86_64.egg')
import gdal
import os
import random
import numpy as np
import math

# Util Func for per channel normalize gdal images.
# mins and maxes are min and max values per channel
def normalize(imgs, mins = [], maxes = []):
    if mins:
        assert(len(mins) == imgs.shape[1])
    if maxes:
        assert(len(maxes) == imgs.shape[1])
   
    for channel in range(imgs.shape[1]):
        if not mins:
            MIN = np.min(imgs[:,channel,:,:])
        else:
            MIN = mins[channel]

        if not maxes:
            MAX = np.max(imgs[:,channel,:,:])
        else:
            MAX = maxes[channel]

        imgs[:,channel,:,:] = (imgs[:,channel,:,:] - MIN) / (MAX- MIN)
    return imgs

# Util Func for per channel normalize gdal images.
def cosTheta(imgs):
    imgs[:,0,:,:] = imgs[:,0,:,:] * np.cos(imgs[:,2,:,:]*np.pi/180)
    return imgs



# Class GdalDirectoryReader
# construct with directory that has only tif files!
class GdalDirectoryReader:
    def __init__(self, init_path):
        self.path = init_path

    # Func getImages
    #   - pick random numFiles in directory,
    #     crop it to width, height, and make it to ndarray
    # Params width, height are resolution of return images.
    # Params numFiles is number of files to make images.
    def getImages(self, channel, width, height, numFiles = 0):
        if numFiles == 0:
            files = next(os.walk(self.path))[2]
            numFiles = len(files)
        else:
            files = random.sample(next(os.walk(self.path))[2], numFiles)
        ret = []
        it = 0
        numImgs = 0;
        for f in files:
            it = it + 1
            if it > numFiles:
                break # Alreay read numFiles!

            gdal_img = gdal.Open(self.path + "/" + f, gdal.GA_ReadOnly)
            array = gdal_img.ReadAsArray()
            # gdal_img should have same channel
            if gdal_img.RasterCount != channel:
                continue

            #crop it!
            for y in range(int(array.shape[1]/height)):
                for x in range(int(array.shape[2]/width)):
                    ret.append(array[:, y*height:y*height+height, x*width:x*width+width,])
            numImgs = numImgs + int(array.shape[2]/width) * int(array.shape[1]/height)
        return np.concatenate(ret).reshape([numImgs, channel, height, width])


    # Func getImage
    #   - read file  crop it to width, height, and make it to ndarray
    # Params width, height are resolution of return images.
    def getImage(self, channel, width, height):
        ret = []
        numImgs = 0;
        gdal_img = gdal.Open(self.path, gdal.GA_ReadOnly)
        array = gdal_img.ReadAsArray()
        # gdal_img should have same channel
        assert(gdal_img.RasterCount == channel)

        #crop it!
        for y in range(int(array.shape[1]/height)):
            for x in range(int(array.shape[2]/width)):
                ret.append(array[:, y*height:y*height+height, x*width:x*width+width,])
        vert_imgs = int(array.shape[2]/width)
        horz_imgs = int(array.shape[1]/height)
        numImgs = vert_imgs * horz_imgs
        return (np.concatenate(ret).reshape([numImgs, channel, height, width]), horz_imgs, vert_imgs)
