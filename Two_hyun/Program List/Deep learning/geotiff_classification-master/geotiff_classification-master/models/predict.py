#!/usr/bin/env python3

import tensorflow as tf

from tensorflow.python.keras.optimizers import SGD
from tensorflow.python.keras.utils import to_categorical
from tensorflow.python.keras.models import load_model


import sys
sys.path.insert(0, '../preprocessing')
import getopt
from gdal_data_loader import GdalDataLoader
import numpy as np
import struct

from model_loader import mlp_model, simple_cnn_model

def help():
    print("Usage..... not documented yet.")
    return

def main():
    try:
        opts, args = getopt.getopt(sys.argv[1:], "himpcwhton", ["help", "input=", "model=", "weights=", "channel=", "width=", "height=", "output=", "normalize="])
    except getopt.GetoptError as err:
        print(str(err))
        help()
        sys.exit(1)

    #Default Parmas
    CHANNEL = 3
    WIDTH = 32
    HEIGHT = 32
    INPUT_FILE =  '../data/test/subset_2_of_S1A_EW_GRDM_1SDH_20160127T142137_20160127T142237_009681_00E1EF_FFF4.tif'
    OUTPUT_PATH = './output/'
    MODEL = "mlp"
    WEIGHTS_FILE='saved_models/mlp_0.001.h5'
    NORM_PATH = '../data/training/norm.txt'


    for opt,arg in opts:
        if opt == "h" or opt == "--help":
            help()
            sys.exit(1)
        elif opt == "i" or opt == "--input":
            INPUT_FILE = arg
        elif opt == "o" or opt == "--output":
            OUTPUT_PATH = arg
        elif opt == "p" or opt == "--weights":
            WEIGHTS_FILE = arg
        elif opt == "c" or opt == "--channel":
            CHANNEL = int(arg)
        elif opt == "w" or opt == "--width":
            WIDTH = int(arg)
        elif opt == "h" or opt == "--height":
            HEIGHT = int(arg)
        elif opt == "n" or opt == "--normalize":
            NORM_PATH = arg


    OUTPUT_FILE = OUTPUT_PATH + '/' + INPUT_FILE.rsplit('/', 1)[1].strip() + "_output.bin"

    data_loader = GdalDataLoader(INPUT_FILE)
    (imgs, y, x) = data_loader.getImage(CHANNEL, WIDTH, HEIGHT, True, False, NORM_PATH)

    model = load_model(WEIGHTS_FILE)
    output = np.argmax(model.predict(imgs), axis=1)

    # print results!
    data_loader.writeImage(output, WIDTH, HEIGHT, OUTPUT_FILE) 
    #print_pretty(output, y, x, INPUT_FILE)

if __name__ == '__main__':
    main()
