#!/usr/bin/env python3

import tensorflow as tf

from tensorflow.python.keras.optimizers import SGD
from tensorflow.python.keras.utils import to_categorical, multi_gpu_model

import sys
sys.path.insert(0, '../preprocessing')
import getopt
from gdal_data_loader import GdalDataLoader
import numpy as np

from model_loader import mlp_model, simple_cnn_model, resnet_model


def help():
    print("Usage..... not documented yet.")
    return

def main():
    try:
        opts, args = getopt.getopt(sys.argv[1:], "ihlmcwhbendw", ["help", "input=", "learningrate=", "model=", "channel=", "width=", "height=","batch=", "epoch=", "normalize=", "depth=", "weights="])
    except getopt.GetoptError as err:
        print(str(err))
        help()
        sys.exit(1)

    #Default Parmas
    CHANNEL = 3
    WIDTH = 32
    HEIGHT = 32
    BATCH_SIZE = 32
    LEARNING_RATE = 0.001
    MODEL = "mlp"
    EPOCH = 1000
    Gdalimg_path = '../data/training/'
    NORM_PATH = '../data/training/norm.txt'
    RESNET_DEPTH = 20
    SAVE_PATH = 'saved_models/' + MODEL + "_" + str(LEARNING_RATE)+".h5"

    for opt,arg in opts:
        if opt == "h" or opt == "--help":
            help()
            sys.exit(1)
        elif opt == "l" or opt == "--learningrate":
            LEARNING_RATE = float(arg)
        elif opt == "m" or opt == "--model":
            MODEL = arg
        elif opt == "c" or opt == "--channel":
            CHANNEL = int(arg)
        elif opt == "w" or opt == "--width":
            WIDTH = int(arg)
        elif opt == "h" or opt == "--height":
            HEIGHT = int(arg)
        elif opt == "b" or opt == "--batch":
            BATCH = int(arg)
        elif opt == "e" or opt == "--epoch":
            EPOCH = int(arg)
        elif opt == "i" or opt == "--input":
            Gdalimg_path = arg
        elif opt == "n" or opt == "--normalize":
            NORM_PATH = arg
        elif opt == "d" or opt == "--depth":
            RESNET_DEPTH = int(arg)
        elif opt == "w" or opt == "--weights":
            SAVE_PATH = arg + ".h5"







    (total_imgs, total_labels, num_categ) = GdalDataLoader(Gdalimg_path).getAllImages(CHANNEL, WIDTH, HEIGHT, True, False, True, NORM_PATH)
    print("NUMCATEG: " +  str(num_categ))

    total_labels = to_categorical(total_labels)

    if MODEL == "mlp":
      model = mlp_model(total_imgs.shape[1:], num_categ)
    elif MODEL == "simple_cnn":
      model = simple_cnn_model(total_imgs.shape[1:], num_categ)
    elif MODEL == "resnet":
      model = resnet_model(total_imgs.shape[1:], RESNET_DEPTH, num_categ)
    else:
      model = mlp_model(total_imgs.shape[1:], num_categ)

    model = multi_gpu_model(model,gpus=4)
    sgd = SGD(lr=LEARNING_RATE)
    model.compile(optimizer=sgd,
            loss='categorical_crossentropy',
            metrics=['accuracy'])
    model.fit(total_imgs, total_labels, epochs=EPOCH, batch_size=BATCH_SIZE
            ,validation_split=0.1, shuffle=True, verbose=2)

    model.save(SAVE_PATH)


if __name__ == '__main__':
    main()
