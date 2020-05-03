#pragma once
#include <opencv2/core.hpp>
#include <opencv2/imgproc.hpp>
#include <opencv2/highgui.hpp>
#include "Contours.h"
class Processer
{
public:
	Processer(void);
	~Processer(void);

	cv::Mat ProcessImage(char *path)
	{
		cv::Mat original = cv::imread(path);
		cv::Mat invertedimage;
		cv::Mat gauss ;
		cv::GaussianBlur(original,gauss,cv::Size(15,15),10);
		cv::absdiff(original,gauss,gauss);
		return gauss;
	};

	cv::Mat ProcessAndSaveImage(char *path, char* pathtosave)
	{
		Contours c;
		cv::Mat original = cv::imread(path);
		cv::Mat processed = c.computeContours(original);
		cv::imwrite(pathtosave, processed);
		return processed;
	};
};

