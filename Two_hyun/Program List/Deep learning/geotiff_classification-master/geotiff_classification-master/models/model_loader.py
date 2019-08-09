#!/usr/bin/env python3

import tensorflow as tf

from tensorflow.python.keras.models import Sequential, Model
from tensorflow.python.keras.layers import Conv2D, MaxPooling2D, BatchNormalization, add, AveragePooling2D
from tensorflow.python.keras.layers import Activation, Dropout, Flatten, Dense, Input
from tensorflow.python.keras.optimizers import SGD
from tensorflow.python.keras.utils import to_categorical
from tensorflow.python.keras.regularizers import l2



def mlp_model(inputShape = (2,32,32), numCategories = 2, layers = [128]):
    model = Sequential()
    model.add(Flatten(input_shape=inputShape))
    for layer in layers:
        model.add(Dense(layer, activation='relu'))
    model.add(Dense(numCategories, activation='softmax'))
    return model

def simple_cnn_model(inputShape = (2,32,32), numCategories = 2):
    model = Sequential()

    model.add(Conv2D(32, (3,3), data_format="channels_first", input_shape=inputShape))
    model.add(Activation('relu'))
    model.add(MaxPooling2D(pool_size=(2,2)))
    model.add(Dropout(0.25))

    model.add(Conv2D(64, (3,3), data_format="channels_first"))
    model.add(Activation('relu'))
    model.add(MaxPooling2D(pool_size=(2,2)))
    model.add(Dropout(0.25))

    model.add(Flatten())
    model.add(Dense(128, activation='relu'))
    model.add(Dropout(0.5))
    model.add(Dense(numCategories, activation='softmax'))

    model.add(Dense(numCategories, activation='softmax'))
    return model


def resnet_layer(inputs,
        num_filters=16,
        kernel_size=3,
        strides=1,
        activation='relu',
        batch_normalization=True,
        conv_first=True):

    conv = Conv2D(num_filters,
            kernel_size=kernel_size,
            strides=strides,
            padding='same',
            kernel_initializer='he_normal',
            kernel_regularizer=l2(1e-4),
            data_format="channels_first")

    x = inputs
    if conv_first:
        x = conv(x)
        if batch_normalization:
            x = BatchNormalization()(x)
        if activation is not None:
            x = Activation(activation)(x)
    else:
        if batch_normalization:
            x = BatchNormalization()(x)
        if activation is not None:
            x = Activation(activation)(x)
        x = conv(x)
    return x


def resnet_model(input_shape, depth=20, num_classes=2):

    if (depth - 2) % 6 != 0:
        raise ValueError('depth should be 6n+2 (eg 20, 32, 44 in [a])')
    # Start model definition.
    num_filters = 16
    num_res_blocks = int((depth - 2) / 6)

    inputs = Input(shape=input_shape)
    x = resnet_layer(inputs=inputs)
    # Instantiate the stack of residual units
    for stack in range(3):
        for res_block in range(num_res_blocks):
            strides = 1
            if stack > 0 and res_block == 0:  # first layer but not first stack
                strides = 2  # downsample
            y = resnet_layer(inputs=x,
                    num_filters=num_filters,
                    strides=strides)
            y = resnet_layer(inputs=y,
                    num_filters=num_filters,
                    activation=None)
            if stack > 0 and res_block == 0:  # first layer but not first stack
                # linear projection residual shortcut connection to match
                # changed dims
                x = resnet_layer(inputs=x,
                        num_filters=num_filters,
                        kernel_size=1,
                        strides=strides,
                        activation=None,
                        batch_normalization=False)
                x = add([x, y])
            x = Activation('relu')(x)
        num_filters *= 2

    # Add classifier on top.
    # v1 does not use BN after last shortcut connection-ReLU
    x = AveragePooling2D(pool_size=8)(x)
    y = Flatten()(x)
    outputs = Dense(num_classes,
            activation='softmax',
            kernel_initializer='he_normal')(y)

    # Instantiate model.
    model = Model(inputs=inputs, outputs=outputs)
    return model

