#!/usr/bin/env python3

from gdal_reader import GdalDirectoryReader
from gdal_reader import normalize, cosTheta
import gdal
import os
import numpy as np
import cv2

def parseNorm(path):
    with open(path) as f:
        mins = list(map(float, f.readline().strip().split(",")))
        maxes = list(map(float, f.readline().strip().split(",")))
    return (mins, maxes)

    
    

class GdalDataLoader:
  def __init__(self, init_path):
    self.path = init_path

    if os.path.isdir(init_path):
      self.subDirectories = next(os.walk(self.path))[1]
    else:
      self.subDirectories = []

  # if balance is true, discard some data to match the number of data for each category
  def getAllImages(self, channel, width, height, doNormalize=True, doCosTheta=True, balance=False, NORM_PATH=""):
    imgs = []
    labels = []
    numImgs = []
    index = 0

    for subDir in self.subDirectories:
      imgs.append(GdalDirectoryReader(self.path + subDir).getImages(channel, width, height))
      if doCosTheta:
        imgs[index] = cosTheta(imgs[index])
      if doNormalize:
          if not NORM_PATH:
              imgs[index] = normalize(imgs[index])
          else:
              (mins, maxes) = parseNorm(NORM_PATH);
              imgs[index] = normalize(imgs[index], mins, maxes)
 

      numImgs.append(imgs[index].shape[0])
      labels.append(np.array([index] * numImgs[index]))
      print(str(index) + ": " + str(subDir) + ", " + str(numImgs[index]), " images")
      index = index + 1

    if balance:
      minNumImgs = min(numImgs)
      labels = []

      for i in range(index):
        randid = np.random.randint(numImgs[i], size=minNumImgs)
        imgs[i] = imgs[i][randid,:]
        labels.append(np.array([i] * minNumImgs))

    return (np.concatenate(imgs) , np.concatenate(labels), index)


  # read 1 image, path should be a image file.
  def getImage(self, channel, width, height, doNormalize=True, doCosTheta=True, NORM_PATH=""):

    (imgs, y, x) = (GdalDirectoryReader(self.path).getImage(channel, width, height))
    if doCosTheta:
      imgs = cosTheta(imgs)
    if doNormalize:
      if not NORM_PATH:
          imgs = normalize(imgs)
      else:
          (mins, maxes) = parseNorm(NORM_PATH);
          imgs = normalize(imgs, mins, maxes)

    return (imgs, y, x)

  # copy and update geotiff image. write results to 1st channel.
  # results. first stretch it
  # "width", "height" is size of trained network input.
  def writeImage(self, results, width, height, outputPath):
    # 1. copy input to output
    copy_command = 'cp ' + self.path + ' ' + outputPath
    os.system(copy_command)

    # 2. read input file
    input_file = gdal.Open(self.path, gdal.GA_ReadOnly)

    # 3. resize results(ndarray -> cv2)
    xs = int(input_file.RasterXSize/width)
    ys = int(input_file.RasterYSize/height)
    toWrite = cv2.resize(np.reshape(results, (ys, xs)).astype(float), (input_file.RasterXSize, input_file.RasterYSize),interpolation=cv2.INTER_NEAREST)

    # 4. write it.
    output_file = gdal.Open(outputPath, gdal.GA_Update)
    output_file.GetRasterBand(1).WriteArray(toWrite)
    output_file = None
