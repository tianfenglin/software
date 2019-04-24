# -*- coding: utf-8 -*-
# 第一行的目的，是为了让代码里面，可以有中文注释信息.  (否则要运行报错)
import os
import sys
#文件路径必须 \\ 否则出错
def SelectAllFilesByPath(path):
     '''
     获取文件
     path: 文件夹路径 
     return:文件夹下的文件
     '''
     list = os.listdir(path)
     return list