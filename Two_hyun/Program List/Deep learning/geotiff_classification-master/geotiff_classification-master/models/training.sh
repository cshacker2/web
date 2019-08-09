#!/bin/bash


for lr in 0.01 0.005 0.001 0.0005 0.0001
do
  ./training.py --learningrate "$lr" --model resnet --depth 20 --epoch 1000 > results/resnet_"$lr"_20_output.txt
done

for lr in 0.01 0.005 0.001 0.0005 0.0001
do
  ./training.py --learningrate "$lr" --model resnet --depth 32 --epoch 1000 > results/resnet_"$lr"_32_output.txt
done


for lr in 0.01 0.005 0.001 0.0005 0.0001
do
  ./training.py --learningrate "$lr" --model simple_cnn --epoch 500 > results/simple_cnn_"$lr"_output.txt
done


for lr in 0.01 0.005 0.001 0.0005 0.0001
do
  ./training.py --learningrate "$lr" --model mlp --epoch 500 > results/mlp_"$lr"_output.txt
done
