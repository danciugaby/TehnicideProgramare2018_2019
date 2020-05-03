#pragma once
#include <opencv2/core.hpp>
#include <opencv2/imgproc.hpp>
#include <opencv2/highgui.hpp>
#include <vector>
class Histogram
{
public:
	Histogram(void);
	~Histogram(void);
	std::vector<float> ComputeHistogram(cv::Mat & original);	
};
void GetRegions(cv::Mat & gray, cv::Mat & segmentedimage, int minX, int maxX);
