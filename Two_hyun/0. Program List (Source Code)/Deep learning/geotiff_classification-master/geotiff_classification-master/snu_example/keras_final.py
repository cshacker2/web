#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Tue May 29 15:55:27 2018

@author: user
"""


import numpy as np
import gdal
from keras.models import Sequential
from keras.layers import Dense
from keras.models import load_model
from osgeo import gdal
import os
import csv
#from keras.utils.training_utils import multi_gpu_model
#from keras.callbacks import EarlyStopping


#os.environ["CUDA_DEVICE_ORDER"] = "PCI_BUS_ID"
#os.environ["CUDA_VISIBLE_DEVICES"] = ""

dirlist_water = next(os.walk('/home/jonhpark/workspace/tensor_sentinal/training/open_water/'))[2]#1260
print("JH!!!")
dirlist_ice = next(os.walk('/home/jonhpark/workspace/tensor_sentinal/training/sea_ice/'))[2]#2532
water_lenth = len(dirlist_water)
ice_lenth = len(dirlist_ice)
dir_loop_water = 0
dir_loop_ice = 0
dataset=[]
print('varialble define done')
while dir_loop_water < water_lenth:

    ds_water = gdal.Open('/home/jonhpark/workspace/tensor_sentinal/training/open_water/'+ dirlist_water[dir_loop_water] , gdal.GA_ReadOnly)
    numer_of_band_water = str(ds_water.RasterCount)
    if numer_of_band_water == '3':
        print('water condition matched')

        rb_water = ds_water.GetRasterBand(1)
        band1_water_tmp = rb_water.ReadAsArray()
        band1_water = band1_water_tmp.tolist()

        rb2_water = ds_water.GetRasterBand(2)
        band2_water_tmp = rb2_water.ReadAsArray()
        band2_water = band2_water_tmp.tolist()

        rb3_water = ds_water.GetRasterBand(3)
        band3_water_tmp = rb3_water.ReadAsArray()
        band3_water = band3_water_tmp.tolist()

        [cols_water,rows_water] = band1_water_tmp.shape
        loop_water_cols = 0

        while loop_water_cols < cols_water:

            loop_water_rows = 0

            while loop_water_rows < rows_water:


                dataset.append([band1_water[loop_water_cols][loop_water_rows],band2_water[loop_water_cols][loop_water_rows],band3_water[loop_water_cols][loop_water_rows],0])

                loop_water_rows = loop_water_rows +1
            del dataset[0]
            with open('/home/jonhpark/workspace/tensor_sentinal/dataset_final.csv', 'a') as f:

                    writer = csv.writer(f)
                    writer.writerows(dataset)
                    f.close()
            dataset= [None]
            loop_water_cols = loop_water_cols +1
    dir_loop_water= dir_loop_water+1
print('water_set deone')

while dir_loop_ice < ice_lenth:

    ds_ice = gdal.Open('/home/jonhpark/workspace/tensor_sentinal/training/sea_ice/'+ dirlist_ice[dir_loop_ice] , gdal.GA_ReadOnly)
    numer_of_band_ice = str(ds_ice.RasterCount)
    if numer_of_band_ice == '3':
        print('ice condition matched')
        rb_ice = ds_ice.GetRasterBand(1)
        band1_ice_tmp = rb_ice.ReadAsArray()
        band1_ice = band1_ice_tmp.tolist()

        rb2_ice = ds_ice.GetRasterBand(2)
        band2_ice_tmp = rb2_ice.ReadAsArray()
        band2_ice = band2_ice_tmp.tolist()

        rb3_ice = ds_ice.GetRasterBand(3)
        band3_ice_tmp = rb3_ice.ReadAsArray()
        band3_ice = band3_ice_tmp.tolist()

        [cols_ice,rows_ice] = band1_ice_tmp.shape
        loop_ice_cols = 0

        while loop_ice_cols < cols_ice:

            loop_ice_rows = 0

            while loop_ice_rows < rows_ice:

                dataset.append([band1_ice[loop_ice_cols][loop_ice_rows],band2_ice[loop_ice_cols][loop_ice_rows],band3_ice[loop_ice_cols][loop_ice_rows],1])
                loop_ice_rows = loop_ice_rows +1

            del dataset[0]

            with open('/home/jonhpark/workspace/tensor_sentinal/dataset_final.csv', 'a') as f:

                writer = csv.writer(f)
                writer.writerows(dataset)

            dataset=[None]


            loop_ice_cols = loop_ice_cols +1

    dir_loop_ice= dir_loop_ice+1

print('ice_set done')
print('all data set done')



print('get in deep_learning')
dataset_csv = np.loadtxt('/home/jonhpark/workspace/tensor_sentinal/dataset_final.csv', delimiter=',')
[cols_input,rows_input] = dataset_csv.shape



x_train=dataset_csv[:int(round(cols_input*0.9)),0:3]
y_train=dataset_csv[:int(round(cols_input*0.9)),3]
x_test=dataset_csv[int(round(cols_input*0.9)):,0:3]
y_test=dataset_csv[int(round(cols_input*0.9)):,3]


model =Sequential()
model.add(Dense(512,input_shape=(3,),activation='relu'))
model.add(Dense(256,activation='relu'))
model.add(Dense(128,activation='relu'))
model.add(Dense(64, activation='relu'))
model.add(Dense(32, activation='relu'))
model.add(Dense(16, activation='relu'))
model.add(Dense(8,  activation='relu'))
model.add(Dense(4,  activation='relu'))
model.add(Dense(2,  activation='relu'))
model.add(Dense(1,  activation='sigmoid'))
#model = multi_gpu_model(model, gpus=4)
model.compile(loss='binary_crossentropy', optimizer = 'adam', metrics = ['accuracy'])
#early_stopping  = EarlyStopping(patience =3 )
#model.fit(x_train,y_train,epochs =2 , batch_size =32  ,  callbacks = [early_stopping])
model.fit(x_train,y_train,epochs =2 , batch_size =32 )


scores = model.evaluate(x_test,y_test)
#print("%s:.2f%%"%(model.metrics_names[1], scores[1]*100))
model.save('/home/jonhpark/workspace/tensor_sentinal/test.h5')

print('learning and save model done')


model = load_model('/home/jonhpark/workspace/tensor_sentinal/seaice_keras_model_final.h5')
dirlist_input = next(os.walk('/home/jonhpark/workspace/tensor_sentinal/part_input/'))[2]
dirlist_input_lenth= len(dirlist_input)

dir_input_loop = 0

print('classification start')
while dir_input_loop < dirlist_input_lenth:

    ds_input = gdal.Open('/home/jonhpark/workspace/tensor_sentinal/part_input/'+ dirlist_input[dir_input_loop] , gdal.GA_ReadOnly)
    numer_of_band_input = str(ds_input.RasterCount)
    if numer_of_band_input == '3':

        rb_input = ds_input.GetRasterBand(1)
        band1_input = rb_input.ReadAsArray()


        rb2_input = ds_input.GetRasterBand(2)
        band2_input = rb2_input.ReadAsArray()


        rb3_input = ds_input.GetRasterBand(3)
        band3_input = rb3_input.ReadAsArray()
        geotrans = ds_input.GetGeoTransform()
        getproj = ds_input.GetProjection()

        [cols_input,rows_input] = band1_input.shape
        input_cols_loop =0

        while input_cols_loop <cols_input:
            input_rows_loop = 0
            while input_rows_loop < rows_input:
                if band1_input[input_cols_loop][input_rows_loop] > 0:

                    prediction_prob = model.predict(np.array([[band1_input[input_cols_loop][input_rows_loop],band2_input[input_cols_loop][input_rows_loop],band3_input[input_cols_loop][input_rows_loop]]]))
                    if prediction_prob >=0:
                        class_name = int(round(prediction_prob[0][0]))
                        band1_input[input_cols_loop,input_rows_loop] = class_name



        driver = gdal.GetDriverByName('GTiff')
        data = driver.Create('/home/jonhpark/workspace/tensor_sentinal/output/'+dirlist_input[ dir_input_loop][0:67]+'_output'+'.tif',rows_input, cols_input, 1, gdal.GDT_Float32,)

        data.SetGeoTransform(geotrans)
        data.SetProjection(getproj)

        outband=band1_input
        data.GetRasterBand(1).WriteArray(outband)
        print(dir_input_loop+1,'file done')
        dir_input_loop = dir_input_loop +1
    else:
        print(dirlist_input[dir_input_loop]+'is not 3 bands')

print('model summery')
print("model structure: ", model.summary())
print("model weights: ", model.get_weights())
